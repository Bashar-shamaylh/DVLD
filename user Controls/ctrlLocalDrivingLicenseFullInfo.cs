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
    public partial class ctrlLocalDrivingLicenseFullInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
        public int LocalDrivingLicenseAppID { get { return _LocalDrivingLicenseAppID; } }
        public ctrlLocalDrivingLicenseFullInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int localDrivingApplicationID)
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(localDrivingApplicationID);
            if (_LocalDrivingLicenseApp == null)
            {
                
                MessageBox.Show("Error", "No Local Driving License Application With This ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlLocalDrivingLicenseApplicationInfo1.LoadApplicationInfo(localDrivingApplicationID);
            ctrlApplicationInfo1.LoadApplicationInfo(_LocalDrivingLicenseApp.ApplicationID);
        }
        private void ctrlLocalDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
