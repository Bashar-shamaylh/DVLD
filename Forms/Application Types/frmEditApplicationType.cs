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
using static DVLDBussnissLayer.clsTestType;

namespace DVLD.Forms.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        private int _ApplicationTypeID;
        clsApplicationType ApplicationType;
        public frmEditApplicationType(int id)
        {
            InitializeComponent();
            _ApplicationTypeID = id;
            
        }
        private bool _ValidateTextBoxIsNullOrWhiteSpace(TextBox textBox, string Message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, Message);
                return true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
            return false;


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            ApplicationType.Title=txtboxTitle.Text;
            ApplicationType.Fees=Convert.ToSingle(txtboxFees.Text);
            if (ApplicationType.Save())
                MessageBox.Show("Test Type Info Was Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Faild To Update the Test Type with ID : " + _ApplicationTypeID + " .", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            ApplicationType=clsApplicationType.Find(_ApplicationTypeID);
            if(ApplicationType!=null)
            {
                lblApplicationTypeID.Text = ApplicationType.ID.ToString();
                txtboxTitle.Text = ApplicationType.Title.ToString();
                txtboxFees.Text = ApplicationType.Fees.ToString();
                return;
            }
           
        
        MessageBox.Show("Error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtboxTitle_Validating(object sender, CancelEventArgs e)
        {
            if(_ValidateTextBoxIsNullOrWhiteSpace(txtboxTitle,"Title Cannot Be Blank") )
                {
                e.Cancel = true;
                return;
                }
        }

        private void txtboxFees_Validating(object sender, CancelEventArgs e)
        {
            if (_ValidateTextBoxIsNullOrWhiteSpace(txtboxFees, "Fees Cannot Be Blank"))
            {
                e.Cancel = true;
                return;
            }
            if (!clsValidation.IsNumber(txtboxFees.Text))
            {
                e.Cancel = true;
                return;
            }
        }

      
    }
}
