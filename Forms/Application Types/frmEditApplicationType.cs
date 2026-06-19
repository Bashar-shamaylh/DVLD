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

namespace DVLD.Forms.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        clsApplicationType aaplicationtype;
        public frmEditApplicationType(int applicationTypeId,string title,float fees)
        {
            InitializeComponent();
            lblApplicationTypeIDResult.Text = applicationTypeId.ToString();
            txtboxTitle.Text = title;
            txtboxFees.Text = fees.ToString();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool changeWasMade = false;
            if ((!string.IsNullOrEmpty(txtboxTitle.Text)) && (!string.IsNullOrEmpty(txtboxFees.Text)))
            {
                changeWasMade=clsApplicationType.Update((int.Parse(lblApplicationTypeIDResult.Text)),txtboxTitle.Text,float.Parse(txtboxFees.Text));
            }
            if (changeWasMade)
            {
                MessageBox.Show("Success");

            }
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {

        }
    }
}
