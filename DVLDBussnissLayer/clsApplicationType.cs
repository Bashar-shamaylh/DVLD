using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsApplicationType
    {
        public int ID {  get; set; }
        public string Title { get; set; }
        public float fees { get; set; }
        public static DataTable GetAllData()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }
        public static bool Update(int id, string title, float fees)
        {
           return clsApplicationTypesDataAccess.Update(id, title, fees);
        }
    }
}
