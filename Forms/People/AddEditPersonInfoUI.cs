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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Forms
{
    public partial class AddEditPersonInfoUI : Form
    {
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
                person = clsPerson.Find(id); //Update Mode

                if (person == null)
                {
                    person = new clsPerson();
                }

        }
        public AddEditPersonInfoUI()
        {
            InitializeComponent();
                person = new clsPerson();    //Add new mode
        }

        clsPerson person;
        string imagePath = "";
        private bool _IsNationalNumExist(string nationalNum)
        {
            //Function to Check if the  National Number does exist in the database or not
            return clsPerson.isNationalNumberExist(nationalNum);
            
        }
        private void _PrepareTheFormComponents()
        {
            //Prevent the user to enter a Date Less than 18 years
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            //Load all the Countries
            _LoadCountriesIntoTheForm();
            rdoMale.Checked = true;
            if (person.Mode == clsPerson.enMode.UpdateMode)
            {
                lblTitle.Text = "Update Person";
                _FillPersonInfoIntoTheForm();  //fill all the Controls with Person info(Update Mode)
            }
        }
        private void _FillPersonInfoIntoTheForm()     //fill all the Controls with Person info(Update Mode)
        {
            lblPersonIDResult.Text = person.ID.ToString();
            lblNationalNumResult.Text = person.NationnalNumber;

            txtBoxFirstName.Text = person.FirstName;
            txtBoxSecondName.Text = person.SecondName;
            txtBoxThirdName.Text = person.ThirdName;
            txtBoxLastName.Text = person.LastName;
            txtBoxNationalNum.Text = person.NationnalNumber;

            dtpDateOfBirth.Value = person.DateOfBirth;

            if (person.Gender == 'M' || person.Gender == 'm')
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            if (person.Phone != null)

                txtBoxPhone.Text = person.Phone;

            if (person.Email != null)
                txtBoxEmail.Text = person.Email;
            if (person.Address != null)
                txtBoxAddress.Text = person.Address;
            int index = person.Nationality;

            // 3. If found, make it the default selection
            if (index != -1)
            {
                cmbCountries.SelectedIndex = index;
            }
            if (person.Address != null)
                txtBoxAddress.Text = person.Address;
            if(person.PersonalImage != null)
            {
                string path = Path.Combine(Application.StartupPath, "DVLDImages");

                path = Path.Combine(path, person.PersonalImage);
                if (File.Exists(path))
                {

                    PersonalImage.Image = Image.FromFile(path);
                }
                
            }
            
        }
        private void _LoadCountriesIntoTheForm() //Get  all the Countries from the database and Set Jordan to defult
        {
            cmbCountries.DataSource = clsCountry.GetCountriesInfo();
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedIndex = 183;   //jordan id
        }
        
        private void _SetImage(string ImagePath="")
        {
            if (person.PersonalImage == null && imagePath == "")
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
        private void _EmailFilter()
        {
            if (!string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                if (!Regex.IsMatch(txtBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    errorProvider1.SetError(txtBoxEmail, "This isn't a valid email");
                }
                else
                    errorProvider1.SetError(txtBoxEmail, "");
            }
        }
       

        private void AddEditPersonInfoUI_Load(object sender, EventArgs e)
        {
            _PrepareTheFormComponents();
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

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            _SetImage();

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            _SetImage();
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            _EmailFilter();
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
           
            person.FirstName = txtBoxFirstName.Text;
            person.SecondName = txtBoxSecondName.Text;
            person.ThirdName = txtBoxThirdName.Text;
            person.LastName = txtBoxLastName.Text;
            person.NationnalNumber = txtBoxNationalNum.Text;
            person.Address = txtBoxAddress.Text;
            person.Email = txtBoxEmail.Text;
            person.Phone = txtBoxPhone.Text;
            person.Nationality = Convert.ToInt32(cmbCountries.SelectedIndex);
            person.DateOfBirth = dtpDateOfBirth.Value;
            if (rdoMale.Checked)
            {
                person.Gender = 'M';
            }
            else
            {
                person.Gender = 'F';
            }

            if (imagePath != "")
            {
                string path = Path.Combine(Application.StartupPath, "DVLDImages");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string newName = Guid.NewGuid().ToString() + Path.GetExtension(imagePath);
                person.PersonalImage = newName;
                if (person.Mode == clsPerson.enMode.UpdateMode)
                {
                    string destPath = Path.Combine(path, newName);
                    File.Copy(imagePath, destPath, true);
                }


            }
            person.Save();
            lblPersonIDResult.Text = person.ID.ToString();
            lblPersonIDResult.Visible = true;
            lblNationalNumResult.Text = person.NationnalNumber.ToString();
            lblNationalNumResult.Visible = true;
            lblTitle.Text = "Update Mode";
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

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
         
                errorProvider1.SetError(txtBoxFirstName, "");
        }

        private void txtBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxSecondName, "");
        }

        private void txtBoxThirdName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxThirdName, "");
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxLastName, "");
        }

        private void txtBoxNationalNum_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtBoxNationalNum, "");
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

        private void txtBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxFirstName.Text))
            {
                errorProvider1.SetError(txtBoxFirstName, "Plese enter a valid first name");
            }
        }

        private void txtBoxSecondName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxSecondName.Text))
            {
                errorProvider1.SetError(txtBoxSecondName, "Plese enter a valid second name");
            }
        }

        private void txtBoxThirdName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxThirdName.Text))
            {
                errorProvider1.SetError(txtBoxThirdName, "Plese enter a valid Third name");
            }
        }

        private void txtBoxLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLastName.Text))
            {
                errorProvider1.SetError(txtBoxLastName, "Plese enter a valid Last name");
            }
        }

        private void txtBoxNationalNum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNationalNum.Text))
            {
                errorProvider1.SetError(txtBoxLastName, "Plese enter a valid Last name");
            }
        }
    }
}
