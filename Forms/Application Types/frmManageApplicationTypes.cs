using DVLD.Forms.Application_Types;
using DVLD.Forms.Test_Types;
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
namespace DVLD.Forms.Applictaion_Types
{
    public partial class frmManageApplicationTypes : Form
    {
        
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            
        }   
        private DataTable _DtApplicationTypes;
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _DtApplicationTypes = clsApplicationType.GetAllData();
            dgvApplicationTypes.DataSource = _DtApplicationTypes;
            lblNumberOfRecords.Text = dgvApplicationTypes.ColumnCount.ToString();
            if (_DtApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "Application Type ID";
                dgvApplicationTypes.Columns[0].Width = 120;
               
                dgvApplicationTypes.Columns[1].HeaderText = "Application Type Title";
                dgvApplicationTypes.Columns[1].Width = 250;
                
                dgvApplicationTypes.Columns[2].HeaderText = "Test Type fees";
                dgvApplicationTypes.Columns[2].Width = 120;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmEditApplicationType_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frmEditApplicationType frm = new frmEditApplicationType(id);
            frm.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }
    }
}
