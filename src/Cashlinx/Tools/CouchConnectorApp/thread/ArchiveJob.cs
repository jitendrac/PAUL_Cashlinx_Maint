﻿using System;
using System.Diagnostics;
using System.Threading;
using CouchConsoleApp.couch;
using CouchConsoleApp.db;
using CouchConsoleApp.vo;


namespace CouchConsoleApp.thread
{
    public class ArchiveJob
    {
        private PawnDocRegVO vo = null;
        private CouchVo srcCouchVO;
        private CouchVo targetCouchVO;
        private bool GotDoc = false;
        private bool SavedDoc = false;
        private bool DBTransComp = false;
        private bool SouceDocDeleted = false;
        private bool isRecovery = false;

        private string storageID = "";
        //private string rDocument = null;
        private string exception = "";
        public const char CHAR_CODE_SUCCESS = 'Y';

        private bool criticalError = false;
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(ArchiveJob));

        private bool GAD_Error_Occured = false;

        public ArchiveJob(PawnDocRegVO vo, CouchVo srcCouchVO, CouchVo targetCouchVO, bool isRecovery)
        {
            this.vo = vo;
            this.srcCouchVO = srcCouchVO;
            this.targetCouchVO = targetCouchVO;
            this.isRecovery = isRecovery;
        }

        public vo.PawnDocRegVO getVO()
        {
            return this.vo;
        }
        
        public bool isJobSuccess()
        {
            return DBTransComp;
        }

        public bool criticalErrorState()
        {
            return criticalError;
        }


        public void process()
        {
            var totalTime = new Stopwatch();
            var timeForexec = new Stopwatch();
            long getTime = 0;
            long addTime = 0;
            long delTime = 0;
            long finalUpdate = 0;
            string str1 = "";
            string rDocument = null;
            try
            {
                totalTime.Start();
                timeForexec.Start();
                rDocument=getDocumentFromCouch();
                timeForexec.Stop();
                getTime = timeForexec.ElapsedMilliseconds;
                if (!GotDoc)
                {
                    updateDBForError(ArchiveJobError.ErrorType.G);
                    return;
                }
                timeForexec.Restart();
                AddDocumentToCouch(rDocument);
                timeForexec.Stop();
                addTime = timeForexec.ElapsedMilliseconds;
                if (!SavedDoc)
                {
                    updateDBForError(ArchiveJobError.ErrorType.A);
                    return;
                }
                timeForexec.Restart();
                SouceDocDeleted = true;
                //delete stubbed
                deleteDocFromSource();
                timeForexec.Stop();
                delTime = timeForexec.ElapsedMilliseconds;
                if (!SouceDocDeleted)
                {
                    updateDBForError(ArchiveJobError.ErrorType.D);
                    return;
                }
                timeForexec.Restart();
                updateTablesForSuccess();
                timeForexec.Stop();
                finalUpdate = timeForexec.ElapsedMilliseconds;
                Thread.Sleep(10);
            }
            finally
            {
                str1 = string.Format("Doc ID {0} Storage ID {1} Target DBID {2} Got DOC {3} Added DOC {4} Delete DOC {5} Updated {6}",
                                     vo.DocID, vo.StorageID, vo.TargetCouchDBName, GotDoc, SavedDoc, SouceDocDeleted, DBTransComp);
                string str2 = string.Format("Doc ID {0} Get Time {1} add time {2} del time {3} final update {4}",vo.DocID,getTime, addTime, delTime,
                                            finalUpdate);
                //log.Debug("Total time: " + totalTime.ElapsedMilliseconds + " : " + str1);


                if (GAD_Error_Occured)
                {
                    log.Error("<<<<Total time: " + totalTime.ElapsedMilliseconds + " : " + str1+">>>");
                }
                rDocument = null;
                //for object clear
                this.vo = null;
                this.srcCouchVO.Dispose();
                this.targetCouchVO.Dispose();
            }
        }

