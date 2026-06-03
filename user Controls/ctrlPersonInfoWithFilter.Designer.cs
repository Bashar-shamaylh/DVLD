namespace DVLD.user_Controls
{
    partial class ctrlPersonInfoWithFilter
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
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.ctrlFindPersonFilter1 = new DVLD.user_Controls.ctrlFindPersonFilter();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(13, 107);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(806, 347);
            this.ctrlPersonInfo1.TabIndex = 0;
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // ctrlFindPersonFilter1
            // 
            this.ctrlFindPersonFilter1.Location = new System.Drawing.Point(24, 24);
            this.ctrlFindPersonFilter1.Name = "ctrlFindPersonFilter1";
            this.ctrlFindPersonFilter1.Size = new System.Drawing.Size(777, 77);
            this.ctrlFindPersonFilter1.TabIndex = 1;
            // 
            // ctrlPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlFindPersonFilter1);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "ctrlPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(839, 516);
            this.Load += new System.EventHandler(this.ctrlPersonInfoWithFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlFindPersonFilter ctrlFindPersonFilter1;
    }
}
