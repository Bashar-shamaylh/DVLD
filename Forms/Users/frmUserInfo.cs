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

namespace DVLD.Forms.Users
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserInfo1.LoadUserInfo(UserID);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
