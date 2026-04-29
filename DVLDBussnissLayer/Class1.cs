using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer
namespace DVLDBussnissLayer
{
    public class clsPearson
    {
        public int ID { get; }
        public string Name { get; set; }


        

        clsPearson() {
            ID = 0;
            Name = "";

        }
       public string Find(int id)
        {
            string Name = "";
            if (clsPeopleDataAccess.GetPearsonByID(id, ref Name))
                return Name;
            else
            {
                return "";
            }

        }

    }
}