        public string getDocumentFromCouch()
        {
            string rDocument = null;
            try
            {
                bool error;
                string retMSG;
                rDocument = CouchArchiverGetHelper.getInstance().GetRawDocument(out retMSG, out error, srcCouchVO, vo);
                if (error)
                {
                    GotDoc = false;
                }
                else
                {
                    GotDoc = true;
                }
                exception = retMSG;
            }
            catch(Exception e)
            {
                GotDoc = false;
                exception = e.Message;
                log.Error(string.Format("Get Doc failed for {0}, archive skipped for {1}", vo.StorageID, vo.DocID), e);
            }
            return rDocument;
        }

        public void AddDocumentToCouch(string rDocument)
        {
            try
            {
                bool error;
                string retMSG;
                this.targetCouchVO.dbName = vo.TargetCouchDBName;
                SavedDoc = CouchArchiverAddHelper.getInstance().Document_Add(rDocument, out error, out retMSG, targetCouchVO, vo.StorageID);
                this.storageID = vo.StorageID;
                if (!SavedDoc)
                {
                    if (retMSG != null && retMSG.Contains("already exists"))
                    {
                        SavedDoc = true;
                    }
                    log.Error("Add Document failed:" + retMSG);
                }
 
            }
            catch(Exception e)
            {
                log.Error(string.Format("Save Doc failed for {0} target db{1}", vo.StorageID, targetCouchVO.dbName), e);
                SavedDoc = false;
                exception = e.Message;
            }
            finally
            {
                rDocument = null;
            }
        }

        public void deleteDocFromSource()
        {
            try
            {
                bool error;
                string retMSG;
                SouceDocDeleted = CouchArchiverDeleteHelper.getInstance().Document_Delete(out retMSG, out error, srcCouchVO, vo.StorageID);
                //log.Debug(string.Format("Delete Document {0}:<msg from couch> {1}", vo.StorageID,exception));
            }
            catch(Exception e)
            {
                log.Error(string.Format("Document delete failed for {0} source db{1}", storageID, srcCouchVO.dbName), e);
                SouceDocDeleted = false;
            }
        }

        public void updateTablesForSuccess()
        {
            try
            {
                if (PwnArchLogDAO.getInstance().CreateArchLog(vo, CHAR_CODE_SUCCESS, isRecovery))
                {
                    DBTransComp = true;
                }
                else
                {
                    criticalError = true;
                    DBTransComp = false;
                }
            }
            catch(Exception e)
            {
                log.Error("updateTablesForSuccess Exception", e);
            }
        }

        public void updateDBForError(ArchiveJobError.ErrorType errorType)
        {
            string errorMsg = "";
            int errorCode = ArchJobErrorDesc.getInstance().getErrorCode(exception);
            bool success = false;
            GAD_Error_Occured = true;
            if (errorType == ArchiveJobError.ErrorType.G)
            {
                errorMsg = generateErrorMessage("Source Doc not found:");
                success = PwnArchLogDAO.getInstance().CreateArchLogWithError(vo, errorCode, errorMsg, 'G', isRecovery);
                if(!success)
                {
                    this.criticalError = true;
                }

                //make db call to update pawn doc reg
            }
            else if (errorType == ArchiveJobError.ErrorType.A)
            {
                errorMsg = generateErrorMessage("Add doc to target failed:");
                success = PwnArchLogDAO.getInstance().CreateArchLogWithError(vo, errorCode, errorMsg, 'A', isRecovery);
                if (!success)
                {
                    this.criticalError = true;
                }
            }
            else if (errorType == ArchiveJobError.ErrorType.D)
            {
                errorMsg = generateErrorMessage("Delete source failed:");
                success = PwnArchLogDAO.getInstance().CreateArchLogWithError(vo, errorCode, errorMsg, 'D', isRecovery);
                if (!success)
                {
                    this.criticalError = true;
                }
            }
            else
            {
                errorMsg = generateErrorMessage("Archive failed:");
                this.criticalError = true;
            }
        }

        private string generateErrorMessage(string msgPrefix)
        {
            string errorStr = "No info available";

            if (!string.IsNullOrEmpty(exception))
            {
                exception = msgPrefix + exception;

                if (exception.Length > 256)
                {
                    errorStr = exception.Substring(0, 256);
                }
                else
                {
                    errorStr = exception;
                }
            }
            return errorStr;
        }
    }
}