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
        
        
        public int LocalDrivingLicenseApplicationID {  get; set; }
        
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            ApplicationID = -1;
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
          //  Mode = clsApplication.enMode.AddMode;

        }
        clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int LicenseClassID,int ApplicationID, int PersonID,
             DateTime ApplicationDate, int ApplicationTypeID, enApplicationState ApplicatoinStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID) :base(ApplicationID,PersonID, ApplicationDate, ApplicationTypeID, ApplicatoinStatus, LastStatusDate,
                 PaidFees, CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

          //  Mode = clsApplication.enMode.UpdateMode;
        }
        static public clsLocalDrivingLicenseApplication FindLocalDrvingLicenseApp(int LocalDrivingLicenseID)
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


        private bool _AddNew()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(PersonID,
              ApplicatoinDate, ApplicationTypeID, (short)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            if (this.ApplicationID == -1)
                return false;
            LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
            
        }
        private bool _Update()
        {
            return (clsApplicationData.UpdateApplicatoinInfo(ApplicationID, PersonID,
              ApplicatoinDate, ApplicationTypeID, (short)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID)&&
              clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication
              (this.LocalDrivingLicenseApplicationID,this.ApplicationID,this.LicenseClassID));
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
        public static bool Delete(int localDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication obj= FindLocalDrvingLicenseApp(localDrivingLicenseApplicationID);
            return clsApplicationData.DeleteApplicatoin(obj.ApplicationID) &&clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(localDrivingLicenseApplicationID);
        }
        public static DataTable GetApplicationInfo()
        {
            return clsLocalDrivingLicenseApplicationData.GetApplicationsInfo();
        }

    }
}
