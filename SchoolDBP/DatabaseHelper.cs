using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolDBP
{
    

    class DatabaseHelper
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Data.mdf;Integrated Security=True";

        public static DataTable load_users()
        {
            DataTable dt = new DataTable();
            string SQL = "SELECT * FROM users WHERE userList_ID is null;";

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataAdapter DTAdapter = new SqlDataAdapter(cmd);
                DTAdapter.Fill(dt);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return dt;
        }

        public static DataTable load_data()
        {
            DataTable dt = new DataTable();
            string SQL = "SELECT * FROM data WHERE userData_ID is null;";

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataAdapter DTAdapter = new SqlDataAdapter(cmd);
                DTAdapter.Fill(dt);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return dt;
        }

        public class users_columns
        {
            public const string username = "username";
            public const string password = "password";
            public const string userList_ID = "userList_ID";
        }

        public class data_columns
        {
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string Specialization = "Specialization";
            public const string Year = "Year";
            public const string Semester = "Semester";
            public const string Discipline1 = "Discipline1";
            public const string Discipline2 = "Discipline2";
            public const string userData_ID = "userData_ID";
        }
    }
}
