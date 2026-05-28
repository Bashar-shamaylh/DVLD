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
            ctrlPersonInfo1.ctrlPersonInfo_Load(id);
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            
        }

    }
}
