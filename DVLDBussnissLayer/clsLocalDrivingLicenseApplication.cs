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
        public short PassedTests { get;private set; }
        public clsLicenseClass LicenseClassInfo;
       
        public clsApplicationType applicationType= clsApplicationType.Find(2);
        public clsLocalDrivingLicenseApplication()
        { 
            ApplicationID = -1;
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
             
           
            this.ApplicationDate= DateTime.Now;
            this.ApplicationState=enApplicationState.New;
            this.LastStatusDate = ApplicationDate;
            this.PaidFees=applicationType.Fees;
            

        }
        clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int LicenseClassID,int ApplicationID, int PersonID,
             DateTime ApplicationDate, enApplicationType ApplicationType, enApplicationState ApplicatoinStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID, short PassedTests = 0) :base(ApplicationID,PersonID, ApplicationDate, ApplicationType, ApplicatoinStatus, LastStatusDate,
                 PaidFees, CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo=clsLicenseClass.Find(LicenseClassID);
            this.PassedTests=PassedTests;
        }
        static public clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseID)
        {
            int LicenseClassID = -1;

            int ApplicationID = -1;
            int PersonID = -1;
            int ApplicationType = 2;
            int CreatedByUserID = -1;
            short ApplicationStatus = 1;
            DateTime ApplicatoinDate = DateTime.Now;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            short passedtests = 0;
            if(clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByID
                (LocalDrivingLicenseID, ref ApplicationID,ref LicenseClassID,ref passedtests))
                if (Find(ApplicationID, ref PersonID,
                 ref ApplicatoinDate, ref ApplicationType, ref ApplicationStatus,
                 ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseID,LicenseClassID,ApplicationID, PersonID,
              ApplicatoinDate, (enApplicationType)ApplicationType, (enApplicationState)ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return null;
        }


        private bool _AddNew()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(PersonID,
              ApplicationDate,(short) ApplicationType, (short)ApplicationState,
              LastStatusDate, PaidFees, CreatedByUserID);
            if (this.ApplicationID == -1)
                return false;
            LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
            
        }
        private bool _Update()
        {
            return (clsApplicationData.UpdateApplicatoinInfo(ApplicationID, PersonID,
              ApplicationDate,(short) ApplicationType, (short)ApplicationState,
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
            clsLocalDrivingLicenseApplication obj= Find(localDrivingLicenseApplicationID);
            return clsApplicationData.DeleteApplicatoin(obj.ApplicationID) &&clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(localDrivingLicenseApplicationID);
        }
        public static DataTable GetApplicationInfo()
        {
            return clsLocalDrivingLicenseApplicationData.GetApplicationsInfo();
        }
        public static bool isPersonHasApplicationWithLicenseClassID(int personID,int licenseClassID)
        {
            return clsLocalDrivingLicenseApplicationData.isPersonHasApplicationWithLicenseClassID (personID,licenseClassID);
        }

    }
}
