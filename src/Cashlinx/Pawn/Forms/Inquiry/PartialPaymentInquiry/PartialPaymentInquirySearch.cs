﻿using Common.Libraries.Forms.Components;
using Common.Controllers.Application;
using System;
using System.Data;
using System.Windows.Forms;
using Common.Controllers.Application.ApplicationFlow.Navigation;
using Common.Libraries.Utility.Exception;
using Common.Libraries.Utility.Shared;
//EDW DSTR TEst
//using Common.Controllers.Security;
//using Common.Libraries.Objects.Authorization;
//using Pawn.Forms.Pawn.ShopAdministration;
namespace Pawn.Forms.Inquiry.PartialPaymentInquiry
{
    public partial class PartialPaymentInquirySearch : Form
    {
        public NavBox NavControlBox;

        public PartialPaymentInquirySearch()
        {
            InitializeComponent();

            NavControlBox = new NavBox();
            NavControlBox.Owner = this;

            dateCalendarStart.PositionPopupCalendarOverTextbox = true;
            dateCalendarEnd.PositionPopupCalendarOverTextbox = true;
            dateCalendarStart.SelectedDate = "mm/dd/yyyy";
            dateCalendarEnd.SelectedDate = "mm/dd/yyyy";

            txtDOB.Required = false;

            sortBy_cb.DataSource = StringDBMap_Enum<PartialPaymentInquiry.sortField_enum>.displayValues();
            sortBy_cb.SelectedIndex = 0;

            sortDir_cb.SelectedIndex = 0;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
//EDW - DSTR Test
//            var confRef = SecurityAccessor.Instance.EncryptConfig;
//            var clientConfigDB = confRef.GetOracleDBService();
//
//            //Print end of day reports
//            var credentials = new Credentials
//            {
//                UserName = confRef.DecryptValue(clientConfigDB.DbUser),
//                PassWord = confRef.DecryptValue(clientConfigDB.DbUserPwd),
//                DBHost = confRef.DecryptValue(clientConfigDB.Server),
//                DBPort = confRef.DecryptValue(clientConfigDB.Port),
//                DBService = confRef.DecryptValue(clientConfigDB.AuxInfo),
//                DBSchema = confRef.DecryptValue(clientConfigDB.Schema)
//            };
//            var o = new BalanceCash();
//            o.ExecuteDSTR(credentials, GlobalDataAccessor.Instance.CurrentSiteId.StoreNumber, true);

            clear_fields();
        }

        private void clear_fields()
        {
            dateCalendarStart.SelectedDate = "mm/dd/yyyy";
            dateCalendarEnd.SelectedDate = "mm/dd/yyyy";
            txtDOB.DateTextBox.ResetText();
            txtDOB.DateTextBox.Text = "mm/dd/yyyy";

            fromAmount_tb.Text = string.Empty;
            toAmount_tb.Text = string.Empty;

            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;

            txtCustomerNumber.Text = string.Empty;
            txtLoanTicketNumber.Text = string.Empty;

            sortBy_cb.SelectedIndex = 0;

            sortDir_cb.SelectedIndex = 0;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            #region Dates
            string dateStartString = dateCalendarStart.SelectedDate;
            string dateEndString = dateCalendarEnd.SelectedDate;

            if (dateCalendarStart.SelectedDate == "mm/dd/yyyy")
            {
                dateStartString = string.Empty;
            }
            if (dateCalendarEnd.SelectedDate == "mm/dd/yyyy")
            {                
                dateEndString = string.Empty;
            }

            DateTime dtStart = DateTime.MaxValue;
            DateTime dtEnd = DateTime.MinValue;
            DateTime.TryParse(dateStartString, out dtStart);
            DateTime.TryParse(dateStartString, out dtEnd);
            if (dtStart > dtEnd && dtEnd != DateTime.MinValue)
            {
                MessageBox.Show("'To:' date is greater than the 'From:' date. Please adjust the date.");
                return;
            }
            #endregion

            #region Amounts
            decimal amtFrom = -1;
            decimal amtTo = -1;

            if (fromAmount_tb.Text.Length != 0 && !decimal.TryParse(fromAmount_tb.Text, out amtFrom))
            {
                MessageBox.Show("'From' amount has an error. Please correct.");
                return;
            }

            if (toAmount_tb.Text.Length != 0 && !decimal.TryParse(toAmount_tb.Text, out amtTo))
            {
                MessageBox.Show("'To' amount has an error. Please correct.");
                return;
            }

            if (amtFrom > amtTo)
            {
                MessageBox.Show("'To:' amount is greater than the 'From:' amount. Please adjust the amounts.");
                return;
            }
            #endregion

            #region TicketNumber
            int loanTicketNumber = -1;

            if (this.txtLoanTicketNumber.Text.Length !=0 && !int.TryParse(this.txtLoanTicketNumber.Text, out loanTicketNumber))
            {
                MessageBox.Show("'Loan Ticket Number:' is not a valid number. Please correct.");
                return;
            }
            #endregion

            #region DOB
            string dob = string.Empty;
            DateTime dtDob = DateTime.MinValue;
            if (txtDOB.DateTextBox.Text == "mm/dd/yyyy" || txtDOB.DateTextBox.Text.Length == 0)
            {
                dob = string.Empty;
            }
            else if (DateTime.TryParse(txtDOB.DateTextBox.Text, out dtDob))
            {
                if (dtDob.Year > DateTime.Now.Year)
                {
                    dtDob = dtDob.AddYears(-100);
                }
                dob = dtDob.ToShortDateString();//.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("'Date of Birth' is not a valid date. Please correct.");
                return;
            }
            #endregion

            Cursor.Current = Cursors.WaitCursor;

            var partialPaymentInquiry = new PartialPaymentInquiry()
            {
                startDate = dateStartString,
                endDate = dateEndString,
                lowAmount = amtFrom,
                highAmount = amtTo,
                lastName = this.txtLastName.Text,
                firstName = this.txtFirstName.Text,
                dob = dob,
                customerNumber = this.txtCustomerNumber.Text,
                loanTicketNumber = loanTicketNumber,
                sortBy = (PartialPaymentInquiry.sortField_enum)sortBy_cb.SelectedIndex,
                sortDir = (Inquiry.sortDir_enum)sortDir_cb.SelectedIndex
            };

            DataSet dataSetReturned = null;
            try
            {
                dataSetReturned = partialPaymentInquiry.getData();

                if (dataSetReturned.IsNullOrEmpty())
                    throw new BusinessLogicException(ReportConstants.NODATA);
            }
            catch (BusinessLogicException blex)
            {
                MessageBox.Show(blex.Message);
                return;
            }

            Cursor.Current = Cursors.Default;

            this.Visible = false;
            
            const string tableName = "PARTIAL_PAYMENT_INQ";

            var resultsDisplay = new PartialPaymentSearchResults(dataSetReturned, partialPaymentInquiry, tableName);

            resultsDisplay.ShowDialog();
            
            if (resultsDisplay.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            if (!this.txtDOB.isValid && this.txtDOB.DateTextBox.Text != "mm/dd/yyyy")
            {
                MessageBox.Show("'Date of Birth' is not a valid date. Please correct.");
            }
        }
    }
}
