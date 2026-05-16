using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsCountry
    {
        public static DataTable GetCountriesInfo()
        {
            return clsCountriesDataAccess.GetCountriesInfo();
        }
    }
}
