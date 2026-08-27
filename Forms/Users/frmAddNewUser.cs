using DVLD.user_Controls;
using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms.Users
{
    public partial class frmAddNewUser : Form
    {
        clsPerson person;
        clsUser user=new clsUser();

        enum enMode { Add = 0, Update = 1 };
        enMode Mode = enMode.Add;
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddNewUser(int Userid)
        {
            InitializeComponent();
            user = clsUser.Find(Userid);
            if (user != null) {
                Mode = enMode.Update;
                lblTitle.Text = "Update";
                person = clsPerson.Find(user.PersonID);
                ctrlPersonInfoWithFilter1.LoadPersonInfo(user.PersonID);
                ctrlPersonInfoWithFilter1.FilterEnabeld = false;

                _FillUserInfoIntoTheForm();
            }
            else
            {
                Mode = enMode.Add;
            }     
        }
        public frmAddNewUser()
        {
            InitializeComponent();
            //Mode = enMode.Add; the deffult value allready
        }
        private void _FillUserInfoIntoTheForm()
        {
            
            txtboxUserName.Text = user.UserName;
            txtboxPassword.Text = user.UserPassword;
            lblUserIDResult.Text = user.UserID.ToString();
            
            if (user.isActive)
                chkisActive.Checked = true;
            else
                chkisActive.Checked = false;


        }
        private bool _ValidateTextBoxIsNullOrWhiteSpace(TextBox textBox,string Message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, Message);
                return true;
            }
           else
            {
                errorProvider1.SetError(textBox, "");
            }
                return false;
            
               
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

   
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (person!=null)
            {
                    if (!(string.IsNullOrEmpty(txtboxUserName.Text) || string.IsNullOrEmpty(txtboxPassword.Text) ))
                    {
                        //if (string.IsNullOrEmpty(txtboxConfirmPassword.Text))
                        //{
                           
                        //} //replace with Validate function insted of bushet
                        user.UserName = txtboxUserName.Text;
                        user.UserPassword = txtboxPassword.Text;
                        if (chkisActive.Checked)
                        {

                            user.isActive = true;
                        }
                        else { user.isActive = false; }
                        user.PersonID = person.ID;
                        user.Save();
                        lblUserIDResult.Text = user.UserID.ToString();
                    lblTitle.Text = "Update";
                    }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (person != null)
            {
                if (Mode == enMode.Add)
                {
                    if(clsUser.IsUserWithPersonIDExist(person.ID))
                    {
                        MessageBox.Show("Person With This ID Allready a User", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    
                    
                }
                else
                {
                    user = clsUser.FindUserByPersonID(person.ID);
                    
                }

                tabControl1.SelectedIndex = 1;



            }
            
        }
        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            person = clsPerson.Find(obj);
        }
        private void txtboxUserName_Validating(object sender, CancelEventArgs e)
        {
           _ValidateTextBoxIsNullOrWhiteSpace(txtboxUserName,"User Name Is Required!");
           
        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidateTextBoxIsNullOrWhiteSpace(txtboxPassword, "Password Is Required!");
        }

        private void txtboxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidateTextBoxIsNullOrWhiteSpace(txtboxUserName, "Confirm Password Is Required!");
            if (txtboxConfirmPassword.Text != txtboxPassword.Text)
            {

                errorProvider1.SetError(txtboxConfirmPassword, "Password Mismatch!");

            }
        }
    }
}
