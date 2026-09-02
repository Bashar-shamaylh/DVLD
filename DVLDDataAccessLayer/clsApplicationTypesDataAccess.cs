using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public static  class clsApplicationTypesDataAccess
    {
        static public bool Find(int id, ref string apptitle, ref float fees)
        {
            bool isFound = false;
            string query = "select * from ApplicationTypes where ApplicationTypeID=@id";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    apptitle = (string)reader["ApplicationTypeName"];
                    fees = Convert.ToSingle(reader["ApplicationTypeFees"]);
                    
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
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = "select * from ApplicationTypes;";
            SqlConnection connection = new SqlConnection( ClsDataAccessSetting.ConnectionString);
            SqlCommand command= new SqlCommand(query, connection);
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
        static public int AddNew(string applicationtypename,float applicationtypefees)
        {
            int id = -1;
            string query = @"insert into ApplicationTypes (ApplicationTypeName,ApplicationTypeFees) Values  (@applicationtypename,@applicationtypefees) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationtypename", applicationtypename);
            command.Parameters.AddWithValue("@applicationtypefees", applicationtypefees);
         
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
        public static bool Update( int id, string title, float fees)
        {
            bool ChangeWasMade = false;

            string query = @"Update ApplicationTypes
                                            set 
                                            ApplicationTypeName=@title,
                                            ApplicationTypeFees=@fees
                                            
                                            where ApplicationTypeID=@id;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@fees", fees);
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
