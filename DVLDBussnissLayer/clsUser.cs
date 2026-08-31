using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussnissLayer
{
    public class clsUser
    {
        public enum enMode { AddMode = 1, UpdateMode }
        public enMode Mode = enMode.AddMode;
        public int UserID { get; set; }
        public string UserName { get; set; }
       
        public string UserPassword { get; set; }
        public int PersonID { get; set; }
        clsPerson PersonInfo;
        public bool isActive { get; set; }
       

        public clsUser()
        {
            UserID =-1;
            UserName = "";
            UserPassword = "";
            PersonID = -1;
            isActive = false;
            
        }
        clsUser(int userid, string username, string userpassword, int personid, bool isactive)
        {
            UserID = userid;
            UserName = username;
            UserPassword = userpassword;
            PersonID = personid;
            PersonInfo = clsPerson.Find(PersonID);
            isActive = isactive;
           
            Mode = enMode.UpdateMode;
        }
        static public clsUser Find(int userid)
        {


            string username = "";
            string userpassword = "";
            int personid = -1;
            bool isactive = false;

            if (clsUsersDataAccess.GetUserByID(userid,ref username,ref userpassword,ref personid,ref isactive))
                return new clsUser(userid,username,userpassword,personid,isactive);
            return null;
        }
        static public clsUser FindUserByPersonID(int personid)
        {


            string username = "";
            string userpassword = "";
            int userid = -1;
            bool isactive = false;

            if (clsUsersDataAccess.GetUserByPersonID(ref userid, ref username, ref userpassword,  personid, ref isactive))
                return new clsUser(userid, username, userpassword, personid, isactive);
            return null;
        }
        public static clsUser FindUserByUserNameAndUserPassword(string userName, string userpassword)
        {
            int personid = -1;
            int userid = -1;
            bool isActive = false;
            if( clsUsersDataAccess.FindUserByUserNameAndUserPassword(userName, userpassword,ref isActive,ref userid,ref personid))
                return new clsUser(userid,userName,userpassword, personid, isActive);
            return null;
        }
        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(UserName,UserPassword,PersonID,isActive);
            return this.UserID != -1;
        }
        private bool _UpdateUserInfo()
        {
            return clsUsersDataAccess.UpdateUserInfo(UserID,UserName,UserPassword,PersonID,isActive);
        }
        public bool Save()
        {
            if (this.Mode == enMode.AddMode)
            {
                if (_AddNewUser())
                {
                    this.Mode = enMode.UpdateMode;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (_UpdateUserInfo())
                    return true;
                return false;
            }
        }
        public static bool DeleteUser(int userid)
        {
            return clsUsersDataAccess.DeleteUser(userid);
        }
        public static DataTable GetUsersInfo()
        {
            return clsUsersDataAccess.GetUsersInfo();
        }
        public static bool FindUserByUserNameAndUserPassword(string userName,string userpassword,ref bool isactive,ref int userid)
        {
            return clsUsersDataAccess.FindUserByUserNameAndUserPassword(userName,userpassword,ref isactive,ref userid);
        }
       
        public static bool IsUserWithPersonIDExist(int personid)
        {
            return clsUsersDataAccess.isUserWithPersonIDExist(personid);
        }
        public static bool IsUserWithUserIDExist(int userid)
        {
            return clsUsersDataAccess.isUserWithUserIDExist(userid);
        }
        public static bool IsUserWithUserNameExist(string username)
        {
            return clsUsersDataAccess.isUserWithUserNameExist(username);
        }


    }
}
