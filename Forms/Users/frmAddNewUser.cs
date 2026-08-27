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
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddNewUser(int Userid)
        {
            InitializeComponent();

            user = clsUser.Find(Userid);
            ctrlPersonInfoWithFilter1.LoadPersonInfo(user.PersonID);
            ctrlPersonInfoWithFilter1.FilterEnabeld = false;
            lblTitle.Text = "Update";
            _FillUserInfoIntoTheForm();

            
        }
        public frmAddNewUser()
        {
            InitializeComponent();
            
        }
        private void _FillUserInfoIntoTheForm()
        {
            
            txtboxUserName.Text = user.UserName;
            txtboxPassword.Text = user.UserPassword;
            lblUserIDResult.Text = user.UserID.ToString();
            txtboxConfirmPassword.Visible = false;
            if (user.isActive)
                chkisActive.Checked = true;
            else
                chkisActive.Checked = false;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void txtboxUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxUserName.Text))
            {
                errorProvider1.SetError(txtboxUserName, "");
            }
        }

        private void txtboxUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxUserName.Text))
            {
                errorProvider1.SetError(txtboxUserName, "User Name is Required,it can't be empty!");
            }

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxPassword.Text))
            {
                errorProvider1.SetError(txtboxPassword, "");
            }

        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPassword.Text))
            {
                errorProvider1.SetError(txtboxPassword, "User Name is Required,it can't be empty!");
            }

        }

        private void txtboxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxConfirmPassword.Text))
            {
                errorProvider1.SetError(txtboxConfirmPassword, "");
            }
            else if (txtboxConfirmPassword.Text == txtboxPassword.Text)
            {

                errorProvider1.SetError(txtboxConfirmPassword, "");

            }
        }

        private void txtboxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxConfirmPassword.Text))
            {
                errorProvider1.SetError(txtboxConfirmPassword, "Cant be empty!");
            }
            else if (txtboxConfirmPassword.Text != txtboxPassword.Text)
            {

                errorProvider1.SetError(txtboxConfirmPassword, "Password Mismatch!");

            }
        }

        private void tbpLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            
          
            
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

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (person != null)
            {

                user=clsUser.FindUserByPersonID(person.ID);
                tabControl1.SelectedIndex = 1;
              
                
            }
            
        }

        private void tbpPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            person = clsPerson.Find(obj);
            

        }

        private void ctrlPersonInfoWithFilter1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
