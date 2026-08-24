using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        DataTable _dtUsers =clsUser.GetUsersInfo();
       
        public void Reffresh()
        {
            _dtUsers = clsUser.GetUsersInfo();
            grdvUsers.DataSource = _dtUsers;
            lblNumberOfRecordsResult.Text = _dtUsers.Rows.Count.ToString();
            
            if (grdvUsers.Rows.Count > 0)
            {
                grdvUsers.Columns[0].HeaderText = "User ID";
                grdvUsers.Columns[0].Width = 70;

                grdvUsers.Columns[1].HeaderText = "Person ID";
                grdvUsers.Columns[1].Width = 80;

                grdvUsers.Columns[2].HeaderText = "Full Name";
                grdvUsers.Columns[2].Width = 200;

                grdvUsers.Columns[3].HeaderText = "User Name";
                grdvUsers.Columns[3].Width = 110;

                

                grdvUsers.Columns[4].HeaderText = "Is Active";
                grdvUsers.Columns[4].Width = 110;

            }
        }
        public void ApplyFilter()
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }


            string ColumnName = cmbxFitlerItems.Text.Trim();
            switch (cmbxFitlerItems.Text)
            {
                case "User ID":
                    ColumnName = "UserID";
                    break;
                case "Person ID":
                    ColumnName = "PersonID";
                    break;
                case "User Name":
                    ColumnName = "UserName";
                    break;
                case "Full Name":
                    ColumnName = "FullName";
                    break;
                case "Is Active":
                    break;

                default:
                    break;
            }

                if (ColumnName == "UserID" || ColumnName == "PersonID")
                _dtUsers.DefaultView.RowFilter = $"{ColumnName} = {txtSearch.Text.Trim()}";
                else if (ColumnName == "UserName" || ColumnName == "FullName")
                _dtUsers.DefaultView.RowFilter = $"{ColumnName} Like '%{txtSearch.Text.Trim()}%'";
                else
                _dtUsers.DefaultView.RowFilter = "";
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {

            Reffresh();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbxFitlerItems.Text == "Is Active")
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

			if (cmbxFitlerItems.SelectedIndex == 0 || cmbxFitlerItems.SelectedIndex == 1)
			{
				if (char.IsLetter(e.KeyChar))
				{
					
					e.Handled = true;
				}

			}
			else if (cmbxFitlerItems.SelectedIndex == 2|| cmbxFitlerItems.SelectedIndex == 3)
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
			Reffresh();
		}

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
             frmAddNewUser frmaddnewuser=new frmAddNewUser();
            frmaddnewuser.ShowDialog();
            Reffresh();

		}

   

        private void tsmUpdateUserInfo_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(grdvUsers.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                if (id != 0)
                {
                    frmAddNewUser frmaddnewuser = new frmAddNewUser(id);
                    frmaddnewuser.ShowDialog();
                    Reffresh();
                }
                

            }

            
		}

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvUsers.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                clsUser.DeleteUser(id);

            }
            Reffresh();
        }

   

        private void tsmViewDetails_Click(object sender, EventArgs e)
        {
            if (int.TryParse(grdvUsers.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                frmUserInfo frmUserInfo = new frmUserInfo(id);
                frmUserInfo.ShowDialog();

            }
           
        }
        private void cmbxIsActiveOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxIsActiveOptions.Text)
            {
                case "Yes":
                    _dtUsers.DefaultView.RowFilter = $"{"isActive"} = {1}";
                    break;
                case "No":
                    _dtUsers.DefaultView.RowFilter = $"{"isActive"} = {0}";
                    break;

                default:
                    _dtUsers.DefaultView.RowFilter = "";
                    break;
            }
        }
    }
}
