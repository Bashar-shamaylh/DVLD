namespace DVLD.Forms.TestAppointments
{
    partial class frmTestAppointments
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
            this.ctrlLocalDrivingLicenseFullInfo1 = new DVLD.user_Controls.ctrlLocalDrivingLicenseFullInfo();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseFullInfo1
            // 
            this.ctrlLocalDrivingLicenseFullInfo1.Location = new System.Drawing.Point(28, 71);
            this.ctrlLocalDrivingLicenseFullInfo1.Name = "ctrlLocalDrivingLicenseFullInfo1";
            this.ctrlLocalDrivingLicenseFullInfo1.Size = new System.Drawing.Size(825, 404);
            this.ctrlLocalDrivingLicenseFullInfo1.TabIndex = 0;
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.lblManagePeople.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lblManagePeople.Location = new System.Drawing.Point(311, 25);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(296, 43);
            this.lblManagePeople.TabIndex = 2;
            this.lblManagePeople.Text = "Test Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 545);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Appointment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 771);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 774);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "#Records :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Appointments :";
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 819);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.ctrlLocalDrivingLicenseFullInfo1);
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private user_Controls.ctrlLocalDrivingLicenseFullInfo ctrlLocalDrivingLicenseFullInfo1;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}