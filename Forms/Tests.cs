using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBussnissLayer;
using DVLD.Forms.Users;

namespace DVLD.Forms
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           PeopleUI peopleUI = new PeopleUI();
            peopleUI.Show();
        }

        private void Tests_Load(object sender, EventArgs e)
        {

        }
    }
}
