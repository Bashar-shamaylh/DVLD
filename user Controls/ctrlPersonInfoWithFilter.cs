using DVLD.Forms;
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
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        private bool _ShowAddPerson = true;
        public bool ShowPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
               
            }
        }
        private bool _FilterEnabeld = true;
        public bool FilterEnabeld
        {
            get
            {
                return _FilterEnabeld;
            }
            set { _FilterEnabeld= value;
                grbFilter.Enabled = _FilterEnabeld; }
        }
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
            
        }
        private int _PersonID;
        public int PersonID
        {
            get { return ctrlPersonInfo1.PersonID; }
         
        }
        private clsPerson person;
        public clsPerson Person
        {
            get { return ctrlPersonInfo1.SelectedPersonInfo; }
        }
        public void LoadPersonInfo(int PersonID)
        {
            cmbxFitlerItems.SelectedIndex = 0;
            txtSearch.Text=PersonID.ToString();
            FindPerson();
        }
     
       
   
       
        //this is my first attempt
        

       
        public void FindPerson()
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
                if (OnPersonSelected!=null&&FilterEnabeld)
                {
                    OnPersonSelected(ctrlPersonInfo1.PersonID);
                }

            }
        }

  


        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonInfoUI frm = new AddEditPersonInfoUI();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender,int PersonID)
        {
            cmbxFitlerItems.SelectedIndex=0;
            txtSearch.Text=PersonID.ToString();
            ctrlPersonInfo1.LoadPersonInfo(PersonID);
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Error", "some feilds are not valid");
                return;

            }
            FindPerson();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFindPerson.PerformClick();
            }
            if(cmbxFitlerItems.SelectedIndex==0)
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }

        private void cmbxFitlerItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cmbxFitlerItems.Items.Add("PersonID");
            cmbxFitlerItems.Items.Add("NationalNumber");
            cmbxFitlerItems.SelectedIndex = 0;
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            cmbxFitlerItems.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSearch, "this feild is required");

            }
            errorProvider1.SetError(txtSearch, null);
        }
    }
}
