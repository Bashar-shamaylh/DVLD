using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsApplication
    {
        public enum enMode { AddMode = 1, UpdateMode }
        public enMode Mode = enMode.AddMode;

        public enum enApplicationState { New = 1, Completed=2,Canceled=3 }
        public enApplicationState ApplicationState = enApplicationState.New;


        public int      ApplicationID { get; set; }
        public int      PersonID { get; set; }
        public DateTime ApplicatoinDate { get; set; }
        public enApplicationState ApplicationStatus { get; set; }
        public int      ApplicationTypeID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float    PaidFees { get; set; }
        public int      CreatedByUserID { get; set; }
        
       
        public clsApplication()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationTypeID = -1;
            CreatedByUserID = -1;
            ApplicationStatus = enApplicationState.New;
            ApplicatoinDate = DateTime.Now;
            LastStatusDate= DateTime.Now;
            PaidFees = 0;
           
            Mode = enMode.AddMode;
        }
        clsApplication(int ApplicationID,int PersonID,
             DateTime ApplicatoinDate, int ApplicationTypeID, enApplicationState ApplicatoinStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.ApplicatoinDate = ApplicatoinDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicatoinStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
         
            Mode = enMode.UpdateMode;
        }
        static public clsApplication Find(int id)
        {


           int  ApplicationID = -1;
           int PersonID = -1;
           int ApplicationTypeID = -1;
           int CreatedByUserID = -1;
            short ApplicationStatus = 1;
           DateTime ApplicatoinDate = DateTime.Now;
           DateTime LastStatusDate = DateTime.Now;
           float PaidFees = -1;

            if (clsApplicationData.GetApplicationByID( ApplicationID, ref PersonID,
             ref ApplicatoinDate, ref ApplicationTypeID, ref ApplicationStatus,
             ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                
                return new clsApplication(ApplicationID,  PersonID,
              ApplicatoinDate,  ApplicationTypeID, (enApplicationState) ApplicationStatus,
              LastStatusDate,  PaidFees,  CreatedByUserID);
            return null;
        }
        
       
        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication( PersonID,
              ApplicatoinDate, ApplicationTypeID,(short) ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return this.ApplicationID != -1;
        }
        private bool _UpdatePersonInfo()
        {
            return clsApplicationData.UpdateApplicatoinInfo(ApplicationID, PersonID,
              ApplicatoinDate, ApplicationTypeID,(short) ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
        }
        public bool Save()
        {
            if (this.Mode == enMode.AddMode)
            {
                if (_AddNewApplication())
                {
                    this.Mode = enMode.UpdateMode;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (_UpdatePersonInfo())
                    return true;
                return false;
            }
        }
        public static bool Delete(int id)
        {
            return clsApplicationData.DeleteApplicatoin(id);
        }
        public static DataTable GetApplicationInfo()
        {
            return clsApplicationData.GetApplicationsInfo();
        }
        
    }
}
