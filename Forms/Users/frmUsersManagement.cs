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
            cmbxIsActiveOptions.Items.Add("All");
            cmbxIsActiveOptions.Items.Add("Yes");
            cmbxIsActiveOptions.Items.Add("No");
        }
        public void ApplyFilter()
        {
			string ColumnName = cmbxFitlerItems.Text.Trim();
            if (ColumnName == "isActive")
            {
                if (cmbxIsActiveOptions.SelectedIndex == 1)
                {
                    _dvUsers.RowFilter = $"{ColumnName} = true";
                }
                else if (cmbxIsActiveOptions.SelectedIndex == 2)
                {
					_dvUsers.RowFilter = $"{ColumnName} = false";
				}

			}
            else
            {
				string filterText = txtSearch.Text.Trim();

				// If the box is empty, reset the filter and STOP
				if (string.IsNullOrEmpty(filterText))
				{
					_dvUsers.RowFilter = "";
					return;
				}

				if (ColumnName== "UserID"|| ColumnName=="PersonID") //UserID or PersonID
					_dvUsers.RowFilter = $"{ColumnName} = {filterText}";
				else if (ColumnName=="UserName" || ColumnName=="UserPassword")//password or username
					_dvUsers.RowFilter = $"{ColumnName} Like '%{filterText}%'";
				else
					_dvUsers.RowFilter = "";
			}
			

			grdvUsers.DataSource = _dvUsers;
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
            if (cmbxFitlerItems.SelectedIndex == 4)
            {
                cmbxIsActiveOptions.Visible = true;
                txtSearch.Visible = false;
            }
            else
            {
                cmbxIsActiveOptions.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

			if (cmbxFitlerItems.SelectedIndex == 0 || cmbxFitlerItems.SelectedIndex == 3)
			{
				if (char.IsLetter(e.KeyChar))
				{
					// Set Handled to true to "cancel" the event and block the character
					e.Handled = true;
				}

			}
			else if (cmbxFitlerItems.SelectedIndex == 1)
			{
				if (char.IsDigit(e.KeyChar))
				{

					e.Handled = true;
				}
			}
		}

        private void tsmAddUser_Click(object sender, EventArgs e)
        {

			frmAddNewUser frmaddnewuser = new frmAddNewUser();
			frmaddnewuser.ShowDialog();
			LoadUsersDataIntoTheForm();
		}

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
             frmAddNewUser frmaddnewuser=new frmAddNewUser();
            frmaddnewuser.ShowDialog();
            LoadUsersDataIntoTheForm();

		}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmUpdateUserInfo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvUsers.CurrentCell.Value.ToString(), out int id))
            {
                frmAddNewUser frmaddnewuser = new frmAddNewUser(id);
                frmaddnewuser.ShowDialog();

            }
            
			LoadUsersDataIntoTheForm();
		}

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvUsers.CurrentCell.Value.ToString(), out int id))
            {
                clsUser.DeleteUser(id);

            }
            LoadUsersDataIntoTheForm();
        }

        private void grdvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.Button == MouseButtons.Right)
            {


                grdvUsers.CurrentCell = grdvUsers.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void tsmViewDetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvUsers.CurrentCell.Value.ToString(), out int id))
            {
                frmUserInfo frmUserInfo = new frmUserInfo(id);
                frmUserInfo.ShowDialog();

            }
           
        }

        private void grdvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
