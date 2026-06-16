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

namespace DVLD.user_Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
            
        }
        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {
            
        }
        public void ctrlUserInfo_Load(clsUser user)
        {
            if(user!=null)
            {
                lblUserIDResult.Text = user.UserID.ToString();
                lblUserNameResult.Text = user.UserName.ToString();
                if (user.isActive)
                {
                    lblIsActiveResult.Text = "Yes";

                }
                else
                    lblIsActiveResult.Text = "No";
            }
           
        }
    }
}
