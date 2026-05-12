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
        DataTable _dtPeople ;
        DataView _dvPeople ;
        public PeopleUI()
        {
            InitializeComponent();
        }

        private void PeopleUI_Load(object sender, EventArgs e)
        {
             
            _dtPeople = clsPerson.GetPeopleInfo();
            _dvPeople= new DataView(_dtPeople);
            grdvPeople.DataSource= _dtPeople;
            lblNumberOfRecordsResult.Text= _dtPeople.Rows.Count.ToString();
            cmbxFitlerItems.Items.Add("PersonID");  
            cmbxFitlerItems.Items.Add("FirstName");
            cmbxFitlerItems.Items.Add("SecondName");
            cmbxFitlerItems.Items.Add("ThirdName");
            cmbxFitlerItems.Items.Add("LastName");
            cmbxFitlerItems.Items.Add("NationalNumber");     
            cmbxFitlerItems.Items.Add("Phone");               
            cmbxFitlerItems.Items.Add("Email");
            cmbxFitlerItems.Items.Add("Nationality");          //................Update it later to string.............
            cmbxFitlerItems.Items.Add("Gender");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;

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
            else if(cmbxFitlerItems.SelectedIndex == 1 || cmbxFitlerItems.SelectedIndex == 2 || cmbxFitlerItems.SelectedIndex == 3 || cmbxFitlerItems.SelectedIndex == 4  )
            {
                if (char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;
                }
            }
            else if(cmbxFitlerItems.SelectedIndex == 9 )
            {
                if (e.KeyChar != 'M' && e.KeyChar != 'm' && e.KeyChar != 'F' && e.KeyChar != 'f' && e.KeyChar != (char)Keys.Back)
                {

                    e.Handled = true;
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim(); 

            // If the box is empty, reset the filter and STOP
            if (string.IsNullOrEmpty(filterText))
            {
                _dvPeople.RowFilter = "";
                return;
            }
            string ColumnName = cmbxFitlerItems.Text.Trim() ;
            if(cmbxFitlerItems.SelectedIndex==0 )
                _dvPeople.RowFilter = $"{ColumnName} = {filterText}";
            else if(cmbxFitlerItems.SelectedIndex == 9)
                _dvPeople.RowFilter = $"{ColumnName} = '{filterText}'";
            else
                _dvPeople.RowFilter = $"{ColumnName} LIKE '%{filterText}%'";

            grdvPeople.DataSource = _dvPeople;
        }
    }
}
