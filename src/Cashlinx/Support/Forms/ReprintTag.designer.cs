﻿using Common.Libraries.Forms.Components;

namespace Support.Forms
{
    partial class ReprintTag
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
            this.txtICN = new System.Windows.Forms.TextBox();
            this.customLabel4 = new CustomLabel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtICN
            // 
            this.txtICN.Location = new System.Drawing.Point(156, 62);
            this.txtICN.Name = "txtICN";
            this.txtICN.Size = new System.Drawing.Size(227, 21);
            this.txtICN.TabIndex = 157;
            this.txtICN.TextChanged += new System.EventHandler(this.txtICN_TextChanged);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.BackColor = System.Drawing.Color.Transparent;
            this.customLabel4.Location = new System.Drawing.Point(47, 65);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(104, 13);
            this.customLabel4.TabIndex = 156;
            this.customLabel4.Text = "Enter or Scan ICN #";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.AutoSize = true;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::Common.Properties.Resources.blueglossy_small;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(12, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 155;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.AutoSize = true;
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.BackgroundImage = global::Common.Properties.Resources.blueglossy_small;
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(325, 130);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(100, 40);
            this.continueButton.TabIndex = 154;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(143, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(153, 19);
            this.titleLabel.TabIndex = 153;
            this.titleLabel.Text = "Barcode Tag Reprint";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReprintTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Common.Properties.Resources.newDialog_320_BlueScale;
            this.ClientSize = new System.Drawing.Size(430, 182);
            this.Controls.Add(this.txtICN);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ReprintTag";
            this.Text = "ReprintTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtICN;
        private CustomLabel customLabel4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label titleLabel;
    }
}