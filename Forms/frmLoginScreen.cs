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
        string path = Path.Combine(
                     Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                     "DVLD",
                     "UsersInfo.txt"
                 );
        
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }

            string savedUser = File.ReadAllText(path);
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
        
             if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User Name Cannot be Empty!");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Cannot be Empty!");
            }
            else if (clsUser.FindUserByUserNameAndUserPassword(txtUserName.Text, txtPassword.Text, ref isactive))
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
