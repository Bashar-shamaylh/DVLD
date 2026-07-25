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
        public int CountryID{ get; set; }
        public string CountryName{ get; set; }

        public static DataTable GetCountriesInfo()
        {
            return clsCountriesDataAccess.GetCountriesInfo();
        }
        clsCountry(int countryID,string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
        clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }
        public static clsCountry Find(int CountryId)
        {
            string countryName = "";
               if(clsCountriesDataAccess.GetCountryById(CountryId,ref countryName))
            {
                return new clsCountry(CountryId,countryName);
            }
            return null;
        }
        public static clsCountry Find(string countryName)
        {
            int CountryId = -1;
            if (clsCountriesDataAccess.GetCountryByName(ref CountryId,  countryName))
            {
                return new clsCountry(CountryId, countryName);
            }
            return null;
        }
    }
}
