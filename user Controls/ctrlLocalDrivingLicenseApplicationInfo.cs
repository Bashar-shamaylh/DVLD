using DVLD.Forms;
using DVLD.Properties;
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
    public partial class ctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
        public int LocalDrivingLicenseAppID { get { return _LocalDrivingLicenseAppID; } }

        public ctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int localDrivingApplicationID)
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(localDrivingApplicationID);
            if (_LocalDrivingLicenseApp == null)
            {
                ResetControlInfo();
                MessageBox.Show("Error", "No Local Driving License Application With This ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LocalDrivingLicenseAppID = localDrivingApplicationID;
            _FillApplicationInfoIntoTheForm();
        }
        private void _FillApplicationInfoIntoTheForm()
        {
            linkLabel1.Enabled = (_LocalDrivingLicenseApp.PassedTests == 3);
            lblLicenseClassName.Text= _LocalDrivingLicenseApp.LicenseClassInfo.ClassName;
            lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblPassedTests.Text=_LocalDrivingLicenseApp.PassedTests.ToString();
        }
       
        public void ResetControlInfo()
        {
            lblLicenseClassName.Text = "?????";
            lblLocalDrivingLicenseApplicationID.Text = "?????";
            lblPassedTests.Text = "?????";
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
