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

namespace DVLD.Forms
{
    public partial class PeopleUI : Form
    {
       private static DataTable _dtAllPeople=clsPerson.GetPeopleInfo() ;
        private static DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNumber", "FirstName",
                                                    "SecondName", "ThirdName", "LastName", "GenderCatption",
                                                     "Phone","Email", "CountryName", "DateOfBirth");
     
        public PeopleUI()
        {
            InitializeComponent();    
        }

        private void PeopleUI_Load(object sender, EventArgs e)
        {
            grdvPeople.DataSource = _dtPeople;
            lblNumberOfRecordsResult.Text = _dtPeople.Rows.Count.ToString();
            cmbxFitlerItems.SelectedIndex = 0;
            if (grdvPeople.Rows.Count > 0)
            {
                {
                    grdvPeople.Columns[0].HeaderText = "Person ID";
                    grdvPeople.Columns[0].Width = 110;

                    grdvPeople.Columns[1].HeaderText = "National Number";
                    grdvPeople.Columns[1].Width = 110;

                    grdvPeople.Columns[2].HeaderText = "First Name";
                    grdvPeople.Columns[2].Width = 110;

                    grdvPeople.Columns[3].HeaderText = "Second Name";
                    grdvPeople.Columns[3].Width = 120;

                    grdvPeople.Columns[4].HeaderText = "Third Name";
                    grdvPeople.Columns[4].Width = 120;

                    grdvPeople.Columns[5].HeaderText = "Last Name";
                    grdvPeople.Columns[5].Width = 120;

                    grdvPeople.Columns[6].HeaderText = "Gender";
                    grdvPeople.Columns[6].Width = 110;



                    grdvPeople.Columns[7].HeaderText = "Phone";
                    grdvPeople.Columns[7].Width = 110;

                    grdvPeople.Columns[8].HeaderText = "Email";
                    grdvPeople.Columns[8].Width = 120;

                    grdvPeople.Columns[9].HeaderText = "Country Name";
                    grdvPeople.Columns[9].Width = 110;

                    grdvPeople.Columns[10].HeaderText = "Date of Birth";
                    grdvPeople.Columns[10].Width = 120;



                }
            }
            }

        private void _RefreshPeopleList()
        {
              _dtAllPeople = clsPerson.GetPeopleInfo();
         _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNumber", "FirstName",
                                                    "SecondName", "ThirdName", "LastName", "GenderCatption",
                                                     "Phone", "Email", "CountryName", "DateOfBirth");
            grdvPeople.DataSource = _dtPeople;
            lblNumberOfRecordsResult.Text = _dtPeople.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxFitlerItems.Text!="None")
                txtSearch.Visible = true;
            else
                txtSearch.Visible = false;
            //txtSearch.Visible=(cmbxFilterItems.Text==None);
            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbxFitlerItems.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = "";
            switch (cmbxFitlerItems.SelectedItem)
            {
                case "Person ID":
                    filterText = "PersonID";
                    break;
                case "National Number":
                    filterText = "NationalNumber";
                    break;
                case "First Name":
                    filterText = "FirstName";
                    break;
                case "Second Name":
                    filterText = "SecondName";
                    break;
                case "Third Name":
                    filterText = "ThirdName";
                    break;
                case "Last Name":
                    filterText = "LastName";
                    break;
                case "Gender":
                    filterText = "GenderCatption";
                    break;
                case "Phone":
                    filterText = "Phone";
                    break;
                case "Email":
                    filterText = "Email";
                    break;
                case "Country Name":
                    filterText = "CountryName";
                    break;
                case "Date Of Birth":
                    filterText = "DateOfBirth";
                    break;

                default :
                    break;
            }
            if(filterText==""||cmbxFitlerItems.Text=="None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblNumberOfRecordsResult.Text = _dtPeople.Rows.Count.ToString();
                return;
            }
            if (filterText == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterText, txtSearch.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter=string.Format("[{0}] Like '{1}%'",filterText, txtSearch.Text.Trim());
            lblNumberOfRecordsResult.Text = _dtPeople.Rows.Count.ToString();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form form = new AddEditPersonInfoUI();
            form.ShowDialog();
            _RefreshPeopleList();
        }

        private void lblManagePeople_Click(object sender, EventArgs e)
        {

        }

        private void tsmAddPerson_Click(object sender, EventArgs e)
        {
            Form form = new AddEditPersonInfoUI();
            form.ShowDialog();
            _RefreshPeopleList();

        }

        private void tsmUpdatePersonInfo_Click(object sender, EventArgs e)
        {


           
                Form form = new AddEditPersonInfoUI((int)grdvPeople.CurrentRow.Cells[0].Value);
                form.ShowDialog();
            
            _RefreshPeopleList();

        }

        private void grdvPeople_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

         
        }

        private void tsmViewDetails_Click(object sender, EventArgs e)
        {
                frmPersonInfo frmPersonInfo = new frmPersonInfo((int)grdvPeople.CurrentRow.Cells[0].Value);
                frmPersonInfo.ShowDialog();
                
            
            
        }

        private void tsmDeletePerson_Click(object sender, EventArgs e)
        {
           
                clsPerson.DeletePerson((int)grdvPeople.CurrentRow.Cells[0].Value);

            
            _RefreshPeopleList();

        }
    }
}
