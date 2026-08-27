namespace DVLD.Forms.Users
{
    partial class frmAddNewUser
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonInfoWithFilter1 = new DVLD.user_Controls.ctrlPersonInfoWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbpLoginInfo = new System.Windows.Forms.TabPage();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserIDResult = new System.Windows.Forms.Label();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.chkisActive = new System.Windows.Forms.CheckBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpPersonalInfo.SuspendLayout();
            this.tbpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPersonalInfo);
            this.tabControl1.Controls.Add(this.tbpLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(-1, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpPersonalInfo
            // 
            this.tbpPersonalInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tbpPersonalInfo.Controls.Add(this.btnNext);
            this.tbpPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpPersonalInfo.Name = "tbpPersonalInfo";
            this.tbpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonalInfo.Size = new System.Drawing.Size(819, 463);
            this.tbpPersonalInfo.TabIndex = 0;
            this.tbpPersonalInfo.Text = "Personal Info";
            this.tbpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.FilterEnabeld = true;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 6);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.ShowPerson = true;
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(810, 428);
            this.ctrlPersonInfoWithFilter1.TabIndex = 4;
            this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(694, 434);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbpLoginInfo
            // 
            this.tbpLoginInfo.Controls.Add(this.lblConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.txtboxConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.lblPassword);
            this.tbpLoginInfo.Controls.Add(this.txtboxPassword);
            this.tbpLoginInfo.Controls.Add(this.lblUserName);
            this.tbpLoginInfo.Controls.Add(this.lblUserIDResult);
            this.tbpLoginInfo.Controls.Add(this.txtboxUserName);
            this.tbpLoginInfo.Controls.Add(this.chkisActive);
            this.tbpLoginInfo.Controls.Add(this.lblUserID);
            this.tbpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpLoginInfo.Name = "tbpLoginInfo";
            this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginInfo.Size = new System.Drawing.Size(819, 463);
            this.tbpLoginInfo.TabIndex = 1;
            this.tbpLoginInfo.Text = "Login Info";
            this.tbpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(52, 222);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 23);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtboxConfirmPassword
            // 
            this.txtboxConfirmPassword.Location = new System.Drawing.Point(225, 227);
            this.txtboxConfirmPassword.Name = "txtboxConfirmPassword";
            this.txtboxConfirmPassword.Size = new System.Drawing.Size(169, 20);
            this.txtboxConfirmPassword.TabIndex = 7;
            
            this.txtboxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxConfirmPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(52, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password :";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(225, 186);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(169, 20);
            this.txtboxPassword.TabIndex = 5;
         
            this.txtboxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxPassword_Validating);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(52, 134);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name :";
            // 
            // lblUserIDResult
            // 
            this.lblUserIDResult.AutoSize = true;
            this.lblUserIDResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserIDResult.Location = new System.Drawing.Point(221, 83);
            this.lblUserIDResult.Name = "lblUserIDResult";
            this.lblUserIDResult.Size = new System.Drawing.Size(50, 23);
            this.lblUserIDResult.TabIndex = 3;
            this.lblUserIDResult.Text = "????";
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Location = new System.Drawing.Point(225, 139);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(169, 20);
            this.txtboxUserName.TabIndex = 2;
         
            this.txtboxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxUserName_Validating);
            // 
            // chkisActive
            // 
            this.chkisActive.AutoSize = true;
            this.chkisActive.Location = new System.Drawing.Point(225, 271);
            this.chkisActive.Name = "chkisActive";
            this.chkisActive.Size = new System.Drawing.Size(67, 17);
            this.chkisActive.TabIndex = 1;
            this.chkisActive.Text = "Is Active";
            this.chkisActive.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(52, 83);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(73, 23);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(546, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(637, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(267, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 43);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add New ";
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 662);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.tabControl1.ResumeLayout(false);
            this.tbpPersonalInfo.ResumeLayout(false);
            this.tbpLoginInfo.ResumeLayout(false);
            this.tbpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPersonalInfo;
        private System.Windows.Forms.TabPage tbpLoginInfo;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.CheckBox chkisActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDResult;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtboxConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNext;
        private user_Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Label lblTitle;
    }
}