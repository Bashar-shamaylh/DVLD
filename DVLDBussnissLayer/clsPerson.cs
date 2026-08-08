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
    public class clsPerson
    {
       public enum enMode { AddMode=1,UpdateMode}
        public enMode Mode = enMode.AddMode;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public short Gender {  get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationnalNumber {  get; set; }
        public string Address {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Nationality {  get; set; }
        public clsCountry CountryInfo;
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public string PersonalImage { get; set; }

       public clsPerson() {
            ID = 0;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationnalNumber = "";
            Address = "";
            Phone = "";
            Email = "";
            Gender = 'M';
            DateOfBirth = DateTime.Now;
            Nationality = -1;
            PersonalImage = null;
            ImagePath = "";
            Mode=enMode.AddMode;
        }
        clsPerson(int id,string firstname, string secondname, string thirrdname, string lastname, string nationalnumber, DateTime dateofbirth, string address,string phone,string email,int nationality, string personalimage,char gender)
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
            Nationality = nationality;
            PersonalImage = personalimage;
            ImagePath=personalimage;
            CountryInfo = clsCountry.Find(Nationality);
            Gender=gender;
            Mode=enMode.UpdateMode;
        }
        static public clsPerson Find(int id)
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
            char gender = 'M';
           int nationality = -1;
            string personalImage = null;
            
            if (clsPeopleDataAccess.GetPersonByID(id,ref firstName, ref secondName, ref thirdName, ref lastName, ref nationnalNumber, ref dateOfBirth, ref address,ref phone,ref email,ref nationality, ref personalImage,ref gender))
               return new clsPerson(id,firstName,secondName,thirdName,lastName,nationnalNumber,dateOfBirth,address,phone,email, nationality, personalImage,gender);
            return null;        
        }
        public static clsPerson Find(string nationalNumber)
        {
            int id = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";

            string address = "";
            string phone = "";
            string email = "";
            DateTime dateOfBirth = DateTime.Now;
            char gender = 'M';
            int nationality = -1;
            string personalImage = null;

            if (clsPeopleDataAccess.GetPersonByNationalNum(ref id, ref firstName, ref secondName, ref thirdName, ref lastName, nationalNumber, ref dateOfBirth, ref address, ref phone, ref email, ref nationality, ref personalImage, ref gender))
                return new clsPerson(id, firstName, secondName, thirdName, lastName, nationalNumber, dateOfBirth, address, phone, email, nationality, personalImage, gender);
            return null;
        }
        public static clsPerson FindPersonByNationnalNum(string nationalNumber)
        {
            int id = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";

            string address = "";
            string phone = "";
            string email = "";
            DateTime dateOfBirth = DateTime.Now;
            char gender = 'M';
            int nationality = -1;
            string personalImage = null;

            if (clsPeopleDataAccess.GetPersonByNationalNum(ref id, ref firstName, ref secondName, ref thirdName, ref lastName,  nationalNumber, ref dateOfBirth, ref address, ref phone, ref email, ref nationality, ref personalImage, ref gender))
                return new clsPerson(id, firstName, secondName, thirdName, lastName, nationalNumber, dateOfBirth, address, phone, email, nationality, personalImage, gender);
            return null;
        }
        private bool _AddNewPerson()
        {
            this.ID=clsPeopleDataAccess.AddNewPerson(NationnalNumber,FirstName,SecondName,ThirdName,LastName,DateOfBirth, Address,Phone,Email, Nationality, PersonalImage,Gender);
            return this.ID!=-1;
        }
        private bool _UpdatePersonInfo()
        {
            return clsPeopleDataAccess.UpdatePersonInfo(this.ID, NationnalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Address, Phone, Email, Nationality, PersonalImage,Gender);
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
                if (_UpdatePersonInfo())
                    return true;
                return false;
            }
        }
        public static bool DeletePerson(int id)
        {
            return clsPeopleDataAccess.DeletePerson(id);
        }
        public static DataTable GetPeopleInfo()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }
        public static bool isNationalNumberExist(string nationalnumber)
        {
            return clsPeopleDataAccess.IsNationalNumExist(nationalnumber);
        }
        public static bool isPersonExist(int id)
        {
            return clsPeopleDataAccess.isPersonExist(id);
        }
        public static bool isPersonExist(string NationalNum)
        {
            return clsPeopleDataAccess.isPersonExist(NationalNum);
        }
     

    }
}
