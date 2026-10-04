using DVLD.user_Controls;
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

namespace DVLD.Forms.LocalDrivingLicenseApplication
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        enum enMode { Add = 0, Update = 1 };
        enMode Mode = enMode.Add;
        private int _PersonID;
        private int _LocalDrivingLicenseAppID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        public frmAddUpdateLocalDrivingLicenseApplication(int localdrivinglicenseapplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID=localdrivinglicenseapplicationID;
            Mode = enMode.Update;
        }
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
       
        private void _LoadApplicationData()
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseAppID);
            
            if (_LocalDrivingLicenseApp == null)
            {
               
                MessageBox.Show("No Application With This ID!", "Application Was'nt Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseApplication();
                Mode = enMode.Add;
                _ResetDefaultValues();
                return;

            }

            ctrlPersonInfoWithFilter1.FilterEnabeld = false;
            lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text= _LocalDrivingLicenseApp.ApplicationDate.ToString();
            lblApplicationFees.Text= _LocalDrivingLicenseApp.PaidFees.ToString();
            cbLicenseClasses.SelectedIndex = _LocalDrivingLicenseApp.LicenseClassID-1;
            lblUserName.Text = _LocalDrivingLicenseApp.CreatedByUserID.ToString();

            ctrlPersonInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApp.PersonID);


        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.Update)
            {
                lblTitle.Text = "Update Application";
                this.Text = lblTitle.Text;

                tbpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                lblTitle.Text = "Add New Application";
                this.Text = lblTitle.Text;
                tbpApplicationInfo.Enabled = false;
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseApplication();

                
                
                lblApplicationDate.Text =DateTime.Now.ToString();
                lblApplicationFees.Text = _LocalDrivingLicenseApp.applicationType.Fees.ToString();
                cbLicenseClasses.SelectedIndex = 2;
                lblUserName.Text = clsGlobalProjectSettings.CurrentUserId.ToString();

                ctrlPersonInfoWithFilter1.FilterFocus();
            }
        }
      
       
   
 
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (_PersonID!=-1)
            {
                _LocalDrivingLicenseApp.PersonID = ctrlPersonInfoWithFilter1.PersonID;
                btnSave.Enabled = true;
                tbpApplicationInfo.Enabled = true;

                tbAddUpdateLocalApplication.SelectedTab = tbpApplicationInfo;
                return;
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonInfoWithFilter1.FilterFocus();
            }
        }

        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (Mode == enMode.Update)
                _LoadApplicationData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!this.ValidateChildren())
            //{
            //    MessageBox.Show("Some Fileds are Empty,Plese Fill the Field's With The Red Icon", "Empty Fileds Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //check if thee Person Has an application already for the same class and its not Canceled
            _LocalDrivingLicenseApp.LicenseClassID = cbLicenseClasses.SelectedIndex + 1;
            if (Mode == enMode.Add)
            {
                _LocalDrivingLicenseApp.CreatedByUserID = clsGlobalProjectSettings.CurrentUserId;
                if (clsLocalDrivingLicenseApplication.GetActiveApplicationIDForLicenseClass
                    (_LocalDrivingLicenseApp.PersonID, _LocalDrivingLicenseApp.ApplicationType, _LocalDrivingLicenseApp.LicenseClassID)==-1)
                {
                    MessageBox.Show("This Person Has Already an Active Application For the same License Class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
           




            if (_LocalDrivingLicenseApp.Save())
            {
                lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
                lblTitle.Text = "Update Local Driving License Application";
                Mode = enMode.Update;
                MessageBox.Show("Data was Saved Succefully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }
    }
}

