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
        PeopleUI Peopleform = new PeopleUI();

        private void applicationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Peopleform.MdiParent = this;
            Peopleform.Show();

        }
    }
}
