using DVLDBussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms
{
    public partial class AddEditPersonInfoUI : Form
    {
        private bool _IsNationalNumExist(string nationalNum)
        {
            //Function to Check if the  National Number does exist in the database or not
            return clsPerson.isNationalNumberExist(nationalNum);
        }
        public AddEditPersonInfoUI()
        {
            InitializeComponent();
        }

        private void AddEditPersonInfoUI_Load(object sender, EventArgs e)
        {
            //Prevent the user to enter a Date Less than 18 years
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            //Load all the Countries

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNationalNum_MouseLeave(object sender, EventArgs e)
        {
                //Check if the National Number exist if The check box isn't empty             --Update this later in Case Update Person Info
                if (_IsNationalNumExist(txtBoxNationalNum.Text)&& txtBoxNationalNum.Text.Length > 0) 
                    errorProvider1.SetError(txtBoxNationalNum, "This Number is already used");
                
        }
    }
}
