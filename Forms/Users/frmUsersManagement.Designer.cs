namespace DVLD.Forms.Users
{
    partial class frmUsersManagement
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbxFitlerItems = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumberOfRecordsResult = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.grdvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbxIsActiveOptions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(686, 26);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(99, 60);
            this.btnAddNewUser.TabIndex = 18;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmbxFitlerItems
            // 
            this.cmbxFitlerItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFitlerItems.FormattingEnabled = true;
            this.cmbxFitlerItems.Location = new System.Drawing.Point(117, 65);
            this.cmbxFitlerItems.Name = "cmbxFitlerItems";
            this.cmbxFitlerItems.Size = new System.Drawing.Size(132, 21);
            this.cmbxFitlerItems.TabIndex = 16;
            this.cmbxFitlerItems.SelectedIndexChanged += new System.EventHandler(this.cmbxFitlerItems_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.Location = new System.Drawing.Point(30, 63);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 23);
            this.lblFilterBy.TabIndex = 15;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(648, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 40);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberOfRecordsResult
            // 
            this.lblNumberOfRecordsResult.AutoSize = true;
            this.lblNumberOfRecordsResult.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRecordsResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecordsResult.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecordsResult.Location = new System.Drawing.Point(94, 471);
            this.lblNumberOfRecordsResult.Name = "lblNumberOfRecordsResult";
            this.lblNumberOfRecordsResult.Size = new System.Drawing.Size(0, 23);
            this.lblNumberOfRecordsResult.TabIndex = 13;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(30, 461);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(83, 23);
            this.lblNumberOfRecords.TabIndex = 12;
            this.lblNumberOfRecords.Text = "Records :";
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsers.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.Red;
            this.lblManageUsers.Location = new System.Drawing.Point(302, 10);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(226, 43);
            this.lblManageUsers.TabIndex = 11;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // grdvUsers
            // 
            this.grdvUsers.AllowUserToAddRows = false;
            this.grdvUsers.AllowUserToDeleteRows = false;
            this.grdvUsers.AllowUserToResizeColumns = false;
            this.grdvUsers.AllowUserToResizeRows = false;
            this.grdvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvUsers.Location = new System.Drawing.Point(34, 89);
            this.grdvUsers.Name = "grdvUsers";
            this.grdvUsers.ReadOnly = true;
            this.grdvUsers.Size = new System.Drawing.Size(751, 355);
            this.grdvUsers.StandardTab = true;
            this.grdvUsers.TabIndex = 10;
            this.grdvUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdvUsers_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddUser,
            this.tsmUpdateUserInfo,
            this.tsmViewDetails,
            this.tsmDeleteUser,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 136);
            // 
            // tsmAddUser
            // 
            this.tsmAddUser.Name = "tsmAddUser";
            this.tsmAddUser.Size = new System.Drawing.Size(138, 22);
            this.tsmAddUser.Text = "Add User";
            this.tsmAddUser.Click += new System.EventHandler(this.tsmAddUser_Click);
            // 
            // tsmUpdateUserInfo
            // 
            this.tsmUpdateUserInfo.Name = "tsmUpdateUserInfo";
            this.tsmUpdateUserInfo.Size = new System.Drawing.Size(138, 22);
            this.tsmUpdateUserInfo.Text = "Update User";
            this.tsmUpdateUserInfo.Click += new System.EventHandler(this.tsmUpdateUserInfo_Click);
            // 
            // tsmViewDetails
            // 
            this.tsmViewDetails.Name = "tsmViewDetails";
            this.tsmViewDetails.Size = new System.Drawing.Size(138, 22);
            this.tsmViewDetails.Text = "view info";
            this.tsmViewDetails.Click += new System.EventHandler(this.tsmViewDetails_Click);
            // 
            // tsmDeleteUser
            // 
            this.tsmDeleteUser.Name = "tsmDeleteUser";
            this.tsmDeleteUser.Size = new System.Drawing.Size(138, 22);
            this.tsmDeleteUser.Text = "Delete";
            this.tsmDeleteUser.Click += new System.EventHandler(this.tsmDeleteUser_Click);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(138, 22);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(138, 22);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // cmbxIsActiveOptions
            // 
            this.cmbxIsActiveOptions.FormattingEnabled = true;
            this.cmbxIsActiveOptions.Location = new System.Drawing.Point(255, 65);
            this.cmbxIsActiveOptions.Name = "cmbxIsActiveOptions";
            this.cmbxIsActiveOptions.Size = new System.Drawing.Size(80, 21);
            this.cmbxIsActiveOptions.TabIndex = 20;
            this.cmbxIsActiveOptions.Visible = false;
            this.cmbxIsActiveOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.cmbxIsActiveOptions);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbxFitlerItems);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecordsResult);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.grdvUsers);
            this.Name = "frmUsersManagement";
            this.Text = "frmUsersManagement";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbxFitlerItems;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumberOfRecordsResult;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.DataGridView grdvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmViewDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
        private System.Windows.Forms.ComboBox cmbxIsActiveOptions;
    }
}