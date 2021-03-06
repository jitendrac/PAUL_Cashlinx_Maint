﻿using System;
using System.Data;
using System.Windows.Forms;
using Common.Controllers.Application;
using Common.Controllers.Application.ApplicationFlow.Navigation;
using Common.Controllers.Database.Procedures;
using Common.Libraries.Forms.Components;
using Common.Libraries.Objects.Business;
using Common.Libraries.Utility;
using Common.Libraries.Utility.Shared;
using Pawn.Logic;
//Odd lock....
namespace Pawn.Forms.GunUtilities.EditGunBook
{
    public partial class GunBookSearch : CustomBaseForm
    {
        public NavBox NavControlBox;
        public GunBookSearch()
        {
            InitializeComponent();
            NavControlBox = new NavBox
            {
                Owner = this
            };
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            string errorCode;
            string errorText;
            DataTable gunTableData;
            Item gunItemData;
            if (!string.IsNullOrEmpty(txtGunNumber.Text))
            {


                bool retVal = MerchandiseProcedures.GetGunData(GlobalDataAccessor.Instance.OracleDA,
                    GlobalDataAccessor.Instance.CurrentSiteId.StoreNumber,
                    Utilities.GetIntegerValue(txtGunNumber.Text),
                    out gunTableData,
                    out gunItemData,
                    out errorCode,
                    out errorText);

                if (retVal && errorText.Contains("No Merchandise data found"))
                {
                    MessageBox.Show(Commons.GetMessageString("GunEditErrorMessage"));
                    txtGunNumber.Focus();
                    return;
                }

                if (!retVal)
                {
                    MessageBox.Show("Invalid Gun Number");
                    txtGunNumber.Focus();
                    return;
                }

                GlobalDataAccessor.Instance.DesktopSession.GunData = gunTableData;
                CashlinxDesktopSession.Instance.GunItemData = gunItemData;

                NavControlBox.Action = NavBox.NavAction.BACKANDSUBMIT;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            NavControlBox.Action = NavBox.NavAction.CANCEL;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || (this.ActiveControl.Equals(cancelButton) && keyData == Keys.Enter))
            {
                this.cancelButton_Click(null, new EventArgs());
                return true;
            }

            if (keyData == Keys.Enter)
            {
                this.submitButton_Click(null, new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

   

  


    }
}
