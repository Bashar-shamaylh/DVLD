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
        clsPerson person;
        string imagePath = "";
        private bool _IsNationalNumExist(string nationalNum)
        {
            //Function to Check if the  National Number does exist in the database or not
            return clsPerson.isNationalNumberExist(nationalNum);
            
        }
        public AddEditPersonInfoUI(int id = -1)
        {
            InitializeComponent();
            person = clsPerson.Find(id);
            if (person == null)
            {
                person = new clsPerson();
            }

        }

        private void AddEditPersonInfoUI_Load(object sender, EventArgs e)
        {
            //Prevent the user to enter a Date Less than 18 years
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            //Load all the Countries
            cmbCountries.DataSource = clsCountry.GetCountriesInfo();
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedIndex = 183;
            rdoMale.Checked = true;
            if (person.Mode == clsPerson.enMode.UpdateMode)
            {
                lblPersonIDResult.Text = person.ID.ToString();
                lblNationalNumResult.Text = person.NationnalNumber;

                txtBoxFirstName.Text = person.FirstName;
                txtBoxSecondName.Text = person.SecondName;
                txtBoxThirdName.Text = person.ThirdName;
                txtBoxLastName.Text = person.LastName;
                txtBoxNationalNum.Text = person.NationnalNumber;

                dtpDateOfBirth.Value = person.DateOfBirth;

                if (person.Gender == 'M'||person.Gender=='m')
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
                int index = cmbCountries.FindStringExact(person.Nationality);

                // 3. If found, make it the default selection
                if (index != -1)
                {
                    cmbCountries.SelectedIndex = index;
                }
                if(person.Address != null)
                    txtBoxAddress.Text = person.Address;
                
            }



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
            if(person.PersonalImage==null)
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

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (person.PersonalImage == null)
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

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtBoxEmail.Text))
                {
                if (!Regex.IsMatch(txtBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    errorProvider1.SetError(txtBoxEmail, "This isn't a valid email");
                }
                else
                    errorProvider1.SetError(txtBoxEmail, "");
                }
            
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxFirstName.Text))
            {
                errorProvider1.SetError(txtBoxFirstName, "Plese enter a valid first name");
            }
            else if(string.IsNullOrEmpty(txtBoxSecondName.Text))
            {
                errorProvider1.SetError(txtBoxSecondName, "Plese enter a valid second name");
            }
            else if (string.IsNullOrEmpty(txtBoxThirdName.Text))
            {
                errorProvider1.SetError(txtBoxThirdName, "Plese enter a valid Third name");
            }
            else if (string.IsNullOrEmpty(txtBoxLastName.Text))
            {
                errorProvider1.SetError(txtBoxLastName, "Plese enter a valid Last name");
            }
            else if (string.IsNullOrEmpty(txtBoxNationalNum.Text))
            {
                errorProvider1.SetError(txtBoxNationalNum, "Plese enter a valid National number");
            }
            person.FirstName = txtBoxFirstName.Text;
            person.SecondName = txtBoxSecondName.Text;
            person.ThirdName = txtBoxThirdName.Text;
            person.LastName = txtBoxLastName.Text;
            person.NationnalNumber = txtBoxNationalNum.Text;
            person.Address = txtBoxAddress.Text;
            person.Email = txtBoxEmail.Text;
            person.Phone = txtBoxPhone.Text;
            person.Nationality=cmbCountries.Text;
            person.DateOfBirth=dtpDateOfBirth.Value;
            if (rdoMale.Checked)
            {
                person.Gender = 'M';
            }
            else
            {
                person.Gender = 'F';
            }
            person.Save();

            string path = Path.Combine(Application.StartupPath, "DVLDImages");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string newName = Guid.NewGuid().ToString() + Path.GetExtension(imagePath);
            person.PersonalImagePath = newName;
            File.Copy(newName, path, true);

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

        }
    }
}
