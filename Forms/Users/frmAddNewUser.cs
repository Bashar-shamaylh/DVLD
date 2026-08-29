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
        enum enMode { Add = 0, Update = 1 };
        enMode Mode = enMode.Add;

                           
        clsUser User;
        private int _UserID = -1;
        
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddNewUser(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
            Mode = enMode.Update;
        }
        public frmAddNewUser()
        {
            InitializeComponent();
            
        }
        private void _LoadUserData()
        {
            User=clsUser.Find(_UserID);
            ctrlPersonInfoWithFilter1.FilterEnabeld = false;
            if (User == null)
            {
                User = new clsUser();
                MessageBox.Show("No User With This ID!", "User Was'nt Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            txtboxUserName.Text = User.UserName;
            txtboxPassword.Text = User.UserPassword;
            txtboxConfirmPassword.Text=User.UserPassword;
            lblUserIDResult.Text = User.UserID.ToString();
            chkisActive.Checked = User.isActive;

            ctrlPersonInfoWithFilter1.LoadPersonInfo(User.PersonID);


        }
        private void _ResetDefaultValues()
        {
            if(Mode==enMode.Update)
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;

                tbpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                lblTitle.Text = "Add New User";
                this.Text = lblTitle.Text;
                tbpLoginInfo.Enabled = false;
                User = new clsUser();
                ctrlPersonInfoWithFilter1.FilterFocus();
            }
        }
        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(Mode==enMode.Update) 
                _LoadUserData();
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
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds are Empty,Plese Fill the Field's With The Red Icon", "Empty Fileds Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User.UserName = txtboxUserName.Text.Trim();   
            User.UserPassword = txtboxPassword.Text.Trim();
            User.isActive = chkisActive.Checked;
            if (User.Save())
            {
                lblUserIDResult.Text = User.UserID.ToString();
                lblTitle.Text = "Update User";
                Mode = enMode.Update;
                MessageBox.Show("Data was Saved Succefully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbpLoginInfo.Enabled = true;

                tabControl1.SelectedTab = tbpLoginInfo;
                return;
            }


            if (ctrlPersonInfoWithFilter1.PersonID != -1)
            {
                if (clsUser.IsUserWithPersonIDExist(User.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonInfoWithFilter1.FilterFocus();

                }
                else
                {
                    btnSave.Enabled = true;
                    tbpLoginInfo.Enabled = true;

                    tabControl1.SelectedTab = tbpLoginInfo;
                    return;

                }



            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonInfoWithFilter1.FilterFocus();



            }
        }
       
        private void txtboxUserName_Validating(object sender, CancelEventArgs e)
        {
           if(_ValidateTextBoxIsNullOrWhiteSpace(txtboxUserName,"User Name Is Required!"))
            {
                e.Cancel = true;
                return;
            }
               

            if(Mode == enMode.Add)
            {
                if(clsUser.IsUserWithUserNameExist(txtboxUserName.Text.Trim()))

                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtboxUserName, "User Name is Allready Used from another person");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtboxUserName, null);
                }
            }
            else
            {
                if (User.UserName != txtboxUserName.Text.Trim())
                {
                    if (clsUser.IsUserWithUserNameExist(txtboxUserName.Text.Trim()))

                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtboxUserName, "User Name is Allready Used from another person");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtboxUserName, null);
                    }
                    ;
                }
            }


        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
           if( _ValidateTextBoxIsNullOrWhiteSpace(txtboxPassword, "Password Is Required!"))
                e.Cancel = true;
        }

        private void txtboxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(_ValidateTextBoxIsNullOrWhiteSpace(txtboxUserName, "Confirm Password Is Required!"))
            {
                e.Cancel = true;
                return;
            }
                
            if (txtboxConfirmPassword.Text != txtboxPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtboxConfirmPassword, "Password Mismatch!");

            }
            else
            { errorProvider1.SetError(txtboxUserName, null); }
        }

      
    }
}
