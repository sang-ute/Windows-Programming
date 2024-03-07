using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLSV
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=my_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }
        // delete a row from the database
        public bool DeleteRow(string tableName, string condition)
        {
            bool success = false;
            try
            {
                openConnection();
                string query = $"DELETE FROM {tableName} WHERE {condition}";
                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting row: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return success;
        }
        public DataTable SearchStudentByID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM std WHERE id = @studentID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching student: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }


    }
}

