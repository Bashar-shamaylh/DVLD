namespace DVLD.user_Controls
{
    partial class ctrlFindPersonFilter
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
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbxFitlerItems = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Location = new System.Drawing.Point(376, 15);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(75, 48);
            this.btnFindPerson.TabIndex = 2;
            this.btnFindPerson.Text = "Find";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(457, 15);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(75, 48);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.Text = "Add new";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmbxFitlerItems
            // 
            this.cmbxFitlerItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFitlerItems.FormattingEnabled = true;
            this.cmbxFitlerItems.Location = new System.Drawing.Point(90, 27);
            this.cmbxFitlerItems.Name = "cmbxFitlerItems";
            this.cmbxFitlerItems.Size = new System.Drawing.Size(132, 21);
            this.cmbxFitlerItems.TabIndex = 10;
            this.cmbxFitlerItems.SelectedIndexChanged += new System.EventHandler(this.cmbxFitlerItems_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.Location = new System.Drawing.Point(3, 25);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 23);
            this.lblFilterBy.TabIndex = 9;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // ctrlFindPersonFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbxFitlerItems);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.btnFindPerson);
            this.Name = "ctrlFindPersonFilter";
            this.Size = new System.Drawing.Size(550, 77);
            this.Load += new System.EventHandler(this.ctrlFindPersonFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbxFitlerItems;
        private System.Windows.Forms.Label lblFilterBy;
    }
}
