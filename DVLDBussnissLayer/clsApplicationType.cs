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
        public enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode Mode = enMode.AddMode;
        public int ID {  get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }
        public static DataTable GetAllData()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }
       
        clsApplicationType()
        {
            ID = -1;
            Title = "";
            Fees = 0;
            
            Mode = enMode.AddMode;
        }
        clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationTypeFees)
        {
            ID = ApplicationTypeID;
            Title = ApplicationTypeTitle;
            Fees = ApplicationTypeFees;

            Mode = enMode.UpdateMode;
        }
      
        private bool _Update()
        {
            return clsApplicationTypesDataAccess.Update(this.ID, Title, Fees);
        }
        private bool _AddNew()
        {
            this.ID = clsApplicationTypesDataAccess.AddNew(Title, Fees);
            return (this.Title != "");
        }
        public static clsApplicationType Find(int applicationtypeid)
        {

            string ApplicationTypeTitle = "";
            
            float ApplicationTypeFees = 0;
            if (clsApplicationTypesDataAccess.Find(applicationtypeid, ref ApplicationTypeTitle, ref ApplicationTypeFees))

                return new clsApplicationType(applicationtypeid, ApplicationTypeTitle, ApplicationTypeFees);
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
