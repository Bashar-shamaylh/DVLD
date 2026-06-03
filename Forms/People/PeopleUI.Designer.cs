namespace DVLD.Forms
{
    partial class PeopleUI
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
            this.grdvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdatePersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblNumberOfRecordsResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbxFitlerItems = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdvPeople
            // 
            this.grdvPeople.AllowUserToAddRows = false;
            this.grdvPeople.AllowUserToDeleteRows = false;
            this.grdvPeople.AllowUserToResizeColumns = false;
            this.grdvPeople.AllowUserToResizeRows = false;
            this.grdvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvPeople.Location = new System.Drawing.Point(5, 146);
            this.grdvPeople.Name = "grdvPeople";
            this.grdvPeople.ReadOnly = true;
            this.grdvPeople.Size = new System.Drawing.Size(1100, 380);
            this.grdvPeople.StandardTab = true;
            this.grdvPeople.TabIndex = 0;
            this.grdvPeople.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdvPeople_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddPerson,
            this.tsmUpdatePersonInfo,
            this.tsmViewDetails,
            this.tsmDeletePerson,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 136);
            // 
            // tsmAddPerson
            // 
            this.tsmAddPerson.Name = "tsmAddPerson";
            this.tsmAddPerson.Size = new System.Drawing.Size(151, 22);
            this.tsmAddPerson.Text = "Add Person";
            this.tsmAddPerson.Click += new System.EventHandler(this.tsmAddPerson_Click);
            // 
            // tsmUpdatePersonInfo
            // 
            this.tsmUpdatePersonInfo.Name = "tsmUpdatePersonInfo";
            this.tsmUpdatePersonInfo.Size = new System.Drawing.Size(151, 22);
            this.tsmUpdatePersonInfo.Text = "Update Person";
            this.tsmUpdatePersonInfo.Click += new System.EventHandler(this.tsmUpdatePersonInfo_Click);
            // 
            // tsmViewDetails
            // 
            this.tsmViewDetails.Name = "tsmViewDetails";
            this.tsmViewDetails.Size = new System.Drawing.Size(151, 22);
            this.tsmViewDetails.Text = "view info";
            this.tsmViewDetails.Click += new System.EventHandler(this.tsmViewDetails_Click);
            // 
            // tsmDeletePerson
            // 
            this.tsmDeletePerson.Name = "tsmDeletePerson";
            this.tsmDeletePerson.Size = new System.Drawing.Size(151, 22);
            this.tsmDeletePerson.Text = "Delete";
            this.tsmDeletePerson.Click += new System.EventHandler(this.tsmDeletePerson_Click);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(151, 22);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(151, 22);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.lblManagePeople.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lblManagePeople.Location = new System.Drawing.Point(335, 44);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(241, 43);
            this.lblManagePeople.TabIndex = 1;
            this.lblManagePeople.Text = "Manage People";
            this.lblManagePeople.Click += new System.EventHandler(this.lblManagePeople_Click);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(1, 541);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(83, 23);
            this.lblNumberOfRecords.TabIndex = 2;
            this.lblNumberOfRecords.Text = "Records :";
            // 
            // lblNumberOfRecordsResult
            // 
            this.lblNumberOfRecordsResult.AutoSize = true;
            this.lblNumberOfRecordsResult.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRecordsResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecordsResult.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecordsResult.Location = new System.Drawing.Point(90, 541);
            this.lblNumberOfRecordsResult.Name = "lblNumberOfRecordsResult";
            this.lblNumberOfRecordsResult.Size = new System.Drawing.Size(0, 23);
            this.lblNumberOfRecordsResult.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(968, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.Location = new System.Drawing.Point(3, 120);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 23);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // cmbxFitlerItems
            // 
            this.cmbxFitlerItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFitlerItems.FormattingEnabled = true;
            this.cmbxFitlerItems.Location = new System.Drawing.Point(90, 122);
            this.cmbxFitlerItems.Name = "cmbxFitlerItems";
            this.cmbxFitlerItems.Size = new System.Drawing.Size(132, 21);
            this.cmbxFitlerItems.TabIndex = 7;
            this.cmbxFitlerItems.SelectedIndexChanged += new System.EventHandler(this.cmbxFitlerItems_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(1006, 69);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(99, 71);
            this.btnAddNewPerson.TabIndex = 9;
            this.btnAddNewPerson.Text = "Add Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // PeopleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 587);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbxFitlerItems);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecordsResult);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.grdvPeople);
            this.Name = "PeopleUI";
            this.Text = "Manege People";
            this.Load += new System.EventHandler(this.PeopleUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvPeople;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblNumberOfRecordsResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbxFitlerItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdatePersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmViewDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmDeletePerson;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
    }
}