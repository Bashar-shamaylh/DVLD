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

namespace DVLD.Forms
{
    public partial class frmLoginScreen : Form
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"DVLD");//this path for users data
        
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string UserName = "";string Password = "";
            if (clsGlobalProjectSettings.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkbRememberMe.Checked = true;
            }
            else
                chkbRememberMe.Checked= false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUserNameAndUserPassword(txtUserName.Text, txtPassword.Text);
            if (user != null) 
                {
                if (chkbRememberMe.Checked)
                {
                    clsGlobalProjectSettings.RememberUsernameAndPassword(txtUserName.Text, txtPassword.Text);
                }
                else
                    clsGlobalProjectSettings.RememberUsernameAndPassword("", "");


                if (user.isActive)
                {
                    clsGlobalProjectSettings.CurrentUserId = user.UserID;
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your Account isn't Active Plese Contact Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Invalid Password or User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
