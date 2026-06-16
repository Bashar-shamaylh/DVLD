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
            clsUser user = clsUser.Find(UserID);
            ctrlPersonInfo1.ctrlPersonInfo_Load(clsPerson.Find(user.PersonID));
            ctrlUserInfo1.ctrlUserInfo_Load(user);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
