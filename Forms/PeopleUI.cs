using DVLDBussnissLayer;
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
    public partial class PeopleUI : Form
    {
        public PeopleUI()
        {
            InitializeComponent();
        }

        private void PeopleUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=clsPearson.GetPeopleInfo(); 
        }
    }
}
