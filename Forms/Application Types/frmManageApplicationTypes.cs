using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms.Application_Types;
using DVLDBussnissLayer;
namespace DVLD.Forms.Applictaion_Types
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable _dtApplicationTypes;
        DataView _dvApplicationTypes;
        string currentTitle = "";
        float currentFees = 0;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            _dtApplicationTypes = clsApplicationType.GetAllData();
            _dvApplicationTypes=_dtApplicationTypes.DefaultView;
            grdvApplicationTypes.DataSource = _dvApplicationTypes;
            lblRecordsResult.Text= _dtApplicationTypes.Rows.Count.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdvApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdvApplicationTypes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.Button == MouseButtons.Right)
            {


                grdvApplicationTypes.CurrentCell = grdvApplicationTypes.Rows[e.RowIndex].Cells[0];
                currentTitle = grdvApplicationTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
                currentFees= float.Parse(grdvApplicationTypes.Rows[e.RowIndex].Cells[2].Value.ToString());
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void tsmEditApplicationType_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvApplicationTypes.CurrentCell.Value.ToString(), out int id))
            {
               frmEditApplicationType editApplicationType=new frmEditApplicationType(id,currentTitle,currentFees);
                editApplicationType.ShowDialog();
                _dtApplicationTypes = clsApplicationType.GetAllData();
                _dvApplicationTypes = _dtApplicationTypes.DefaultView;
                grdvApplicationTypes.DataSource = _dvApplicationTypes;

            }
        }
    }
}
