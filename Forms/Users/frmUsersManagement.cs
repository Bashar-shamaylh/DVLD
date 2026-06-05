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
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        DataTable _dtUsers;
        DataView _dvUsers;
        public void LoadUsersDataIntoTheForm()
        {
            _dtUsers = clsUser.GetUsersInfo();
            _dvUsers = new DataView(_dtUsers);
            grdvUsers.DataSource = _dtUsers;
            lblNumberOfRecordsResult.Text = _dtUsers.Rows.Count.ToString();
            cmbxFitlerItems.Items.Add("UserID");
            cmbxFitlerItems.Items.Add("UserName");
            cmbxFitlerItems.Items.Add("UserPassword");
            cmbxFitlerItems.Items.Add("PersonID");
            cmbxFitlerItems.Items.Add("isActive");
           
        }
        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            LoadUsersDataIntoTheForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();

            // If the box is empty, reset the filter and STOP
            if (string.IsNullOrEmpty(filterText))
            {
                _dvUsers.RowFilter = "";
                return;
            }
            string ColumnName = cmbxFitlerItems.Text.Trim();
            if (cmbxFitlerItems.SelectedIndex == 0)
                _dvUsers.RowFilter = $"{ColumnName} = {filterText}";
            else if (cmbxFitlerItems.SelectedIndex == 9)
                _dvUsers.RowFilter = $"{ColumnName} = '{filterText}'";
            else
                _dvUsers.RowFilter = $"{ColumnName} LIKE '%{filterText}%'";

            grdvUsers.DataSource = _dvUsers;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbxFitlerItems.SelectedIndex == 0 || cmbxFitlerItems.SelectedIndex == 5 || cmbxFitlerItems.SelectedIndex == 6)
            {
                if (char.IsLetter(e.KeyChar))
                {
                    // Set Handled to true to "cancel" the event and block the character
                    e.Handled = true;
                }

            }
            else if (cmbxFitlerItems.SelectedIndex == 1 || cmbxFitlerItems.SelectedIndex == 2 || cmbxFitlerItems.SelectedIndex == 3 || cmbxFitlerItems.SelectedIndex == 4)
            {
                if (char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;
                }
            }
            else if (cmbxFitlerItems.SelectedIndex == 9)
            {
                if (e.KeyChar != 'M' && e.KeyChar != 'm' && e.KeyChar != 'F' && e.KeyChar != 'f' && e.KeyChar != (char)Keys.Back)
                {

                    e.Handled = true;
                }
            }
        }

        private void tsmAddUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
             frmAddNewUser frmaddnewuser=new frmAddNewUser();
            frmaddnewuser.ShowDialog();
        }
    }
}
