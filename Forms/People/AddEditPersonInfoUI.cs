using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD.Properties;
using System.Runtime.CompilerServices;

namespace DVLD.Forms
{
    public partial class AddEditPersonInfoUI : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew=0,Update=1}
        public enum enGender { Male = 0, Female = 1 }
        private enMode _Mode;
        private int _PersonID = -1;
        
        clsPerson _Person;
      
        public AddEditPersonInfoUI(int id)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = id;
        }
        public AddEditPersonInfoUI()
        {
            InitializeComponent();
            
            _Mode = enMode.AddNew;
        }

        
        private bool _IsNationalNumExist(string nationalNum)
        {
            //Function to Check if the  National Number does exist in the database or not
            return clsPerson.isNationalNumberExist(nationalNum);
            
        }
        private void _PrepareTheFormComponents()// ResetDefultValues();
        {
            //Load all the Countries
            _LoadCountriesIntoTheForm();
            if(_Mode==enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person=new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update";
            }
            rdoMale.Checked = true;
            if (rdoMale.Checked)
            {
                PersonalImage.Image = Resources.Male_512;
            }
            else
                PersonalImage.Image = Resources.Female_512;


            linkRemove.Visible = (PersonalImage.ImageLocation != null);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-120);
            txtBoxFirstName.Text = "";
            txtBoxSecondName.Text = "";
            txtBoxThirdName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxNationalNum.Text = "";
            rdoMale.Checked = true;
            txtBoxPhone.Text = "";
            txtBoxAddress.Text = "";
            txtBoxEmail.Text = "";
            
        }
        private void _FillPersonInfoIntoTheForm()   // _LoadData //fill all the Controls with Person info(Update Mode)
        {
            _Person = clsPerson.Find(_PersonID);
            if(_Person==null)
            {
                MessageBox.Show("No Person With ID = " + _PersonID, "Person Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblPersonIDResult.Text = _Person.ID.ToString();
            lblNationalNumResult.Text = _Person.NationnalNumber.ToString();

            txtBoxFirstName.Text = _Person.FirstName;
            txtBoxSecondName.Text = _Person.SecondName;
            txtBoxThirdName.Text = _Person.ThirdName;
            txtBoxLastName.Text = _Person.LastName;
            txtBoxNationalNum.Text = _Person.NationnalNumber;

            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            if (_Person.Phone != null)

                txtBoxPhone.Text = _Person.Phone;

            if (_Person.Email != null)
                txtBoxEmail.Text = _Person.Email;
            if (_Person.Address != null)
                txtBoxAddress.Text = _Person.Address;
            cmbCountries.SelectedValue = _Person.Nationality;

           
            if (_Person.Address != null)
                txtBoxAddress.Text = _Person.Address;
            if(_Person.PersonalImage!="")
            {
                PersonalImage.ImageLocation = _Person.PersonalImage;
                
            }
            linkRemove.Visible = (_Person.PersonalImage != "");
            
        }
        private void _LoadCountriesIntoTheForm() //Get  all the Countries from the database and Set Jordan to defult
        {
            cmbCountries.DataSource = clsCountry.GetCountriesInfo();
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue = 90;   //jordan id
        }
        
       
        private bool _EmailFilter(string txt)
        {
            if (!string.IsNullOrWhiteSpace(txt))
            {
                if (!Regex.IsMatch(txt, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    return false;
                }
                else
                    return true;
            }
            return false;
        }
       

        private void AddEditPersonInfoUI_Load(object sender, EventArgs e)
        {
            _PrepareTheFormComponents();
            if (_Mode == enMode.Update)
                _FillPersonInfoIntoTheForm();//LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNationalNum_MouseLeave(object sender, EventArgs e)
        {
                //Check if the National Number exist if The check box isn't empty             --Update this later in Case Update Person Info
                if (_IsNationalNumExist(txtBoxNationalNum.Text)&& txtBoxNationalNum.Text.Length > 0) 
                    errorProvider1.SetError(txtBoxNationalNum, "This Number is already used");
                
        }

   
     

        private void linklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter =
                                    "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|" +
                                    "All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedImagePath = openFileDialog1.FileName;
                linkRemove.Visible = true;
                PersonalImage.Load ( SelectedImagePath);
            }
           


        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            if (!_HandlePersonImage())
                return;
            _Person.FirstName = txtBoxFirstName.Text.Trim();
            _Person.SecondName = txtBoxSecondName.Text.Trim();
            _Person.ThirdName = txtBoxThirdName.Text.Trim();
            _Person.LastName = txtBoxLastName.Text.Trim();
            _Person.NationnalNumber = txtBoxNationalNum.Text.Trim();
            _Person.Address = txtBoxAddress.Text.Trim();
            _Person.Email = txtBoxEmail.Text.Trim();
            _Person.Phone = txtBoxPhone.Text.Trim();
            _Person.Nationality = Convert.ToInt32(cmbCountries.SelectedValue);
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rdoMale.Checked)
            {
                _Person.Gender = (short)enGender.Male;
            }
            else
            {
                _Person.Gender = (short)enGender.Female;
            }

            if (PersonalImage.ImageLocation != null)
            {
                _Person.ImagePath=_Person.PersonalImage = PersonalImage.ImageLocation.ToString();
            }
            if (_Person.Save())
            {
                _Mode = enMode.Update;
                lblPersonIDResult.Text = _Person.ID.ToString();
                lblPersonIDResult.Visible = true;
                lblNationalNumResult.Text = _Person.NationnalNumber.ToString();
                lblNationalNumResult.Visible = true;
                lblTitle.Text = "Update Mode";
                DataBack?.Invoke(this, _Person.ID);
            }
            else
                MessageBox.Show("Unexpected Error Has Occored", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

           

        }

       
      

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonalImage.ImageLocation = null;
            if (rdoMale.Checked)
            {
                PersonalImage.Image = Resources.Male_512;

            }
            else
                PersonalImage.Image = Resources.Female_512;
            linkRemove.Visible= false; 
        }
        private bool _HandlePersonImage()
        {
             if(_Person.ImagePath!=PersonalImage.ImageLocation)
            {
                if(_Person.ImagePath != ""&&_Person.ImagePath!=null)
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);   //delete the old image in case that the image was changed
                    }
                    catch (IOException)
                    {

                        throw;
                    }
                }
                if(PersonalImage.ImageLocation!=null)
                {
                    string SourceImageFile=PersonalImage.ImageLocation.ToString(); 
                        if(clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        PersonalImage.ImageLocation=SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error,Adding Image was faild","Error",MessageBoxButtons.OK, MessageBoxIcon.Error)  
                            ;return false;  
                    }
                }
            }
            return true;
        }
        private void txtBoxNationalNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNationalNum.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxNationalNum, "this feild is requierd");
            }
            else
                errorProvider1.SetError(txtBoxNationalNum, null);

            if (txtBoxNationalNum.Text.Trim() != _Person.NationnalNumber && clsPerson.isPersonExist(txtBoxNationalNum.Text.Trim()))
                {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxNationalNum, "this National Number is already used by another person");

            }
            else
                errorProvider1.SetError(txtBoxNationalNum, null);


            
        }

        

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxEmail.Text.Trim() == "")
                return;
            if(!_EmailFilter(txtBoxEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBoxEmail, "this isn't a valid email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBoxEmail, null);
            }    
        }

     

     
        private void ValidateEmptyTextBox(object sender,CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if(string.IsNullOrEmpty(temp.Text.Trim())) 
                {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this feild is required");
                }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void rdoMale_Click(object sender, EventArgs e)
        {
            if (PersonalImage.ImageLocation == null)
            {
                PersonalImage.Image=Resources.Male_512;
            }
        }

        private void rdoFemale_Click(object sender, EventArgs e)
        {
            if (PersonalImage.ImageLocation == null)
            {
                PersonalImage.Image = Resources.Female_512;
            }
        }
    }
}
