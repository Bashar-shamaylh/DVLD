using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsTest
    {


        public enum enMode { AddMode = 1, UpdateMode }
        public enMode Mode = enMode.AddMode;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public int Trial { get; set; }   //number of faild Tests for an appointment


        public clsTest()
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = "";
            CreatedByUserID = 0; 
            Mode = enMode.AddMode;
        }
        clsTest(int id,int testappointmentid,bool testresult,string notes,int createdbyuserid)
        {
            TestID = id;
            TestAppointmentID = testappointmentid;
            TestResult = testresult;
            Notes = notes;
            CreatedByUserID = createdbyuserid;

            Mode = enMode.UpdateMode;
        }
        static public clsTest Find(int id)
        {


            
            int testappointmentid=0;
            bool testresult=false;
            string notes="";
            int createdbyuserid = 0;

            if (clsTestsData.GetTestByID(id,ref testappointmentid,ref testresult,ref notes,ref createdbyuserid))
                return new clsTest(id,  testappointmentid,  testresult,  notes,  createdbyuserid);
            return null;
        }
        
        
        private bool _AddNew()
        {
            this.TestID = clsTestsData.AddTest(TestAppointmentID,TestResult,Notes,CreatedByUserID);
            return this.TestID != -1;
        }
        private bool _Update()
        {
            return clsTestsData.UpdateTestInfo(TestID,TestAppointmentID, TestResult, Notes, CreatedByUserID);
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
            return clsTestsData.DeleteTest(id);
        }
        public static DataTable GetTestsInfo()
        {
            //return clsTestsData.get();
            return null;
        }
    }
}
