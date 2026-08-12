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
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo(int id)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadPersonInfo((id));
        }
        public frmPersonInfo(string NationnalNum)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadPersonInfo((NationnalNum));
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
