using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form MangePeoplePage=new MangePeople();
        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MangePeoplePage.MdiParent = this;
            MangePeoplePage.Show();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("its a Strip Still Working :)");
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("its a Strip Still Working :)");
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("its a Strip Still Working :)");
        }
    }
}
