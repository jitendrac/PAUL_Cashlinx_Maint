﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Controllers.Application.ApplicationFlow.Navigation;
using Support.Libraries.Objects.PDLoan;
using Support.Logic;
using Common.Libraries.Utility.Shared;

namespace Support.Forms.Customer.Products
{
    public partial class ExtendedDepositDate : Form
    {
        List<ExtendedDateReasons> ReasonList = new List<ExtendedDateReasons>();

        private Form ownerfrm;
        public NavBox NavControlBox;
        /*__________________________________________________________________________________________*/
        public ExtendedDepositDate()
        {
            InitializeComponent();
            this.NavControlBox = new NavBox();

            ownerfrm = this.Owner;
            this.NavControlBox.Owner = this;
        }
        /*__________________________________________________________________________________________*/
        private void ExtendedDepositDate_Load(object sender, EventArgs e)
        {
            //PDLoanDetails PDLDetails = Support.Logic.CashlinxPawnSupportSession.Instance.ActivePDLoan.GetPDLoanDetails;
            //Support.Logic.CashlinxPawnSupportSession.Instance.ActivePDLoan.GetPDLoanDetails();
            //this.tbDepositDate.Text = PDLDetails.DueDate == DateTime.MaxValue ? "" : (PDLDetails.DueDate).FormatDate();
            //LoadReasons();
            var detailsObj = Support.Logic.CashlinxPawnSupportSession.Instance.DepositDateExtensionDetailsObject;
            this.tbDepositDate.Text = detailsObj.Cur_Dep_Date;
            this.lblValidExtendedDate.Text = detailsObj.Max_Extend_Date;

            var bindingSource = new BindingSource();
            bindingSource.DataSource = detailsObj.GetExtendedDateReasonsList;
            this.cbReasonCode.DataSource = bindingSource;
            this.cbReasonCode.DisplayMember = "Reason_Description";
            this.cbReasonCode.ValueMember = "ReasonCode";
        }
        /*__________________________________________________________________________________________*/
        private void LoadReasons()
        {
            //string[] descriptions = new string[] {
            //        "Personal",
            //        "Death in Family",
            //        "Incorrect Pay Date",
            //        "Illness/Hospitalization",
            //        "Missing Rq'd Documents",
            //        "Out of Town"
            //    };

            //for (int i = 0; i < descriptions.Length; i++)
            //{
            //    ExtendedDateReasons ExtendedReasons = new ExtendedDateReasons();
            //    ExtendedReasons.Reason_Description = descriptions[i];
            //    ExtendedReasons.ReasonCode = i.ToString();
            //    ReasonList.Add(ExtendedReasons);

            //}
            //int n = ReasonList.FindIndex(  item => item.Reason_Description == "Incorrect Pay Date");

        }
        /*__________________________________________________________________________________________*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.NavControlBox.IsCustom = true;
            this.NavControlBox.CustomDetail = "ProductsAndServices";
            this.NavControlBox.Action = NavBox.NavAction.BACK;
        }
        /*__________________________________________________________________________________________*/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var extendedDate = checkNull(this.dtpExtendedDate.Text);
            var reasonCode = checkNull(this.cbReasonCode.Text);

            if (extendedDate.Equals(string.Empty) || reasonCode.Equals(string.Empty))
            {
                MessageBox.Show("Please enter Extended Deposite Date and Reason code and hit submit.", "Form Invalid.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (DateTime.Parse(extendedDate) > DateTime.Parse(this.lblValidExtendedDate.Text))
                {
                    MessageBox.Show("Inavalid Date, the Extended Deposite Date should be less than " + DateTime.Parse(this.lblValidExtendedDate.Text).FormatDate(), "Invalid Date.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (DateTime.Parse(extendedDate) < DateTime.Now)
                {
                    MessageBox.Show("Inavalid Date, the Extended Deposite Date should be future date.", "Invalid Date.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                extendedDate = DateTime.Parse(extendedDate).FormatDate();
            }
            string errorCode;
            string errorDesc;
            var depositDetails = new DepositDateExtensionDetails();
            bool returnVal = Support.Controllers.Database.Procedures.CustomerLoans.UpdateDepositExtensionDate(
                Support.Logic.CashlinxPawnSupportSession.Instance.ActivePDLoan.PDLLoanNumber,
                extendedDate, reasonCode, out errorCode, out errorDesc);

            if (returnVal)
            {
                this.NavControlBox.IsCustom = true;
                this.NavControlBox.CustomDetail = "ProductsAndServices";
                this.NavControlBox.Action = NavBox.NavAction.BACK;
            }
            else
            {
                MessageBox.Show(errorDesc, "Database call failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string checkNull(string value)
        {
            if (string.IsNullOrEmpty(value))
                value = string.Empty;

            return value;
        }
    }
}