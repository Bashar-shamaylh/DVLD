using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
namespace DVLDBussnissLayer
{
    public class clsPearson
    {
        public int ID { get; }
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
       static public clsPearson Find(int id)
        {
            clsPearson person=new clsPearson();
            int ID = 0;
           string Name = "";
           string NationnalNumber = "";
            string Address = "";
            string Phone = "";
            string Email = "";
           DateTime DateOfBirth = DateTime.Now;
           int CountryID = -1;
            string PersonalImage = null;
            if (clsPeopleDataAccess.GetPearsonByID(id, ref person.Name))
               
           

        }

    }
}
