using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace QLSV
{
    class STUDENT
    {

        MY_DB mydb = new MY_DB();


        //  function to insert a new student
        public bool insertStudent(int Id,string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                " VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteStudent(int Id)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM std WHERE id=@id", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                mydb.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting student: " + ex.Message);
            }
            finally
            {
                mydb.closeConnection();
            }
            return success;
        }
        // function to search for a student by ID
        public DataTable SearchStudentByID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id=@id", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = studentID;

                mydb.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching student by ID: " + ex.Message);
            }
            finally
            {
                mydb.closeConnection();
            }
            return dt;
        }
        public bool UpdateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE std SET fname=@fname, lname=@lname, bdate=@bdate, gender=@gender, phone=@phone, address=@address, picture=@picture WHERE id=@id", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

                mydb.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating student: " + ex.Message);
            }
            finally
            {
                mydb.closeConnection();
            }
            return success;
        }

    }
}
