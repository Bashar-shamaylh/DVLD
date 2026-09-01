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


namespace DVLD.Forms.Test_Types
{
    public partial class frmUpdateTestType : Form
    {
        private int _TestTypeID;
        private clsTestType _TestType;
        public frmUpdateTestType(int ID)
        {
            InitializeComponent();
            _TestTypeID = ID;
        }
        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _TestType=clsTestType.FindTestTypeByID(_TestTypeID);
            if (_TestType != null)
            {
                lblID.Text = _TestTypeID.ToString();
                textBox1.Text = _TestType.TestTypeName;
                textBox2.Text = _TestType.TestTypeDescription;
                textBox3.Text = Convert.ToString(_TestType.TestTypeFees);
                return;
            }
            MessageBox.Show("Error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!ValidateChildren())
                return;
            _TestType.TestTypeName = textBox1.Text.Trim();
            _TestType.TestTypeDescription= textBox2.Text.Trim();
            _TestType.TestTypeFees = Convert.ToSingle(textBox3.Text.Trim());
            if (_TestType.Save())
            MessageBox.Show("Test Type Info Was Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Faild To Update the Test Type with ID : "+_TestTypeID+" .", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(_ValidateTextBoxIsNullOrWhiteSpace(textBox1, "Title Cannot be blank"))
            {
                e.Cancel = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
           if( _ValidateTextBoxIsNullOrWhiteSpace(textBox2, "Description Cannot be blank"))
            {
                e.Cancel = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if(_ValidateTextBoxIsNullOrWhiteSpace(textBox3, "Fees Cannot be blank"))
            {
                e.Cancel = true;
            }
        }

        
    }
}
