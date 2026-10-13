namespace DVLD.Forms.TestAppointments
{
    partial class frmAddEditTestAppointment
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
            this.grpTestTitle = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblClassType = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblApplicationid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.grpTestTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTestTitle
            // 
            this.grpTestTitle.Controls.Add(this.dtpAppointmentDate);
            this.grpTestTitle.Controls.Add(this.btnSave);
            this.grpTestTitle.Controls.Add(this.lblApplicationFees);
            this.grpTestTitle.Controls.Add(this.label2);
            this.grpTestTitle.Controls.Add(this.lblTrial);
            this.grpTestTitle.Controls.Add(this.lblClassType);
            this.grpTestTitle.Controls.Add(this.lblApplicantName);
            this.grpTestTitle.Controls.Add(this.lblApplicationid);
            this.grpTestTitle.Controls.Add(this.label6);
            this.grpTestTitle.Controls.Add(this.label7);
            this.grpTestTitle.Controls.Add(this.label5);
            this.grpTestTitle.Controls.Add(this.label3);
            this.grpTestTitle.Controls.Add(this.lbl1);
            this.grpTestTitle.Controls.Add(this.lblManagePeople);
            this.grpTestTitle.Controls.Add(this.groupBox1);
            this.grpTestTitle.Location = new System.Drawing.Point(11, 12);
            this.grpTestTitle.Name = "grpTestTitle";
            this.grpTestTitle.Size = new System.Drawing.Size(624, 608);
            this.grpTestTitle.TabIndex = 0;
            this.grpTestTitle.TabStop = false;
            this.grpTestTitle.Text = "Vision Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(18, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retake Test Info";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.lblManagePeople.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lblManagePeople.Location = new System.Drawing.Point(156, 25);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(226, 43);
            this.lblManagePeople.TabIndex = 3;
            this.lblManagePeople.Text = "Schedule Test";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTrial.Location = new System.Drawing.Point(259, 250);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(60, 23);
            this.lblTrial.TabIndex = 38;
            this.lblTrial.Text = "?????";
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClassType.Location = new System.Drawing.Point(259, 162);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(60, 23);
            this.lblClassType.TabIndex = 37;
            this.lblClassType.Text = "?????";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApplicantName.Location = new System.Drawing.Point(259, 209);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(60, 23);
            this.lblApplicantName.TabIndex = 36;
            this.lblApplicantName.Text = "?????";
            // 
            // lblApplicationid
            // 
            this.lblApplicationid.AutoSize = true;
            this.lblApplicationid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApplicationid.Location = new System.Drawing.Point(259, 124);
            this.lblApplicationid.Name = "lblApplicationid";
            this.lblApplicationid.Size = new System.Drawing.Size(60, 23);
            this.lblApplicationid.TabIndex = 35;
            this.lblApplicationid.Text = "?????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(184, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(181, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Trial :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(157, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "D.Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(171, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(84, 124);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 23);
            this.lbl1.TabIndex = 30;
            this.lbl1.Text = "D.L.ApplicationID :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.Location = new System.Drawing.Point(259, 335);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(60, 23);
            this.lblApplicationFees.TabIndex = 41;
            this.lblApplicationFees.Text = "?????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(181, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(155, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "?????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "R.Test.AppID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(155, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "?????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(47, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 42;
            this.label10.Text = "R.App.Fees:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(409, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 47;
            this.label11.Text = "?????";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(309, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 46;
            this.label12.Text = "Total Fees:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 48);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(263, 297);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(182, 20);
            this.dtpAppointmentDate.TabIndex = 43;
            // 
            // frmAddEditTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 686);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpTestTitle);
            this.Name = "frmAddEditTestAppointment";
            this.Text = "frmAddEditTestAppointment";
            this.grpTestTitle.ResumeLayout(false);
            this.grpTestTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTestTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblApplicationid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
    }
}