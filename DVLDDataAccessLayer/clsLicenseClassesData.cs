using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static  class clsLicenseClassesData
    {
        
        static public bool Find(int id, ref string classname, ref string description,ref int minimumAllowedAge,ref float fees,ref int validitylength)
        {
            bool isFound = false;
            string query = "select * from LicenseClasses where LicenseClassID=@id";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    classname = (string)reader["ClassName"];
                    description = (string)reader["Description"];
                    minimumAllowedAge = (int)reader["MinimumAgeAllowed"];
                    fees = Convert.ToSingle(reader["fees"]);
                    validitylength = (int)reader["ValidityLength"];
                    

                    isFound = true;
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return isFound;

        }

        public static DataTable GetAllLicenseCalsses()
        {
            DataTable dt = new DataTable();
            string query = "select * from LicenseClasses;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return dt;
        }
        static public int AddNew( string classname,  string description,  int minimumallowedage,  float fees,  int validitylength)
        {
            int id = -1;
            string query = @"insert into LicenseClasses (ClassName, Description,MinimumAgeAllowed,fees,ValidityLength) Values  (@classname,@description,@minimumallowedage,@fees,@validitylength) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@classname", classname);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@minimumallowedage", minimumallowedage);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@validitylength", validitylength);
            

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID)) { id = ID; }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return id;
        }
        public static bool Update(int id,string classname, string description, int minimumallowedage, float fees, int validitylength)
        {
            bool ChangeWasMade = false;

            string query = @"Update LicenseClasses
                                            set 
                                            ClassName=@classname,
                                            Description=@description ,
                                            MinimumAgeAllowed=@minimumallowedage,
                                            fees=@fees,
                                            validitylength=@validitylength
                                            
                                            where LicenseClassID=@id;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@classname", classname);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@minimumallowedage", minimumallowedage);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@validitylength", validitylength);
            command.Parameters.AddWithValue("@id", id);



            try
            {
                connection.Open();
                int numberofrowsaffected = command.ExecuteNonQuery();
                if (numberofrowsaffected != 0)
                {
                    ChangeWasMade = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                connection.Close();
            }
            return ChangeWasMade;
        }
    }
}
