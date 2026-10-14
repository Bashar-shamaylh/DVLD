using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsTestAppointment
    {
        public enum enMode { AddMode = 1, UpdateMode }
        public enMode Mode = enMode.AddMode;
        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int TestTypeID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = 0;
            LocalDrivingLicenseApplicationID = 0;
            
            AppointmentDate= DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            TestTypeID = 0;
            IsLocked = false;
            
            
            Mode = enMode.AddMode;
        }
        clsTestAppointment( int testappointmentid, int localdrivinglicenseapplicationid, DateTime appointmentdate, float paidfees,int createdbyuserid, int testtypeid, bool islocked)
        {
             
            TestAppointmentID = testappointmentid;
            LocalDrivingLicenseApplicationID = localdrivinglicenseapplicationid;
            AppointmentDate = appointmentdate;
            PaidFees = paidfees;
            CreatedByUserID = createdbyuserid;
            TestTypeID = testtypeid;
            IsLocked = islocked;
            

            Mode = enMode.UpdateMode;
        }
        static public clsTestAppointment Find(int id)
        {

            int testappointmentid = 0;
            int localdrivinglicenseapplicationid = 0;
            DateTime appointmentdate=DateTime.Now;
            float paidfees = 0;
            int createdbyuserid=0;
            int testtypeid=0;
            bool islocked = false;

            if (clsTestAppointmentData.GetTestAppointmentByID(id,ref localdrivinglicenseapplicationid,ref appointmentdate, ref createdbyuserid, ref paidfees,ref testappointmentid,ref islocked))
                return new clsTestAppointment(id,  localdrivinglicenseapplicationid, appointmentdate,paidfees,  createdbyuserid  ,  testappointmentid,  islocked);
            return null;
        }


        private bool _AddNew()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(LocalDrivingLicenseApplicationID,AppointmentDate,CreatedByUserID,PaidFees,TestTypeID,IsLocked);
            return this.TestAppointmentID != -1;
        }
        private bool _Update()
        {
            return clsTestAppointmentData.UpdateTestAppointmentInfo(TestAppointmentID, LocalDrivingLicenseApplicationID, AppointmentDate, CreatedByUserID, PaidFees, TestTypeID, IsLocked);
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
        public static bool Delete(int id)
        {
            return clsTestAppointment.Delete(id);
        }
        public static DataTable GetTestAppointmentsInfo()
        {
            //return clsTestsData.get();
            return null;
        }
    }
}
