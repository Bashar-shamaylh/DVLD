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
            chkbRememberMe.Checked = true;
            clsUtil.CreateFolderIfDoesNotExist(path);//create DVLD folder if not exist  //step 1

            path = Path.Combine(path, "UsersInfo.txt");
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");         //create UsersInfo.txt if not exist //step2
            }


            string savedUser = File.ReadAllText(path);               //step 3
            if (!string.IsNullOrEmpty(savedUser))
            {
                int idx = savedUser.IndexOf("/##/"); //bashar/##/12456
                txtUserName.Text = savedUser.Substring(0, idx);
                txtPassword.Text = savedUser.Substring(idx + 4);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isactive = false;
            int userid = -1;
            if (!chkbRememberMe.Checked)
            {
                File.WriteAllText(path, "");
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name Cannot be Empty!");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Cannot be Empty!");
            }
            else if (clsUser.FindUserByUserNameAndUserPassword(txtUserName.Text, txtPassword.Text, ref isactive,ref userid))
            {
                if (!isactive)
                {
                    MessageBox.Show("This User is not Active,Plese Contact you'r Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                   
                    if (chkbRememberMe.Checked)
                    {
                                                
                                                
                        File.WriteAllText(path,txtUserName.Text+"/##/"+txtPassword.Text);


                    }

                    clsGlobalProjectSettings.CurrentUserId = userid;
                    Main main = new Main();
                    main.Show();
                    
                    

                }

            }
            else
            {
                MessageBox.Show("Invalid Password or User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
