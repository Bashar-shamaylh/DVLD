using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms.Users;
using DVLDBussnissLayer;
namespace DVLD.Forms.Users
{
    public partial class frmChangeUserPassword : Form
    {
        clsUser user = new clsUser();
        public frmChangeUserPassword(int userid=-1)
        {
            InitializeComponent();
            user = clsUser.Find(userid);
            if (user != null)
            {
                ctrlPersonInfo1.ctrlPersonInfo_Load(clsPerson.Find(user.PersonID));
                ctrlUserInfo1.ctrlUserInfo_Load(user);
            }
            
            
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxCurrentPassowrd_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
            {
                errorProvider1.SetError(txtboxCurrentPassowrd, "");
            }
                

        }

        private void txtboxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
                errorProvider1.SetError(txtboxCurrentPassowrd, "");
        }

        private void txtboxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
                errorProvider1.SetError(txtboxCurrentPassowrd, "");
        }

        private void txtboxCurrentPassowrd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
                errorProvider1.SetError(txtboxCurrentPassowrd, "this Field Cannot be empty!");
        }

        private void txtboxNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
                errorProvider1.SetError(txtboxCurrentPassowrd, "this Field Cannot be empty!");
        }

        private void txtboxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
                errorProvider1.SetError(txtboxCurrentPassowrd, "this Field Cannot be empty!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtboxCurrentPassowrd.Text) ||
                string.IsNullOrEmpty(txtboxCurrentPassowrd.Text) ||
                string.IsNullOrEmpty(txtboxCurrentPassowrd.Text))
            {
                MessageBox.Show("Some Fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtboxCurrentPassowrd.Text.Trim() != user.UserPassword)
            {
                MessageBox.Show("Current Password is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtboxNewPassword.Text.Trim() != txtboxConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                user.UserPassword = txtboxNewPassword.Text.Trim();
                try
                {
                    user.Save();
                    MessageBox.Show("Password Was Changed Succefuly.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("UnExpected Error Has Occored!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
               
            }

            }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
