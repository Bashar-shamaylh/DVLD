using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVLDDataAccessLayer;
namespace DVLDBussnissLayer
{
    public class clsPearson
    {
       public enum enMode { AddMode=1,UpdateMode}
        public enMode Mode = enMode.AddMode;
        public int ID { get; set; }
        public string Name { get; set; }
        public string NationnalNumber {  get; set; }
        public string Address {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID {  get; set; }
        public string PersonalImage { get; set; }

        clsPearson() {
            ID = 0;
            Name = "";
            NationnalNumber = "";
            Address = "";
            Phone = "";
            Email = "";
            DateOfBirth = DateTime.Now;
            CountryID = -1;
            PersonalImage = null;
        }
        clsPearson(int id,string name,string nationalnumber, DateTime dateofbirth, string address,string phone,string email,int countryid,string personalimage)
        {
            ID = id;
            Name = name;
            NationnalNumber = nationalnumber;
            Address = address;
            Phone = phone;
            Email = email;
            DateOfBirth = dateofbirth;
            CountryID = countryid;
            PersonalImage = personalimage;
        }
        static public clsPearson Find(int id)
        {
           
           
           string Name = "";
           string NationnalNumber = "";
            string Address = "";
            string Phone = "";
            string Email = "";
           DateTime DateOfBirth = DateTime.Now;
           int CountryID = -1;
            string PersonalImage = null;
            if (clsPeopleDataAccess.GetPearsonByID(id,ref Name,ref NationnalNumber, ref DateOfBirth, ref Address,ref Phone,ref Email,ref CountryID,ref PersonalImage))
               return new clsPearson(id,Name,NationnalNumber,DateOfBirth,Address,Phone,Email,CountryID,PersonalImage);
            return null;        
        }
         private bool _AddNewPerson()
        {
            this.ID=clsPeopleDataAccess.AddNewPerson(NationnalNumber,Name,DateOfBirth, Address,Phone,Email,CountryID,PersonalImage);
            return this.ID!=-1;
        }
        private bool _UpdatePearsonInfo()
        {
            return clsPeopleDataAccess.UpdatePersonInfo(this.ID, NationnalNumber, Name, DateOfBirth, Address, Phone, Email, CountryID, PersonalImage);
        }
        public bool Save()
        {
            if (this.Mode == enMode.AddMode)
            {
                if (_AddNewPerson())
                {
                    this.Mode = enMode.UpdateMode;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (_UpdatePearsonInfo())
                    return true;
                return false;
            }
        }
        public static bool DeletePerson(int id)
        {
            return clsPearson.DeletePerson(id);
        }
        public static DataTable GetPeopleInfo()
        {
            return clsPeopleDataAccess.GetPeopleInfo();
        }

    }
}
