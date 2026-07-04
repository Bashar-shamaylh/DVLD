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
        public frmAddNewUser(int Userid=-1)
        {
            InitializeComponent();
            if (Userid != -1)
            {
                user = clsUser.Find(Userid);


                ctrlPersonInfoWithFilter1.ctrlFindPersonFilter1_Load(user.PersonID);
                
                if (user != null)
                {
                    _FillUserInfoIntoTheForm();
                }
            }
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
            if(user.Mode==clsUser.enMode.AddMode)
            {
                chkisActive.Checked = true;
            }
          
            
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (person!=null)
            {
                if(user.Mode==clsUser.enMode.AddMode)
                    if (clsUser.IsUserWithPersonIDExist(person.ID))
                    {
                        MessageBox.Show("This Person is Allready a User!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                if (!(string.IsNullOrEmpty(txtboxUserName.Text) || string.IsNullOrEmpty(txtboxPassword.Text) || string.IsNullOrEmpty(txtboxConfirmPassword.Text)))
                {
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
                if(user.Mode == clsUser.enMode.AddMode)
                if(clsUser.IsUserWithPersonIDExist(person.ID)) 
                    {
                        MessageBox.Show("This Person is Allready a User!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    }
               
                    tabControl1.SelectedIndex = 1;
                

                    
            }
            
        }

        private void tbpPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
        {

        }
    }
}
