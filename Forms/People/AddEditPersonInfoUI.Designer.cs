namespace DVLD.Forms
{
    partial class AddEditPersonInfoUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBoxPerson = new System.Windows.Forms.GroupBox();
            this.linkRemove = new System.Windows.Forms.LinkLabel();
            this.linklblSetImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PersonalImage = new System.Windows.Forms.PictureBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtBoxNationalNum = new System.Windows.Forms.TextBox();
            this.lblNationalNum = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxThirdName = new System.Windows.Forms.TextBox();
            this.txtBoxSecondName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPersonIDResult = new System.Windows.Forms.Label();
            this.lblNationalNumResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbBoxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(156, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "N/A :";
            // 
            // grbBoxPerson
            // 
            this.grbBoxPerson.Controls.Add(this.linkRemove);
            this.grbBoxPerson.Controls.Add(this.linklblSetImage);
            this.grbBoxPerson.Controls.Add(this.btnSave);
            this.grbBoxPerson.Controls.Add(this.btnClose);
            this.grbBoxPerson.Controls.Add(this.PersonalImage);
            this.grbBoxPerson.Controls.Add(this.txtBoxAddress);
            this.grbBoxPerson.Controls.Add(this.lblAddress);
            this.grbBoxPerson.Controls.Add(this.cmbCountries);
            this.grbBoxPerson.Controls.Add(this.dtpDateOfBirth);
            this.grbBoxPerson.Controls.Add(this.txtBoxPhone);
            this.grbBoxPerson.Controls.Add(this.lblCountry);
            this.grbBoxPerson.Controls.Add(this.lblPhone);
            this.grbBoxPerson.Controls.Add(this.lblDateOfBirth);
            this.grbBoxPerson.Controls.Add(this.rdoFemale);
            this.grbBoxPerson.Controls.Add(this.rdoMale);
            this.grbBoxPerson.Controls.Add(this.lblEmail);
            this.grbBoxPerson.Controls.Add(this.txtBoxEmail);
            this.grbBoxPerson.Controls.Add(this.lblGender);
            this.grbBoxPerson.Controls.Add(this.txtBoxNationalNum);
            this.grbBoxPerson.Controls.Add(this.lblNationalNum);
            this.grbBoxPerson.Controls.Add(this.lblLastName);
            this.grbBoxPerson.Controls.Add(this.lblThirdName);
            this.grbBoxPerson.Controls.Add(this.lblSecondName);
            this.grbBoxPerson.Controls.Add(this.lblFirstName);
            this.grbBoxPerson.Controls.Add(this.txtBoxLastName);
            this.grbBoxPerson.Controls.Add(this.txtBoxThirdName);
            this.grbBoxPerson.Controls.Add(this.txtBoxSecondName);
            this.grbBoxPerson.Controls.Add(this.txtBoxFirstName);
            this.grbBoxPerson.Controls.Add(this.label3);
            this.grbBoxPerson.Location = new System.Drawing.Point(16, 102);
            this.grbBoxPerson.Name = "grbBoxPerson";
            this.grbBoxPerson.Size = new System.Drawing.Size(931, 373);
            this.grbBoxPerson.TabIndex = 2;
            this.grbBoxPerson.TabStop = false;
            // 
            // linkRemove
            // 
            this.linkRemove.AutoSize = true;
            this.linkRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRemove.Location = new System.Drawing.Point(770, 326);
            this.linkRemove.Name = "linkRemove";
            this.linkRemove.Size = new System.Drawing.Size(86, 24);
            this.linkRemove.TabIndex = 55;
            this.linkRemove.TabStop = true;
            this.linkRemove.Text = "Remove ";
            this.linkRemove.Visible = false;
            this.linkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove_LinkClicked);
            // 
            // linklblSetImage
            // 
            this.linklblSetImage.AutoSize = true;
            this.linklblSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSetImage.Location = new System.Drawing.Point(770, 286);
            this.linklblSetImage.Name = "linklblSetImage";
            this.linklblSetImage.Size = new System.Drawing.Size(94, 24);
            this.linklblSetImage.TabIndex = 54;
            this.linklblSetImage.TabStop = true;
            this.linklblSetImage.Text = "Set Image";
            this.linklblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSetImage_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(445, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 31);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(272, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 31);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Colse";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PersonalImage
            // 
            this.PersonalImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.PersonalImage.Location = new System.Drawing.Point(738, 84);
            this.PersonalImage.Name = "PersonalImage";
            this.PersonalImage.Size = new System.Drawing.Size(161, 175);
            this.PersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonalImage.TabIndex = 51;
            this.PersonalImage.TabStop = false;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAddress.Location = new System.Drawing.Point(171, 215);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(537, 95);
            this.txtBoxAddress.TabIndex = 50;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(54, 215);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 23);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address :";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(547, 177);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(161, 21);
            this.cmbCountries.TabIndex = 48;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(547, 83);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(160, 20);
            this.dtpDateOfBirth.TabIndex = 47;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPhone.Location = new System.Drawing.Point(547, 129);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(161, 20);
            this.txtBoxPhone.TabIndex = 46;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCountry.Location = new System.Drawing.Point(404, 177);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 23);
            this.lblCountry.TabIndex = 45;
            this.lblCountry.Text = "Country :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(404, 126);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 23);
            this.lblPhone.TabIndex = 44;
            this.lblPhone.Text = "Phone :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.Location = new System.Drawing.Point(400, 84);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(114, 23);
            this.lblDateOfBirth.TabIndex = 43;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(252, 126);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 42;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(170, 126);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 41;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(54, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 23);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email :";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEmail.Location = new System.Drawing.Point(170, 177);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(161, 20);
            this.txtBoxEmail.TabIndex = 39;
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(54, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 23);
            this.lblGender.TabIndex = 38;
            this.lblGender.Text = "Gender :";
            // 
            // txtBoxNationalNum
            // 
            this.txtBoxNationalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNationalNum.Location = new System.Drawing.Point(170, 84);
            this.txtBoxNationalNum.Name = "txtBoxNationalNum";
            this.txtBoxNationalNum.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNationalNum.TabIndex = 37;
            this.txtBoxNationalNum.TextChanged += new System.EventHandler(this.txtBoxNationalNum_TextChanged);
            this.txtBoxNationalNum.Leave += new System.EventHandler(this.txtBoxNationalNum_Leave);
            this.txtBoxNationalNum.MouseLeave += new System.EventHandler(this.txtBoxNationalNum_MouseLeave);
            // 
            // lblNationalNum
            // 
            this.lblNationalNum.AutoSize = true;
            this.lblNationalNum.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNationalNum.Location = new System.Drawing.Point(54, 81);
            this.lblNationalNum.Name = "lblNationalNum";
            this.lblNationalNum.Size = new System.Drawing.Size(45, 23);
            this.lblNationalNum.TabIndex = 36;
            this.lblNationalNum.Text = "N/A :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(780, 12);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 22);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last";
            // 
            // lblThirdName
            // 
            this.lblThirdName.AutoSize = true;
            this.lblThirdName.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdName.Location = new System.Drawing.Point(590, 12);
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size(70, 22);
            this.lblThirdName.TabIndex = 34;
            this.lblThirdName.Text = "Third";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(385, 12);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(99, 22);
            this.lblSecondName.TabIndex = 33;
            this.lblSecondName.Text = "Second";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(212, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 22);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLastName.Location = new System.Drawing.Point(738, 42);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxLastName.TabIndex = 31;
            this.txtBoxLastName.TextChanged += new System.EventHandler(this.txtBoxLastName_TextChanged);
            this.txtBoxLastName.Leave += new System.EventHandler(this.txtBoxLastName_Leave);
            // 
            // txtBoxThirdName
            // 
            this.txtBoxThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxThirdName.Location = new System.Drawing.Point(547, 42);
            this.txtBoxThirdName.Name = "txtBoxThirdName";
            this.txtBoxThirdName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxThirdName.TabIndex = 30;
            this.txtBoxThirdName.TextChanged += new System.EventHandler(this.txtBoxThirdName_TextChanged);
            this.txtBoxThirdName.Leave += new System.EventHandler(this.txtBoxThirdName_Leave);
            // 
            // txtBoxSecondName
            // 
            this.txtBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecondName.Location = new System.Drawing.Point(353, 41);
            this.txtBoxSecondName.Name = "txtBoxSecondName";
            this.txtBoxSecondName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxSecondName.TabIndex = 29;
            this.txtBoxSecondName.TextChanged += new System.EventHandler(this.txtBoxSecondName_TextChanged);
            this.txtBoxSecondName.Leave += new System.EventHandler(this.txtBoxSecondName_Leave);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFirstName.Location = new System.Drawing.Point(170, 42);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxFirstName.TabIndex = 28;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            this.txtBoxFirstName.Leave += new System.EventHandler(this.txtBoxFirstName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPersonIDResult
            // 
            this.lblPersonIDResult.AutoSize = true;
            this.lblPersonIDResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDResult.Location = new System.Drawing.Point(102, 61);
            this.lblPersonIDResult.Name = "lblPersonIDResult";
            this.lblPersonIDResult.Size = new System.Drawing.Size(0, 20);
            this.lblPersonIDResult.TabIndex = 3;
            // 
            // lblNationalNumResult
            // 
            this.lblNationalNumResult.AutoSize = true;
            this.lblNationalNumResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNumResult.Location = new System.Drawing.Point(218, 61);
            this.lblNationalNumResult.Name = "lblNationalNumResult";
            this.lblNationalNumResult.Size = new System.Drawing.Size(0, 20);
            this.lblNationalNumResult.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(329, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 43);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Add New Person";
            // 
            // AddEditPersonInfoUI
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(989, 487);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNationalNumResult);
            this.Controls.Add(this.lblPersonIDResult);
            this.Controls.Add(this.grbBoxPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditPersonInfoUI";
            this.Text = "Add/Edit Person Info";
            this.Load += new System.EventHandler(this.AddEditPersonInfoUI_Load);
            this.grbBoxPerson.ResumeLayout(false);
            this.grbBoxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbBoxPerson;
        private System.Windows.Forms.PictureBox PersonalImage;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtBoxNationalNum;
        private System.Windows.Forms.Label lblNationalNum;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxThirdName;
        private System.Windows.Forms.TextBox txtBoxSecondName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklblSetImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNationalNumResult;
        private System.Windows.Forms.Label lblPersonIDResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkRemove;
        private System.Windows.Forms.Label lblTitle;
    }
}