namespace DVLD.Forms.Applictaion_Types
{
    partial class frmManageApplicationTypes
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
            this.label2 = new System.Windows.Forms.Label();
            this.grdvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecordsResult = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdvApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(246, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Application Types";
            // 
            // grdvApplicationTypes
            // 
            this.grdvApplicationTypes.AllowUserToAddRows = false;
            this.grdvApplicationTypes.AllowUserToDeleteRows = false;
            this.grdvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvApplicationTypes.Location = new System.Drawing.Point(12, 78);
            this.grdvApplicationTypes.Name = "grdvApplicationTypes";
            this.grdvApplicationTypes.ShowEditingIcon = false;
            this.grdvApplicationTypes.Size = new System.Drawing.Size(840, 360);
            this.grdvApplicationTypes.TabIndex = 2;
            this.grdvApplicationTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvApplicationTypes_CellContentClick);
            this.grdvApplicationTypes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdvApplicationTypes_CellMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(686, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 465);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 25);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "Records :";
            // 
            // lblRecordsResult
            // 
            this.lblRecordsResult.AutoSize = true;
            this.lblRecordsResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsResult.Location = new System.Drawing.Point(103, 465);
            this.lblRecordsResult.Name = "lblRecordsResult";
            this.lblRecordsResult.Size = new System.Drawing.Size(67, 25);
            this.lblRecordsResult.TabIndex = 5;
            this.lblRecordsResult.Text = "?????";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationType});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // tsmEditApplicationType
            // 
            this.tsmEditApplicationType.Name = "tsmEditApplicationType";
            this.tsmEditApplicationType.Size = new System.Drawing.Size(186, 22);
            this.tsmEditApplicationType.Text = "Edit Application Type";
            this.tsmEditApplicationType.Click += new System.EventHandler(this.tsmEditApplicationType_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.lblRecordsResult);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdvApplicationTypes);
            this.Controls.Add(this.label2);
            this.Name = "frmManageApplicationTypes";
            this.Text = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdvApplicationTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecordsResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationType;
    }
}