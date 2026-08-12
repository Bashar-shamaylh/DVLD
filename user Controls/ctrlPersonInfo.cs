using DVLD.Forms;
using DVLD.Properties;
using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInfo : UserControl
    {
        private clsPerson _Person;
        private int _personID=-1;
        public int PersonID { get { return _personID; } }
        public clsPerson SelectedPersonInfo { get { return _Person; } }
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person=clsPerson.Find(PersonID);
            if(_Person==null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Error","No Person With This ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfoIntoTheForm();
        }
        public void LoadPersonInfo(string NationnalNum)
        {
            _Person = clsPerson.FindPersonByNationnalNum(NationnalNum);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("Error", "No Person With This ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfoIntoTheForm();
        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
            pcbPersonalImage.Image = Properties.Resources.Male_512;
        }
     
        private void _FillPersonInfoIntoTheForm()
        {
            linklblEditPersonInfo.Enabled = true;
            try
            {



                lblPersonIdResult.Text = _Person.ID.ToString();
                lblNameResult.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                lblNationalNoResult.Text = _Person.NationnalNumber.ToString();
                lblGendorResult.Text = _Person.Gender.ToString();

                if (_Person.Email != null) { lblEmailResult.Text = _Person.Email.ToString(); }
                    
            
                 if(_Person.Address !=null) { lblAddressResult.Text = _Person.Address.ToString(); }
                      
                    
                    lblDateOfBirthResult.Text = _Person.DateOfBirth.ToString();
              if(_Person.Phone!=null)
                    lblPhoneResult.Text = _Person.Phone.ToString();
                

                    lblCountryResult.Text = _Person.Nationality.ToString();
                lblGendor.Text = _Person.Gender == 0 ? "Male" : "Female";
                _LoadPersonImage();

                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
            {
                pcbPersonalImage.Image = Resources.Male_512;
            }
            else
            {
                pcbPersonalImage.Image = Resources.Female_512;
            }
            string imagepath = _Person.ImagePath;
            if (imagepath != ""&&imagepath!=null)
            {
                if (File.Exists(imagepath))
                {
                    pcbPersonalImage.ImageLocation = imagepath;
                }
                else
                {
                    
                    MessageBox.Show("Error", "Could Not Find This Image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     
        private void _ResetPersonInfo()
        {
            lblNameResult.Text = "?????";
            lblPersonIdResult.Text = "?????";
            lblNationalNoResult.Text = "?????";
            lblEmailResult.Text = "?????";
            lblAddressResult.Text = "?????";
            lblPhoneResult.Text = "?????";
            lblGendorResult.Text = "?????";
            lblDateOfBirthResult.Text = "?????";
            lblCountryResult.Text = "?????";

        }

        private void linklblEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonInfoUI addEditPersonInfoUI = new AddEditPersonInfoUI(_personID);
            addEditPersonInfoUI.ShowDialog();
            LoadPersonInfo(_personID);
        }

        private void grbUserInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
