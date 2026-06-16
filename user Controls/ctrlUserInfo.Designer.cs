namespace DVLD.user_Controls
{
    partial class ctrlUserInfo
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDResult = new System.Windows.Forms.Label();
            this.lblUserNameResult = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIsActiveResult = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(67, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(73, 23);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID :";
            // 
            // lblUserIDResult
            // 
            this.lblUserIDResult.AutoSize = true;
            this.lblUserIDResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserIDResult.Location = new System.Drawing.Point(146, 33);
            this.lblUserIDResult.Name = "lblUserIDResult";
            this.lblUserIDResult.Size = new System.Drawing.Size(60, 23);
            this.lblUserIDResult.TabIndex = 2;
            this.lblUserIDResult.Text = "?????";
            // 
            // lblUserNameResult
            // 
            this.lblUserNameResult.AutoSize = true;
            this.lblUserNameResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserNameResult.Location = new System.Drawing.Point(353, 33);
            this.lblUserNameResult.Name = "lblUserNameResult";
            this.lblUserNameResult.Size = new System.Drawing.Size(60, 23);
            this.lblUserNameResult.TabIndex = 4;
            this.lblUserNameResult.Text = "?????";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(246, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 23);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name :";
            // 
            // lblIsActiveResult
            // 
            this.lblIsActiveResult.AutoSize = true;
            this.lblIsActiveResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIsActiveResult.Location = new System.Drawing.Point(642, 33);
            this.lblIsActiveResult.Name = "lblIsActiveResult";
            this.lblIsActiveResult.Size = new System.Drawing.Size(60, 23);
            this.lblIsActiveResult.TabIndex = 6;
            this.lblIsActiveResult.Text = "?????";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.Location = new System.Drawing.Point(553, 33);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(83, 23);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "is Active :";
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIsActiveResult);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lblUserNameResult);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserIDResult);
            this.Controls.Add(this.lblUserID);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(822, 75);
            this.Load += new System.EventHandler(this.ctrlUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDResult;
        private System.Windows.Forms.Label lblUserNameResult;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsActiveResult;
        private System.Windows.Forms.Label lblIsActive;
    }
}
