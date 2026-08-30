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
        private int _UserID = -1;
        clsUser user ;
        public frmChangeUserPassword(int userid=-1)
        {
            InitializeComponent();
            _UserID = userid;
        }
    
        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            user=clsUser.Find(_UserID);
           
            if (user != null)
            {
                ctrlUserInfo2.LoadUserInfo(_UserID);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool IsTxtBoxNullOrWhiteSpace(TextBox txtbox,string Message)
        {
            if (string.IsNullOrWhiteSpace(txtbox.Text))
            {
                errorProvider1.SetError(txtbox, Message);

                return true;
            }
            errorProvider1.SetError(txtbox, "");
            return false;

        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                return;
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

        private void txtboxCurrentPassowrd_Validating(object sender, CancelEventArgs e)
        {
            if (IsTxtBoxNullOrWhiteSpace(txtboxCurrentPassowrd, "Current Password Canont be blank"))
            { e.Cancel = true; return; }
               
            if(user.UserPassword!= txtboxCurrentPassowrd.Text.Trim())
            {
                errorProvider1.SetError(txtboxCurrentPassowrd, "Current Password Is not Correct");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(txtboxCurrentPassowrd,null);
        }

        private void txtboxNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (IsTxtBoxNullOrWhiteSpace(txtboxNewPassword, "New Password Canont be blank"))
            { e.Cancel = true; return; }
        }

        private void txtboxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (IsTxtBoxNullOrWhiteSpace(txtboxConfirmPassword, "Confirm Password Canont be blank"))
            { e.Cancel = true; return; }
            if(txtboxNewPassword.Text!=txtboxConfirmPassword.Text)
            {
                errorProvider1.SetError(txtboxCurrentPassowrd, "Password's do not match");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtboxCurrentPassowrd,null);
        }
    }
}
