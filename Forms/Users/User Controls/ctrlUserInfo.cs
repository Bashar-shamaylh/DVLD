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
        clsUser _User;
        private int _UserId;
        public int UserID
            {
            get { return _UserId; }
            }

        public ctrlUserInfo()
        {
            InitializeComponent();
            
        }
        public void LoadUserInfo(int userid)
        {
            _User = clsUser.Find(userid);
            if (_User == null)
            {
                _ResetUserInfo();
                MessageBox.Show("No User With User ID : "+userid+" .","Invalid User ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }
        private void _ResetUserInfo()
        {
            _UserId = -1;
            _User = null;
            ctrlPersonInfo1.ResetPersonInfo();
            lblUserIDResult.Text = "[???]";
            lblUserNameResult.Text = "[???]";
            lblIsActiveResult.Text = "[???]";
        }
        private void _FillUserInfo()
        {
            ctrlPersonInfo1.LoadPersonInfo(_User.PersonID);
            lblUserIDResult.Text = _User.UserID.ToString();
            lblUserNameResult.Text = _User.UserName.ToString();
            if (_User.isActive)
            {
                lblIsActiveResult.Text = "Yes";

            }
            else
                lblIsActiveResult.Text = "No";
        }
    }
}
