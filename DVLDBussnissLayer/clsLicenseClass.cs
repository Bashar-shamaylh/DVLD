using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsLicenseClass
    {

        public enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode Mode = enMode.AddMode;
        public int ID { get; set; }
        public string  ClassName { get; set; }
        public string Description { get; set; }
        public int MinimumAgeAllowed { get; set; }
        public float Fees { get; set; }
        public int ValidityLength { get; set; }
        public static DataTable GetAllData()
        {
            return clsLicenseClassesData.GetAllLicenseCalsses();
        }

        clsLicenseClass()
        {
            ID = -1;
            ClassName = "";
            Description = "";
            MinimumAgeAllowed = 0;
            ValidityLength = 0;
            Fees = 0;
            Mode = enMode.AddMode;
        }
        clsLicenseClass(int licenseclassid, string classname, string description, int minimumallowedage, float fees, int validitylength)
        {
            ID = licenseclassid;
            ClassName= classname;
            Description = description;
            MinimumAgeAllowed = minimumallowedage;
            Fees = fees;
            ValidityLength= validitylength;

          Mode = enMode.UpdateMode;
        }

        private bool _Update()
        {
            return clsLicenseClassesData.Update(ID,ClassName,Description,MinimumAgeAllowed,Fees,ValidityLength);
        }
        private bool _AddNew()
        {
            this.ID = clsLicenseClassesData.AddNew(ClassName, Description, MinimumAgeAllowed, Fees, ValidityLength);
            return (this.ID != -1);
        }
        public static clsLicenseClass Find(int licenseclassid)
        {

            string classname = "";
            string description = "";
            int minimumallowedage = -1;
            float fees = 0;
            int validitylength = -1;
            
            if (clsLicenseClassesData.Find(licenseclassid, ref classname, ref description, ref minimumallowedage, ref fees, ref validitylength))

                return new clsLicenseClass(licenseclassid,  classname,  description,  minimumallowedage,  fees,  validitylength);
            else return null;
        }
        public bool Save()
        {
            if (this.Mode == enMode.AddMode)
            {
                if (_AddNew())
                {
                    this.Mode = enMode.UpdateMode;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (_Update())
                    return true;
                return false;
            }
        }
    }
}
