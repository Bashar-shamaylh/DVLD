using DVLD.Forms.Users;
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
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
            
        }
        public void ctrlFindPersonFilter1_Load(int PersonID = -1)
        {
            if (PersonID != -1)
                ctrlPersonInfo1.LoadPersonInfo(PersonID);
        }
        //this is my first attempt
        //this is my first attempt
        //this is my first attempt
        //this is my first attempt
        //this is my first attempt
        //this is my first attempt
        //this is my first attempt
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action <int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        //this is my first attempt
        public clsPerson person;
        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }

       
        private void _FindPerson()
        {
            string SearchText=txtSearch.Text,  SearchType=cmbxFitlerItems.Text;
            if (SearchText == null)
            {
                MessageBox.Show("Invalid ID or National Number");
            }
            else if (SearchType == null)
            {
                MessageBox.Show("Invalid ID or National Number");
            }
            else
            {
                
                if (SearchType == "PersonID")
                {
                    ctrlPersonInfo1.LoadPersonInfo(int.Parse(SearchText));

                }
                else
                    ctrlPersonInfo1.LoadPersonInfo(SearchText);
                if (OnPersonSelected!=null)
                {
                    OnPersonSelected(ctrlPersonInfo1.PersonID);
                }

            }
        }

        private void ctrlFindPersonFilter1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            _FindPerson();
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

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cmbxFitlerItems.Items.Add("PersonID");
            cmbxFitlerItems.Items.Add("NationalNumber");
            cmbxFitlerItems.SelectedIndex = 0;
        }
    }
}
