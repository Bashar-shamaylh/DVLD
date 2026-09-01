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

namespace DVLD.Forms.Test_Types
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }
        private DataTable _DtTestTypes;
        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _DtTestTypes = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _DtTestTypes;
            lblNumberOfRecords.Text = dgvTestTypes.ColumnCount.ToString();
            if (_DtTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "Test Type ID";
                dgvTestTypes.Columns[0].Width = 120;

                dgvTestTypes.Columns[1].HeaderText = "Test Type Title";
                dgvTestTypes.Columns[1].Width = 120;

                dgvTestTypes.Columns[2].HeaderText = "Test Type Description";
                dgvTestTypes.Columns[2].Width = 300;

                dgvTestTypes.Columns[3].HeaderText = "Test Type fees";
                dgvTestTypes.Columns[3].Width = 120;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value);
            frmUpdateTestType frm= new frmUpdateTestType(id);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);
        }
    }
}
