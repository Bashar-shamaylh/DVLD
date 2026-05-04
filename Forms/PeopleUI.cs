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
            DataTable dt = new DataTable();
            dt= clsPearson.GetPeopleInfo();
            grdvPeople.DataSource=dt;
            lblNumberOfRecordsResult.Text=dt.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
