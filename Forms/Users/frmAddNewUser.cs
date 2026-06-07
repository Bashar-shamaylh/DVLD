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
        public frmAddNewUser()
        {
            InitializeComponent();
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
            chkisActive.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (person!=null)
            {
                if (clsUser.IsUserWithPersonIDExist(person.ID))
                {
                    MessageBox.Show("This Person is Allready a User!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsUser user = new clsUser();
                    if(!(string.IsNullOrEmpty(txtboxUserName.Text)||string.IsNullOrEmpty(txtboxPassword.Text)||string.IsNullOrEmpty(txtboxConfirmPassword.Text)))
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
        }

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
             person = ctrlPersonInfoWithFilter1.person;
            if (person != null)
            {
                if(clsUser.IsUserWithPersonIDExist(person.ID)) 
                    {
                        MessageBox.Show("This Person is Allready a User!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                {
                    tabControl1.SelectedIndex = 1;
                }

                    
            }
            
        }
    }
}
