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
            
            
            _dtPeople = clsPearson.GetPeopleInfo();
            _dvPeople= new DataView(_dtPeople);
            grdvPeople.DataSource= _dtPeople;
            lblNumberOfRecordsResult.Text= _dtPeople.Rows.Count.ToString();
            cmbxFitlerItems.Items.Add("Person ID");  //number
            cmbxFitlerItems.Items.Add("First Name");
            cmbxFitlerItems.Items.Add("Second Name");
            cmbxFitlerItems.Items.Add("Third Name");
            cmbxFitlerItems.Items.Add("Last Name");
            cmbxFitlerItems.Items.Add("National Number");     //number
            cmbxFitlerItems.Items.Add("Phone");               //number
            cmbxFitlerItems.Items.Add("Email");
            cmbxFitlerItems.Items.Add("Country ID");          //number
            cmbxFitlerItems.Items.Add("Gendor");
            
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

           
            switch (cmbxFitlerItems.SelectedIndex)

            {
                case 0:
                    if (char.IsLetter(e.KeyChar))
                    {
                        // Set Handled to true to "cancel" the event and block the character
                        e.Handled = true;
                    }
                    
                    break;
                case 1:
                    if (char.IsDigit(e.KeyChar))
                    {
                        // Set Handled to true to "cancel" the event and block the character
                        e.Handled = true;
                    }
                    
                        break;
                case 2:
                    if (char.IsDigit(e.KeyChar))
                    {
                        // Set Handled to true to "cancel" the event and block the character
                        e.Handled = true;
                    }
                   
                    break;
                case 3:
                    if (char.IsDigit(e.KeyChar))
                    {
                        
                        e.Handled = true;
                    }
                    
                
                    break;
                case 4:
                    if (char.IsDigit(e.KeyChar))
                    {
                        
                        e.Handled = true;
                    }
            
                    break;
                case 5:
                    if (char.IsLetter(e.KeyChar))
                    {
                        
                        e.Handled = true;
                    }
    
                    break;
                case 6:
                    if (char.IsLetter(e.KeyChar))
                    {
                        
                        e.Handled = true;
                    }
             
                    break;
                case 7:
            
                    break;
                case 8:
                    if (char.IsLetter(e.KeyChar))
                    {
                        
                        e.Handled = true;
                    }
               
                    break;
                case 9:
                    if (e.KeyChar != 'M' && e.KeyChar != 'm' && e.KeyChar != 'F' && e.KeyChar != 'f' && e.KeyChar != (char)Keys.Back)
                    {
                        
                        e.Handled = true;
                    }
             
                        break;
                default:
                    break;
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
            
            switch (cmbxFitlerItems.SelectedIndex)

            {
                case 0:

                    
                    _dvPeople.RowFilter = $"PearsonID = {filterText}";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 1:


                 
                   
                    _dvPeople.RowFilter = $"FirstName LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 2:



                   
                    _dvPeople.RowFilter = $"SecondName LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 3:

                  
                    _dvPeople.RowFilter = $"ThirdName LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 4:


                   
                    _dvPeople.RowFilter = $"LastName LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 5:

               
                    _dvPeople.RowFilter = $"NationalNumber LIKE '%{filterText}%'"; //
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 6:

                 
                    _dvPeople.RowFilter = $"Phone LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 7:
               
                    _dvPeople.RowFilter = $"Email LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;
                    break;
                case 8:

              
                    _dvPeople.RowFilter = $"CountryID LIKE '%{filterText}%'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                case 9:

                    filterText=filterText.ToUpper();
                    _dvPeople.RowFilter = $"Gendor ='{filterText}'";
                    grdvPeople.DataSource = _dvPeople;

                    break;
                default:
                    break;
            }
        }
    }
}
