using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    static public class clsGlobalProjectSettings
    {
       public static int CurrentUserId = -1;
       public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DVLD");//this path for users data
                clsUtil.CreateFolderIfDoesNotExist(path);//create DVLD folder if not exist  //step 1

                path = Path.Combine(path, "UsersInfo.txt");
                if (File.Exists(path))
                {
                    string savedUser = File.ReadAllText(path);               //step 3
                    if (!string.IsNullOrEmpty(savedUser))
                    {
                        string[] result = savedUser.Split(new string[] { "#//#" }, StringSplitOptions.None);
                        Username = result[0];
                        Password = result[1];
                        return true;
                    }
   
                }

                return false;

            }
            catch (Exception)
            {

                return false;

            }
            
        }
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DVLD");//this path for users data
                clsUtil.CreateFolderIfDoesNotExist(path);//create DVLD folder if not exist  //step 1

                path = Path.Combine(path, "UsersInfo.txt");

                if (Username == "" && File.Exists(path))
                { 
                    File.Delete(path); return true;
                }

                string SavedUser = Username + "#//#" + Password;
                File.WriteAllText(path, SavedUser);

                return true;

            }
            catch (Exception)
            {

                return false;

            }
        }
    }
}
