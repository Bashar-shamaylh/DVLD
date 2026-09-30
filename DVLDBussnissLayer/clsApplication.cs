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
        protected enApplicationState ApplicationState = enApplicationState.New;

        public enum enApplicationType {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        }
        protected enApplicationType ApplicationType = enApplicationType.NewDrivingLicense;

        public int      ApplicationID { get; set; }
        public int      PersonID { get; set; }
        public clsPerson PersonInfo;
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType ApplicationTypeInfo;
        public int      ApplicationTypeID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float    PaidFees { get; set; }
        public int      CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;
       
        public clsApplication()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationTypeID = -1;
            CreatedByUserID = -1;
            
            ApplicationState = enApplicationState.New;
            ApplicationDate = DateTime.Now;
            LastStatusDate= DateTime.Now;
            PaidFees = 0;
           
            Mode = enMode.AddMode;
        }
       protected clsApplication(int ApplicationID,int PersonID,
             DateTime ApplicatoinDate, int ApplicationTypeID, enApplicationState ApplicatoinState,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.ApplicationTypeInfo=clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationDate = ApplicatoinDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationState = ApplicatoinState;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo=clsUser.Find(this.CreatedByUserID);
            Mode = enMode.UpdateMode;
        }
        static public clsApplication FindBaseApplication(int id)
        {


            int ApplicationID = -1;
            int PersonID = -1;
            int ApplicationTypeID = -1;
            int CreatedByUserID = -1;
            short ApplicationStatus = 1;
            DateTime ApplicatoinDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;

            if (clsApplicationData.GetApplicationByID(ApplicationID, ref PersonID,
             ref ApplicatoinDate, ref ApplicationTypeID, ref ApplicationStatus,
             ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

                return new clsApplication(ApplicationID, PersonID,
              ApplicatoinDate, ApplicationTypeID, (enApplicationState)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return null;
        }
        static public bool Find(int ApplicationID,ref int  PersonID, ref DateTime ApplicatoinDate, ref  int ApplicationTypeID, ref short ApplicationStatus,
             ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {



            if (clsApplicationData.GetApplicationByID(ApplicationID, ref PersonID,
             ref ApplicatoinDate, ref ApplicationTypeID, ref ApplicationStatus,
             ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

                return true;
            return false;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication( PersonID,
              ApplicationDate, ApplicationTypeID,(short) ApplicationState,
              LastStatusDate, PaidFees, CreatedByUserID);
            return this.ApplicationID != -1;
        }
        private bool _UpdateApplicationInfo()
        {
            return clsApplicationData.UpdateApplicatoinInfo(ApplicationID, PersonID,
              ApplicationDate, ApplicationTypeID,(short) ApplicationState,
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
                if (_UpdateApplicationInfo())
                    return true;
                return false;
            }
        }
        public static bool Delete(int id)
        {
            return clsApplicationData.DeleteApplicatoin(id);
        }
        public bool Cancel() { return clsApplicationData.UpdateApplicationState(this.ApplicationID, 3); }
        public bool SetComplete() { return clsApplicationData.UpdateApplicationState(this.ApplicationID, 2); }
        public static DataTable GetApplicationInfo()
        {
            return clsApplicationData.GetApplicationsInfo();
        }
       
        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationData.isApplicationExist(ApplicationID);
        }
        public  bool DoesPersonHaveActiveApplication(int ApplicationID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(this.PersonID, ApplicationID);
        }
        public static bool DoesPersonHaveActiveApplication(int PersonID,int ApplicationID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationID);
        }
        public  int GetActiveApplicationID( clsApplication.enApplicationType applicationType)
        {
            return clsApplicationData.GetActiveApplicationID(this.PersonID,(int) applicationType);
        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType applicationType,int LicneseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)applicationType, LicneseClassID);
        }
    }
}
