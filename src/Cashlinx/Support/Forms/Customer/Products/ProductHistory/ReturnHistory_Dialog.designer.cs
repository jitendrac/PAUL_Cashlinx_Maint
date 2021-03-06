﻿namespace Support.Forms.Customer.Products.ProductHistory
{
    partial class ReturnHistory_Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH_LoanStatsLayoutPanel = new System.Windows.Forms.Panel();
            this.PH_ReturnAmountLabel = new System.Windows.Forms.Label();
            this.PH_ReturnAmountText = new System.Windows.Forms.Label();
            this.PH_TerminalIDLabel = new System.Windows.Forms.Label();
            this.PH_TerminalIDValue = new System.Windows.Forms.Label();
            this.PH_MadeByEmpLabel = new System.Windows.Forms.Label();
            this.PH_MadeByEmpValue = new System.Windows.Forms.Label();
            this.PH_ReturnReasonLabel = new System.Windows.Forms.Label();
            this.PH_ReturnReasonValue = new System.Windows.Forms.Label();
            this.PH_OrigPurchaseNumberLabel = new System.Windows.Forms.Label();
            this.PH_OrigPurchaseNumberValue = new System.Windows.Forms.Label();
            this.PH_OriginationDateLabel = new System.Windows.Forms.Label();
            this.PH_OriginationDateValue = new System.Windows.Forms.Label();
            this.PH_ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.PH_CloseButton = new System.Windows.Forms.Button();
            this.PH_ItemNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH_StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH_LoanAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH_LoanStatsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PH_ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IH_History_StatusDateColumn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IH_History_ItemStatusColumn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Status";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IH_History_ItemDescriptionColumn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PH_LoanStatsLayoutPanel
            // 
            this.PH_LoanStatsLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PH_LoanStatsLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_ReturnAmountLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_ReturnAmountText);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_TerminalIDLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_TerminalIDValue);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_MadeByEmpLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_MadeByEmpValue);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_ReturnReasonLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_ReturnReasonValue);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_OrigPurchaseNumberLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_OrigPurchaseNumberValue);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_OriginationDateLabel);
            this.PH_LoanStatsLayoutPanel.Controls.Add(this.PH_OriginationDateValue);
            this.PH_LoanStatsLayoutPanel.Location = new System.Drawing.Point(11, 68);
            this.PH_LoanStatsLayoutPanel.Name = "PH_LoanStatsLayoutPanel";
            this.PH_LoanStatsLayoutPanel.Size = new System.Drawing.Size(776, 126);
            this.PH_LoanStatsLayoutPanel.TabIndex = 142;
            // 
            // PH_ReturnAmountLabel
            // 
            this.PH_ReturnAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_ReturnAmountLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_ReturnAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_ReturnAmountLabel.Location = new System.Drawing.Point(290, 16);
            this.PH_ReturnAmountLabel.Name = "PH_ReturnAmountLabel";
            this.PH_ReturnAmountLabel.Size = new System.Drawing.Size(108, 13);
            this.PH_ReturnAmountLabel.TabIndex = 189;
            this.PH_ReturnAmountLabel.Text = "Return Amount:";
            this.PH_ReturnAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_ReturnAmountText
            // 
            this.PH_ReturnAmountText.BackColor = System.Drawing.Color.Transparent;
            this.PH_ReturnAmountText.ForeColor = System.Drawing.Color.Black;
            this.PH_ReturnAmountText.Location = new System.Drawing.Point(404, 16);
            this.PH_ReturnAmountText.Name = "PH_ReturnAmountText";
            this.PH_ReturnAmountText.Size = new System.Drawing.Size(79, 13);
            this.PH_ReturnAmountText.TabIndex = 190;
            this.PH_ReturnAmountText.Text = "$160.00";
            this.PH_ReturnAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PH_TerminalIDLabel
            // 
            this.PH_TerminalIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_TerminalIDLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_TerminalIDLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_TerminalIDLabel.Location = new System.Drawing.Point(497, 16);
            this.PH_TerminalIDLabel.Name = "PH_TerminalIDLabel";
            this.PH_TerminalIDLabel.Size = new System.Drawing.Size(160, 13);
            this.PH_TerminalIDLabel.TabIndex = 167;
            this.PH_TerminalIDLabel.Text = "Terminal ID / Shop:";
            this.PH_TerminalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_TerminalIDValue
            // 
            this.PH_TerminalIDValue.BackColor = System.Drawing.Color.Transparent;
            this.PH_TerminalIDValue.ForeColor = System.Drawing.Color.Black;
            this.PH_TerminalIDValue.Location = new System.Drawing.Point(663, 16);
            this.PH_TerminalIDValue.Name = "PH_TerminalIDValue";
            this.PH_TerminalIDValue.Size = new System.Drawing.Size(70, 13);
            this.PH_TerminalIDValue.TabIndex = 168;
            this.PH_TerminalIDValue.Text = "36 1234";
            this.PH_TerminalIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PH_MadeByEmpLabel
            // 
            this.PH_MadeByEmpLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_MadeByEmpLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_MadeByEmpLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_MadeByEmpLabel.Location = new System.Drawing.Point(285, 42);
            this.PH_MadeByEmpLabel.Name = "PH_MadeByEmpLabel";
            this.PH_MadeByEmpLabel.Size = new System.Drawing.Size(113, 13);
            this.PH_MadeByEmpLabel.TabIndex = 165;
            this.PH_MadeByEmpLabel.Text = "Employee Number:";
            this.PH_MadeByEmpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_MadeByEmpValue
            // 
            this.PH_MadeByEmpValue.BackColor = System.Drawing.Color.Transparent;
            this.PH_MadeByEmpValue.ForeColor = System.Drawing.Color.Black;
            this.PH_MadeByEmpValue.Location = new System.Drawing.Point(404, 42);
            this.PH_MadeByEmpValue.Name = "PH_MadeByEmpValue";
            this.PH_MadeByEmpValue.Size = new System.Drawing.Size(79, 13);
            this.PH_MadeByEmpValue.TabIndex = 166;
            this.PH_MadeByEmpValue.Text = "1234";
            this.PH_MadeByEmpValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PH_ReturnReasonLabel
            // 
            this.PH_ReturnReasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_ReturnReasonLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_ReturnReasonLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_ReturnReasonLabel.Location = new System.Drawing.Point(4, 68);
            this.PH_ReturnReasonLabel.Name = "PH_ReturnReasonLabel";
            this.PH_ReturnReasonLabel.Size = new System.Drawing.Size(145, 13);
            this.PH_ReturnReasonLabel.TabIndex = 153;
            this.PH_ReturnReasonLabel.Text = "Return Reason:";
            this.PH_ReturnReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_ReturnReasonValue
            // 
            this.PH_ReturnReasonValue.BackColor = System.Drawing.Color.Transparent;
            this.PH_ReturnReasonValue.ForeColor = System.Drawing.Color.Black;
            this.PH_ReturnReasonValue.Location = new System.Drawing.Point(153, 68);
            this.PH_ReturnReasonValue.Name = "PH_ReturnReasonValue";
            this.PH_ReturnReasonValue.Size = new System.Drawing.Size(330, 40);
            this.PH_ReturnReasonValue.TabIndex = 154;
            this.PH_ReturnReasonValue.Text = "Reason";
            // 
            // PH_OrigPurchaseNumberLabel
            // 
            this.PH_OrigPurchaseNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_OrigPurchaseNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_OrigPurchaseNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_OrigPurchaseNumberLabel.Location = new System.Drawing.Point(19, 42);
            this.PH_OrigPurchaseNumberLabel.Name = "PH_OrigPurchaseNumberLabel";
            this.PH_OrigPurchaseNumberLabel.Size = new System.Drawing.Size(130, 13);
            this.PH_OrigPurchaseNumberLabel.TabIndex = 149;
            this.PH_OrigPurchaseNumberLabel.Text = "Original Purchase #:";
            this.PH_OrigPurchaseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_OrigPurchaseNumberValue
            // 
            this.PH_OrigPurchaseNumberValue.BackColor = System.Drawing.Color.Transparent;
            this.PH_OrigPurchaseNumberValue.ForeColor = System.Drawing.Color.Black;
            this.PH_OrigPurchaseNumberValue.Location = new System.Drawing.Point(153, 42);
            this.PH_OrigPurchaseNumberValue.Name = "PH_OrigPurchaseNumberValue";
            this.PH_OrigPurchaseNumberValue.Size = new System.Drawing.Size(83, 13);
            this.PH_OrigPurchaseNumberValue.TabIndex = 150;
            this.PH_OrigPurchaseNumberValue.Text = "23423";
            this.PH_OrigPurchaseNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PH_OriginationDateLabel
            // 
            this.PH_OriginationDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.PH_OriginationDateLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_OriginationDateLabel.ForeColor = System.Drawing.Color.Black;
            this.PH_OriginationDateLabel.Location = new System.Drawing.Point(7, 16);
            this.PH_OriginationDateLabel.Name = "PH_OriginationDateLabel";
            this.PH_OriginationDateLabel.Size = new System.Drawing.Size(142, 13);
            this.PH_OriginationDateLabel.TabIndex = 118;
            this.PH_OriginationDateLabel.Text = "Origination Date/Time:";
            this.PH_OriginationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PH_OriginationDateValue
            // 
            this.PH_OriginationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.PH_OriginationDateValue.ForeColor = System.Drawing.Color.Black;
            this.PH_OriginationDateValue.Location = new System.Drawing.Point(153, 16);
            this.PH_OriginationDateValue.Name = "PH_OriginationDateValue";
            this.PH_OriginationDateValue.Size = new System.Drawing.Size(83, 13);
            this.PH_OriginationDateValue.TabIndex = 121;
            this.PH_OriginationDateValue.Text = "09/20/2008";
            this.PH_OriginationDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PH_ItemsDataGridView
            // 
            this.PH_ItemsDataGridView.AllowUserToAddRows = false;
            this.PH_ItemsDataGridView.AllowUserToDeleteRows = false;
            this.PH_ItemsDataGridView.AllowUserToResizeColumns = false;
            this.PH_ItemsDataGridView.AllowUserToResizeRows = false;
            this.PH_ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PH_ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PH_ItemsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PH_ItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PH_ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PH_ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PH_ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PH_ItemNumberColumn,
            this.PH_DescriptionColumn,
            this.PH_StatusColumn,
            this.PH_LoanAmountColumn});
            this.PH_ItemsDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PH_ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PH_ItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PH_ItemsDataGridView.GridColor = System.Drawing.Color.LightGray;
            this.PH_ItemsDataGridView.Location = new System.Drawing.Point(11, 200);
            this.PH_ItemsDataGridView.MultiSelect = false;
            this.PH_ItemsDataGridView.Name = "PH_ItemsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PH_ItemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PH_ItemsDataGridView.RowHeadersVisible = false;
            this.PH_ItemsDataGridView.RowHeadersWidth = 20;
            this.PH_ItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PH_ItemsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PH_ItemsDataGridView.RowTemplate.Height = 25;
            this.PH_ItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PH_ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PH_ItemsDataGridView.Size = new System.Drawing.Size(776, 226);
            this.PH_ItemsDataGridView.TabIndex = 154;
            // 
            // PH_CloseButton
            // 
            this.PH_CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PH_CloseButton.AutoSize = true;
            this.PH_CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.PH_CloseButton.BackgroundImage = global::Common.Properties.Resources.blueglossy_small;
            this.PH_CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PH_CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PH_CloseButton.FlatAppearance.BorderSize = 0;
            this.PH_CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PH_CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PH_CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PH_CloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PH_CloseButton.ForeColor = System.Drawing.Color.White;
            this.PH_CloseButton.Location = new System.Drawing.Point(351, 435);
            this.PH_CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.PH_CloseButton.MaximumSize = new System.Drawing.Size(100, 50);
            this.PH_CloseButton.MinimumSize = new System.Drawing.Size(100, 50);
            this.PH_CloseButton.Name = "PH_CloseButton";
            this.PH_CloseButton.Size = new System.Drawing.Size(100, 50);
            this.PH_CloseButton.TabIndex = 156;
            this.PH_CloseButton.Text = "Close";
            this.PH_CloseButton.UseVisualStyleBackColor = false;
            this.PH_CloseButton.Click += new System.EventHandler(this.PH_CloseButton_Click);
            // 
            // PH_ItemNumberColumn
            // 
            this.PH_ItemNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PH_ItemNumberColumn.DataPropertyName = "PH_ItemNumberColumn";
            this.PH_ItemNumberColumn.HeaderText = "Item Number";
            this.PH_ItemNumberColumn.Name = "PH_ItemNumberColumn";
            this.PH_ItemNumberColumn.ReadOnly = true;
            this.PH_ItemNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PH_DescriptionColumn
            // 
            this.PH_DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PH_DescriptionColumn.DataPropertyName = "PH_DescriptionColumn";
            this.PH_DescriptionColumn.HeaderText = "Description";
            this.PH_DescriptionColumn.Name = "PH_DescriptionColumn";
            this.PH_DescriptionColumn.ReadOnly = true;
            // 
            // PH_StatusColumn
            // 
            this.PH_StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PH_StatusColumn.DataPropertyName = "PH_StatusColumn";
            this.PH_StatusColumn.HeaderText = "Status";
            this.PH_StatusColumn.Name = "PH_StatusColumn";
            this.PH_StatusColumn.ReadOnly = true;
            // 
            // PH_LoanAmountColumn
            // 
            this.PH_LoanAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PH_LoanAmountColumn.DataPropertyName = "PH_LoanAmountColumn";
            this.PH_LoanAmountColumn.HeaderText = "Return Amount";
            this.PH_LoanAmountColumn.Name = "PH_LoanAmountColumn";
            this.PH_LoanAmountColumn.ReadOnly = true;
            // 
            // ReturnHistory_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::Common.Properties.Resources.newDialog_512_BlueScale;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 498);
            this.ControlBox = false;
            this.Controls.Add(this.PH_CloseButton);
            this.Controls.Add(this.PH_ItemsDataGridView);
            this.Controls.Add(this.PH_LoanStatsLayoutPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnHistory_Dialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy";
            this.PH_LoanStatsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PH_ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel PH_LoanStatsLayoutPanel;
        private System.Windows.Forms.Label PH_OriginationDateLabel;
        private System.Windows.Forms.Label PH_OriginationDateValue;
        private System.Windows.Forms.Label PH_OrigPurchaseNumberLabel;
        private System.Windows.Forms.Label PH_OrigPurchaseNumberValue;
        private System.Windows.Forms.Label PH_ReturnReasonLabel;
        private System.Windows.Forms.Label PH_ReturnReasonValue;
        private System.Windows.Forms.Label PH_MadeByEmpLabel;
        private System.Windows.Forms.Label PH_MadeByEmpValue;
        private System.Windows.Forms.Label PH_TerminalIDLabel;
        private System.Windows.Forms.Label PH_TerminalIDValue;
        private System.Windows.Forms.DataGridView PH_ItemsDataGridView;
        private System.Windows.Forms.Button PH_CloseButton;
        private System.Windows.Forms.Label PH_ReturnAmountLabel;
        private System.Windows.Forms.Label PH_ReturnAmountText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH_ItemNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH_DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH_StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH_LoanAmountColumn;
    }
}