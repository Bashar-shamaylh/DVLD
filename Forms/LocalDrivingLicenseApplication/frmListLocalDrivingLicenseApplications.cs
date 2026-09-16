using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Forms.LocalDrivingLicenseApplication
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private static DataTable _dtLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetApplicationInfo();

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;
            lblNumberOfRecords.Text = _dtLocalDrivingLicenseApplications.Rows.Count.ToString();
            //cmbxFitlerItems.SelectedIndex = 0;
            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                
                    dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.ApplicationID";
                    dgvLocalDrivingLicenseApplications.Columns[0].Width = 110;

                    dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "License Class";
                    dgvLocalDrivingLicenseApplications.Columns[1].Width = 110;

                    dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National Number";
                    dgvLocalDrivingLicenseApplications.Columns[2].Width = 110;

                    dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                    dgvLocalDrivingLicenseApplications.Columns[3].Width = 120;

                    dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                    dgvLocalDrivingLicenseApplications.Columns[4].Width = 120;

                    dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Application State";
                    dgvLocalDrivingLicenseApplications.Columns[5].Width = 120;

                    //dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Passed Tests";
                    //dgvLocalDrivingLicenseApplications.Columns[6].Width = 110;

                
            }
        }

       
        private void _RefreshApplicatoinsList()
        {
            _dtLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetApplicationInfo();

            dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;
            lblNumberOfRecords.Text = _dtLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            switch (cbFilterItems.SelectedText)
            {
                case "None":
                    txtFilterValue.Visible = false;
                   
                    cbStateValues.Visible = false;
                    break;
                case "State":
                    txtFilterValue.Visible = false;
                   
                    cbStateValues.Visible = true; break;
                
                default:
                    txtFilterValue.Visible = true;
                    cbStateValues.Visible = false;
                    
                    break;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            //None
            //    L.D.L.ApplicationID
            //    National Number
            //    Full Name
            //    Status
            string FilterColumn="";
            switch (cbFilterItems.SelectedText)
            {
                case "L.D.L.ApplicationID":
                    FilterColumn = "L.D.L.ApplicationID"; break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "National Number":
                    FilterColumn = "NationalNumber";
                    break;

                default:
                    _dtLocalDrivingLicenseApplications.DefaultView.RowFilter ="";
                    return;
                    

            }
            if(FilterColumn== "L.D.L.ApplicationID")
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter=string.Format("[{0}]={1}",FilterColumn,txtFilterValue.Text.Trim());
            else
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterItems.Text == "L.D.L.ApplicationID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
