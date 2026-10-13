namespace DVLD.user_Controls
{
    partial class ctrlLocalDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLicenseClassName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lblPassedTests);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLicenseClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLocalDrivingLicenseApplicationID);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 122);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(4, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 23);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "L.D.L.Application ID :";
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            this.lblLocalDrivingLicenseApplicationID.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLocalDrivingLicenseApplicationID.Location = new System.Drawing.Point(177, 14);
            this.lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            this.lblLocalDrivingLicenseApplicationID.Size = new System.Drawing.Size(60, 23);
            this.lblLocalDrivingLicenseApplicationID.TabIndex = 14;
            this.lblLocalDrivingLicenseApplicationID.Text = "?????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(279, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Applied For License :";
            // 
            // lblLicenseClassName
            // 
            this.lblLicenseClassName.AutoSize = true;
            this.lblLicenseClassName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClassName.Location = new System.Drawing.Point(456, 14);
            this.lblLicenseClassName.Name = "lblLicenseClassName";
            this.lblLicenseClassName.Size = new System.Drawing.Size(60, 23);
            this.lblLicenseClassName.TabIndex = 16;
            this.lblLicenseClassName.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(279, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Passed Tests :";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPassedTests.Location = new System.Drawing.Point(423, 65);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(60, 23);
            this.lblPassedTests.TabIndex = 18;
            this.lblPassedTests.Text = "?????";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(56, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 23);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show License Info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ctrlLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlLocalDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(752, 175);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLicenseClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label lbl1;
    }
}
