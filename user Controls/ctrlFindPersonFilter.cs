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
    public partial class ctrlFindPersonFilter : UserControl
    {
        public ctrlFindPersonFilter()
        {
            InitializeComponent();
        }
        public  delegate void DataBackEventHandler (object sender, string PersonInfo,string SearchType );
        public event DataBackEventHandler DataBack;
        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            DataBack?.Invoke(this,filterText,cmbxFitlerItems.SelectedItem.ToString());

        }

        private void ctrlFindPersonFilter_Load(object sender, EventArgs e)
        {
            cmbxFitlerItems.Items.Add("PersonID");
            cmbxFitlerItems.Items.Add("NationalNumber");
            cmbxFitlerItems.SelectedIndex = 0;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not programmed yet!");
        }
    }
}
