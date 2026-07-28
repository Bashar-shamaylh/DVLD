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
        string imagePath = "";
        //public AddEditPersonInfoUI(int id = -1)
        //{
        //    InitializeComponent();


        //    //since i got the id from the manage people form the id must be in the database so no need to check if find return a null or not
        //    if (id != -1)
        //    {
        //        person = clsPerson.Find(id); //Update Mode

        //        if (person == null)
        //        {
        //            person = new clsPerson();
        //        }
        //    }
        //    else
        //        person = new clsPerson();    //Add new mode

        //}
        public AddEditPersonInfoUI(int id)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = id;
        }
        public AddEditPersonInfoUI()
        {
            InitializeComponent();
            _Person = new clsPerson();    //Add new mode
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
            //Prevent the user to enter a Date Less than 18 years
            if(_Mode==enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
            }
            else
            {
                lblTitle.Text = "Update";
            }
            if (rdoMale.Checked)
            {
                PersonalImage.Image = Resources.Male_512;
            }
            else
                PersonalImage.Image = Resources.Female_512;


            linkRemove.Visible = (PersonalImage.ImageLocation != null);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-120);
            
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
            lblNationalNumResult.Text = _Person.NationnalNumber;

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
            if(!string.IsNullOrEmpty(_Person.PersonalImage))
            {
                PersonalImage.ImageLocation = _Person.PersonalImage;
                
            }
            linkRemove.Visible = (!string.IsNullOrEmpty(_Person.PersonalImage));
            
        }
        private void _LoadCountriesIntoTheForm() //Get  all the Countries from the database and Set Jordan to defult
        {
            cmbCountries.DataSource = clsCountry.GetCountriesInfo();
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue = 183;   //jordan id
        }
        
        private void _SetImage(string ImagePath="")
        {
            if (_Person.PersonalImage == null && imagePath == "")
            {
                if (rdoMale.Checked)
                {
                    PersonalImage.Image = Properties.Resources.Male_512;
                }
                else
                {
                    PersonalImage.Image = Properties.Resources.Female_512;
                }
            }
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
        }
       

        private void AddEditPersonInfoUI_Load(object sender, EventArgs e)
        {
            _PrepareTheFormComponents();
            if (_Mode == enMode.Update)
                _FillPersonInfoIntoTheForm();//LoadData();
            this.ValidateChildren();
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                linkRemove.Visible = true;
                PersonalImage.Image = Image.FromFile(imagePath);
            }
           


        }
        private void _Save()
        {
            if (!this.ValidateChildren()) 
                return;
            if (!_HandlePersonImage())
                return;
            _Person.FirstName = txtBoxFirstName.Text;
            _Person.SecondName = txtBoxSecondName.Text;
            _Person.ThirdName = txtBoxThirdName.Text;
            _Person.LastName = txtBoxLastName.Text;
            _Person.NationnalNumber = txtBoxNationalNum.Text;
            _Person.Address = txtBoxAddress.Text;
            _Person.Email = txtBoxEmail.Text;
            _Person.Phone = txtBoxPhone.Text;
            _Person.Nationality = Convert.ToInt32(cmbCountries.SelectedValue);
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rdoMale.Checked)
            {
                _Person.Gender = (short) enGender.Male;
            }
            else
            {
                _Person.Gender = (short)enGender.Female;
            }

            if (PersonalImage.Location !=null)
            {
                _Person.ImagePath=PersonalImage.Location.ToString();
            }
            if(_Person.Save())
            {
                _Mode = enMode.Update;
                lblPersonIDResult.Text = _Person.ID.ToString();
                lblPersonIDResult.Visible = true;
                lblNationalNumResult.Text = _Person.NationnalNumber.ToString();
                lblNationalNumResult.Visible = true;
                lblTitle.Text = "Update Mode";
                DataBack?.Invoke(this,_Person.ID);
            }
           
        }    //Collect the info from the input Controls into Person object and call person.Save at the end
        private void btnSave_Click(object sender, EventArgs e)
        {
           
             if(string.IsNullOrEmpty(txtBoxFirstName.Text) ||
                string.IsNullOrEmpty(txtBoxSecondName.Text)||
                string.IsNullOrEmpty(txtBoxThirdName.Text) || 
                string.IsNullOrEmpty(txtBoxLastName.Text)  ||
                string.IsNullOrEmpty(txtBoxNationalNum.Text))
            {
                MessageBox.Show("Full Name And National Number Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    _Save();
                    MessageBox.Show("Data Saved Successfuly");
                }
                catch (Exception)
                {

                    MessageBox.Show("Unexpected Error Has Occored", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                
            }
            
        }

       
      

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            imagePath = "";
            _SetImage();
            if (person.PersonalImage != null)
            {
                string path = Path.Combine(Application.StartupPath, "DVLDImages");
                if (File.Exists(path))
                {
                    File.Delete(Path.Combine(path,person.PersonalImage));
                    person.PersonalImage = null;
                }

            }
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

            if (txtBoxNationalNum.Text.Trim() != _Person.NationnalNumber && clsPerson.isPersonExist(txtBoxNationalNum.Text.Trim())
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
            if(string.IsNullOrEmpty(temp.Text.Trim()) 
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
            if (PersonalImage.Location == null)
            {
                PersonalImage.Image=Resources.Male_512;
            }
        }

        private void rdoFemale_Click(object sender, EventArgs e)
        {
            if (PersonalImage.Location == null)
            {
                PersonalImage.Image = Resources.Female_512;
            }
        }
    }
}
