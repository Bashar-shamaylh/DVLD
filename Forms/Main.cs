using DVLD.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        
        private void applicationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleUI Peopleform = new PeopleUI();
            Peopleform.MdiParent = this;
            
            Peopleform.Show();


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.MdiParent = this;
            frmUsersManagement.Show();
        }

    }
}
