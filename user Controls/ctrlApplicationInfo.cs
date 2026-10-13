using DVLD.Forms;
using DVLDBussnissLayer;
using System;
using System.Windows.Forms;

namespace DVLD.user_Controls
{
    public partial class ctrlApplicationInfo : UserControl
    {
        private clsApplication _Application;
        private int _ApplicationID = -1;
        public int ApplicationID { get { return _ApplicationID; } }
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int applicationid)
        {
            _Application = clsApplication.FindBaseApplication(applicationid);
            if (_Application == null)
            {
                ResetControlInfo();
                MessageBox.Show("Error", "No Application With This ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ApplicationID = applicationid;
            _FillApplicationInfoIntoTheForm();
        }
        private void _FillApplicationInfoIntoTheForm()
        {

            lblCreatedByUserID.Text = _Application.CreatedByUserID.ToString();
            lblStatusDate.Text = _Application.LastStatusDate.ToString();

            lblDate.Text = _Application.ApplicationDate.ToString();
            lblApplicantFullName.Text = _Application.PersonInfo.FirstName.ToString();

            lblType.Text = _Application.ApplicationType.ToString();        //its enum i should convert it to string //
            lblFees.Text = _Application.PaidFees.ToString();

            lblStatus.Text = _Application.ApplicationState.ToString();        //its enum i should convert it to string //
            lblApplicationid.Text = _Application.ApplicationID.ToString();

            

        }

        public void ResetControlInfo()
        {
            lblCreatedByUserID.Text = "?????";
            lblStatusDate.Text = "?????";

            lblDate.Text = "?????";
            lblApplicantFullName.Text = "?????";

            lblType.Text = "?????";
            lblFees.Text = "?????";

            lblStatus.Text = "?????";
            lblApplicationid.Text = "?????";

        }

        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frm=new frmPersonInfo(_Application.PersonID);
            frm.ShowDialog();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
