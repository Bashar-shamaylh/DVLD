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

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            //this
            ctrlFindPersonFilter1.DataBack += FindPerson;
        }
        public void FindPerson(Object sender, string SearchText, string SearchType)
        {
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
                clsPerson person;
                if (SearchType == "PersonID")
                {
                    person = clsPerson.Find(int.Parse(SearchText));

                }
                else
                    person = clsPerson.FindPersonByNationnalNum(SearchText);
                if (person != null)
                {
                    ctrlPersonInfo1.FillPersonInfoIntoTheForm(person);
                }

            }
        }

        private void ctrlFindPersonFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
