using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsTestTypesDataAccess
    {
        static public DataTable GetTestTypesInfo()
        {
            DataTable dt = new DataTable();
            string query = @"select TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees from TestTypes;";
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
        static public int AddNew( string testtypetitle, float testtypefees, string testtypedescription)
        {
            int id = -1;
            string query = @"insert into TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees) Values  (@testtypetitle,@testtypedescription,@testtypefees) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testtypetitle", testtypetitle);
            command.Parameters.AddWithValue("@testtypedescription", testtypedescription);
            command.Parameters.AddWithValue("@testtypefees", testtypefees);
           
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

        static public bool Update(int testtypeid,string testtypetitle,float testtypefees,string testtypedescription)
        {
            bool ChangeWasMade = false;

            string query = @"Update TestTypes
                                            set 
                                            TestTypeTitle=@testtypetitle,
                                            TestTypeFees=@testtypefees,
                                            TestTypeDescription=@testtypedescription
                                            where TestTypeID=@testtypeid;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testtypetitle", testtypetitle);
            command.Parameters.AddWithValue("@testtypefees", testtypefees);
            command.Parameters.AddWithValue("@testtypedescription", testtypedescription);
            command.Parameters.AddWithValue("@testtypeid", testtypeid);
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
       public static bool Find(int  testtypeid,ref string testtypename,ref float testtypefees,ref string testtypedescription)
        {
            bool isFound = false;
            string query = "select * from TestTypes where TestTypeID=@testtypeid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@testtypeid", testtypeid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    testtypename = (string)reader["TestTypeTitle"];
                    testtypefees = Convert.ToSingle(reader["TestTypeFees"]);
                    testtypedescription = (string)reader["TestTypeDescription"];
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

    }
}
