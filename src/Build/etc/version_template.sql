--
--
MERGE INTO PAWNSEC.STOREAPPVERSION A USING
 (SELECT
  [APPID] as "ID",
  '[APPVERSION]' as "APPVERSION",
  '[DESCRIPTION] [APPVERSION] Release' as "DESCRIPTION",
  TO_TIMESTAMP_TZ('3/16/2010 10:57:53.000000 AM -05:00','fmMMfm/fmDDfm/YYYY fmHH12fm:MI:SS.FF AM TZH:TZM') as "CREATIONDATE",
  'admin' as "CREATEDBY",
  TO_TIMESTAMP_TZ('[TIMESTAMP]','fmMMfm/fmDDfm/YYYY fmHH12fm:MI:SS.FF AM TZH:TZM') as "LASTUPDATEDATE",
  'admin' as "UPDATEDBY",
  '[APPVERSIONHASH]' as "VERCHK"
  FROM DUAL) B
ON (A.ID = B.ID)
WHEN NOT MATCHED THEN 
INSERT (
  ID, APPVERSION, DESCRIPTION, CREATIONDATE, CREATEDBY, 
  LASTUPDATEDATE, UPDATEDBY, VERCHK)
VALUES (
  B.ID, B.APPVERSION, B.DESCRIPTION, B.CREATIONDATE, B.CREATEDBY, 
  B.LASTUPDATEDATE, B.UPDATEDBY, B.VERCHK)
WHEN MATCHED THEN
UPDATE SET 
  A.APPVERSION = B.APPVERSION,
  A.DESCRIPTION = B.DESCRIPTION,
  A.CREATIONDATE = B.CREATIONDATE,
  A.CREATEDBY = B.CREATEDBY,
  A.LASTUPDATEDATE = B.LASTUPDATEDATE,
  A.UPDATEDBY = B.UPDATEDBY,
  A.VERCHK = B.VERCHK;

COMMIT;
