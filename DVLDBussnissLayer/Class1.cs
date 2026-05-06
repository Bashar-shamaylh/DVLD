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
        public string FirstName { get; set; }
        public char Gendor {  get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationnalNumber {  get; set; }
        public string Address {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID {  get; set; }
        public string PersonalImage { get; set; }

        clsPearson() {
            ID = 0;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationnalNumber = "";
            Address = "";
            Phone = "";
            Email = "";
            Gendor = 'M';
            DateOfBirth = DateTime.Now;
            CountryID = -1;
            PersonalImage = null;
        }
        clsPearson(int id,string firstname, string secondname, string thirrdname, string lastname, string nationalnumber, DateTime dateofbirth, string address,string phone,string email,int countryid,string personalimage,char gendor)
        {
            ID = id;
             FirstName = firstname;
            SecondName = secondname;
            ThirdName = thirrdname;
            LastName = lastname;
            NationnalNumber = nationalnumber;
            Address = address;
            Phone = phone;
            Email = email;
            DateOfBirth = dateofbirth;
            CountryID = countryid;
            PersonalImage = personalimage;
            Gendor=gendor;
        }
        static public clsPearson Find(int id)
        {
           
           
           string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
           string nationnalNumber = "";
            string address = "";
            string phone = "";
            string email = "";
           DateTime dateOfBirth = DateTime.Now;
            char gendor = 'M';
           int countryID = -1;
            string personalImage = null;
            if (clsPeopleDataAccess.GetPearsonByID(id,ref firstName, ref secondName, ref thirdName, ref lastName, ref nationnalNumber, ref dateOfBirth, ref address,ref phone,ref email,ref countryID,ref personalImage,ref gendor))
               return new clsPearson(id,firstName,secondName,thirdName,lastName,nationnalNumber,dateOfBirth,address,phone,email,countryID,personalImage,gendor);
            return null;        
        }
         private bool _AddNewPerson()
        {
            this.ID=clsPeopleDataAccess.AddNewPerson(NationnalNumber,FirstName,SecondName,ThirdName,LastName,DateOfBirth, Address,Phone,Email,CountryID,PersonalImage,Gendor);
            return this.ID!=-1;
        }
        private bool _UpdatePearsonInfo()
        {
            return clsPeopleDataAccess.UpdatePersonInfo(this.ID, NationnalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Address, Phone, Email, CountryID, PersonalImage,Gendor);
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
