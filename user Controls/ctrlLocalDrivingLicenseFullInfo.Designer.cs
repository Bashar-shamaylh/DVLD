namespace DVLD.user_Controls
{
    partial class ctrlLocalDrivingLicenseFullInfo
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
            this.ctrlApplicationInfo1 = new DVLD.user_Controls.ctrlApplicationInfo();
            this.ctrlLocalDrivingLicenseApplicationInfo1 = new DVLD.user_Controls.ctrlLocalDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(17, 182);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(719, 229);
            this.ctrlApplicationInfo1.TabIndex = 1;
            // 
            // ctrlLocalDrivingLicenseApplicationInfo1
            // 
            this.ctrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(3, 20);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Name = "ctrlLocalDrivingLicenseApplicationInfo1";
            this.ctrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(752, 175);
            this.ctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 2;
            // 
            // ctrlLocalDrivingLicenseFullInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Name = "ctrlLocalDrivingLicenseFullInfo";
            this.Size = new System.Drawing.Size(834, 447);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlApplicationInfo ctrlApplicationInfo1;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlLocalDrivingLicenseApplicationInfo1;
    }
}
