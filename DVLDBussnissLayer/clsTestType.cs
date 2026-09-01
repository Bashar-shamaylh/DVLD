using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public  class clsTestType
    {
        public enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode Mode = enMode.AddMode;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        public enTestType TestTypeID { get; set; }
        public string TestTypeName { get; set; }
        public float TestTypeFees { get; set; }
        public string TestTypeDescription { get; set; }
        clsTestType()
        {
            TestTypeID = clsTestType.enTestType.VisionTest;
            TestTypeName ="";
            TestTypeFees =0;
            TestTypeDescription = "";
            Mode = enMode.AddMode;
        }
        clsTestType(int testTypeID, string testTypeName, float testTypeFees, string testTypeDescription)
        {
            TestTypeID = clsTestType.enTestType.VisionTest;
            TestTypeName = testTypeName;
            TestTypeFees = testTypeFees;
            TestTypeDescription = testTypeDescription;
            Mode = enMode.UpdateMode;
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetTestTypesInfo();
        }
        private bool _Update()
        {
           return clsTestTypesDataAccess.Update((int)this.TestTypeID, TestTypeName,TestTypeFees,TestTypeDescription);
        }
        private bool _AddNew()
        {
            this.TestTypeID= (clsTestType.enTestType)clsTestTypesDataAccess.AddNew(TestTypeName, TestTypeFees, TestTypeDescription);
            return (this.TestTypeName != "");
        }
        public static clsTestType FindTestTypeByID(int testTypeID)
        {
           
            string TestTypeName = "";
            string TestTypeDescription = "";
            float TestTypeFees = 0;
            if (clsTestTypesDataAccess.Find(testTypeID, ref TestTypeName, ref TestTypeFees, ref TestTypeDescription))

                return new clsTestType(testTypeID, TestTypeName, TestTypeFees, TestTypeDescription);
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
