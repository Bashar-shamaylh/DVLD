using DVLD.Forms;
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
        public int personID=-1;
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
            pcbPersonalImage.Image = Properties.Resources.Male_512;
        }
     
        private void _FillPersonInfoIntoTheForm(clsPerson person)
        {
            try
            {
                
                if (person != null)
                {personID=person.ID;
                    lblPersonIdResult.Text = person.ID.ToString();
                    lblNameResult.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                    lblNationalNoResult.Text = person.NationnalNumber.ToString();
                    lblGendorResult.Text = person.Gender.ToString();

                    if (person.Email != null)
                    {
                        lblEmailResult.Text = person.Email.ToString();
                    }
                    if (person.Address != null)
                    {
                        lblAddressResult.Text = person.Address.ToString();
                    }
                    lblDateOfBirthResult.Text = person.DateOfBirth.ToString();
                    if (person.Phone != null)
                    {
                        lblPhoneResult.Text = person.Phone.ToString();
                    }

                    lblCountryResult.Text = person.Nationality.ToString();
                    if (person.PersonalImage != null)
                    {
                        string path = Path.Combine(Application.StartupPath, "DVLDImages"); //insted of compining the path each time,add the path into the global settings

                        path = Path.Combine(path, person.PersonalImage);
                        if (File.Exists(path))
                        {

                            pcbPersonalImage.Image = Image.FromFile(path);
                        }
                        else
                        {
                            if (lblGendorResult.Text == "M")
                                pcbPersonalImage.Image = Properties.Resources.Male_512;
                            else if(lblGendorResult.Text == "F")
                                pcbPersonalImage.Image= Properties.Resources.Female_512;
                        }


                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
     
        public void ctrlPersonInfo_Load(int PersonID)
        {
            clsPerson person=clsPerson.Find(PersonID);
            _FillPersonInfoIntoTheForm(person);
        }
        public void ctrlPersonInfo_Load(string PersonNationalNum)
        {
            clsPerson person = clsPerson.FindPersonByNationnalNum(PersonNationalNum);
            _FillPersonInfoIntoTheForm(person);
        }

        private void grbUserInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void linklblEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonInfoUI addEditPersonInfoUI = new AddEditPersonInfoUI(Convert.ToInt32(lblPersonIdResult.Text));
            addEditPersonInfoUI.ShowDialog();
        }

        private void grbUserInfo_Enter_1(object sender, EventArgs e)
        {

        }

        private void pcbPersonalImage_Click(object sender, EventArgs e)
        {

        }
    }
}
