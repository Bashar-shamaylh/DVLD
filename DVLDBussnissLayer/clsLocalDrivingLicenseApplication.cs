using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsLocalDrivingLicenseApplication :clsApplication
    {
        
        private clsApplication.enMode _Mode= clsApplication.enMode.AddMode;
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID {  get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            ApplicationID = -1;
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;


            
        }
        clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int LicenseClassID,int ApplicationID, int PersonID,
             DateTime ApplicationDate, int ApplicationTypeID, enApplicationState ApplicatoinStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID) :base(ApplicationID,PersonID, ApplicationDate, ApplicationTypeID, ApplicatoinStatus, LastStatusDate,
                 PaidFees, CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

            _Mode = clsApplication.enMode.UpdateMode;
        }
        static public clsApplication FindLocalDrvingLicenseApp(int LocalDrivingLicenseID)
        {
            int LicenseClassID = -1;

            int ApplicationID = -1;
            int PersonID = -1;
            int ApplicationTypeID = -1;
            int CreatedByUserID = -1;
            short ApplicationStatus = 1;
            DateTime ApplicatoinDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            if(clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseID, ref ApplicationID,ref LicenseClassID))
                if (Find(ApplicationID, ref PersonID,
                 ref ApplicatoinDate, ref ApplicationTypeID, ref ApplicationStatus,
                 ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseID,LicenseClassID,ApplicationID, PersonID,
              ApplicatoinDate, ApplicationTypeID, (enApplicationState)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return null;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(PersonID,
              ApplicatoinDate, ApplicationTypeID, (short)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return this.ApplicationID != -1;
        }
        private bool _UpdatePersonInfo()
        {
            return clsApplicationData.UpdateApplicatoinInfo(ApplicationID, PersonID,
              ApplicatoinDate, ApplicationTypeID, (short)ApplicationStatus,
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
