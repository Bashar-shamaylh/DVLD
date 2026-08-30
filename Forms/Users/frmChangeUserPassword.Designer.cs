namespace DVLD.Forms.Users
{
    partial class frmChangeUserPassword
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
            this.ctrlUserInfo1 = new DVLD.user_Controls.ctrlUserInfo();
            this.txtboxCurrentPassowrd = new System.Windows.Forms.TextBox();
            this.txtboxNewPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserInfo2 = new DVLD.user_Controls.ctrlUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(12, 363);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(779, 75);
            this.ctrlUserInfo1.TabIndex = 1;
            // 
            // txtboxCurrentPassowrd
            // 
            this.txtboxCurrentPassowrd.Location = new System.Drawing.Point(223, 541);
            this.txtboxCurrentPassowrd.Name = "txtboxCurrentPassowrd";
            this.txtboxCurrentPassowrd.Size = new System.Drawing.Size(223, 20);
            this.txtboxCurrentPassowrd.TabIndex = 2;
            this.txtboxCurrentPassowrd.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxCurrentPassowrd_Validating);
            // 
            // txtboxNewPassword
            // 
            this.txtboxNewPassword.Location = new System.Drawing.Point(223, 586);
            this.txtboxNewPassword.Name = "txtboxNewPassword";
            this.txtboxNewPassword.Size = new System.Drawing.Size(223, 20);
            this.txtboxNewPassword.TabIndex = 3;
           
            this.txtboxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxNewPassword_Validating);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPassword.Location = new System.Drawing.Point(42, 541);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(155, 23);
            this.lblCurrentPassword.TabIndex = 4;
            this.lblCurrentPassword.Text = "Current Password :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.Location = new System.Drawing.Point(42, 581);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(130, 23);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password :";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(39, 623);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 23);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtboxConfirmPassword
            // 
            this.txtboxConfirmPassword.Location = new System.Drawing.Point(223, 628);
            this.txtboxConfirmPassword.Name = "txtboxConfirmPassword";
            this.txtboxConfirmPassword.Size = new System.Drawing.Size(223, 20);
            this.txtboxConfirmPassword.TabIndex = 7;

            this.txtboxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxConfirmPassword_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(546, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 643);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserInfo2
            // 
            this.ctrlUserInfo2.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfo2.Name = "ctrlUserInfo2";
            this.ctrlUserInfo2.Size = new System.Drawing.Size(836, 522);
            this.ctrlUserInfo2.TabIndex = 10;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 691);
            this.Controls.Add(this.ctrlUserInfo2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtboxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtboxNewPassword);
            this.Controls.Add(this.txtboxCurrentPassowrd);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "frmChangeUserPassword";
            this.Text = "frmChangeUserPassword";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private user_Controls.ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.TextBox txtboxCurrentPassowrd;
        private System.Windows.Forms.TextBox txtboxNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtboxConfirmPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private user_Controls.ctrlUserInfo ctrlUserInfo2;
    }
}