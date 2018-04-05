using System.Data.SqlClient;

namespace SchoolDBP
{
    

    class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nandi\\Desktop\\SchoolDBP\\SchoolDBP\\Data.mdf;Integrated Security=True";

        public static void addNewUsers(string user, string pass, string firstN, string lastN, int spec, int year, int sem)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            // SQL Users
            {
                string SQLUsers = "INSERT INTO users VALUES(@username, @password)";
                SqlCommand cmdUsers = new SqlCommand(SQLUsers, conn);
                cmdUsers.Parameters.AddWithValue("@username", user);
                cmdUsers.Parameters.AddWithValue("@password", pass);
                cmdUsers.ExecuteScalar();
            }
            // SQL Data
            {
                string SQLData = "INSERT INTO data (FirstName, LastName, Specialization, Year, Semester) VALUES(@FirstName,@LastName,@Specialization,@Year,@Semester)";
                SqlCommand cmdData = new SqlCommand(SQLData, conn);
                cmdData.Parameters.AddWithValue("@FirstName", firstN);
                cmdData.Parameters.AddWithValue("@LastName", lastN);
                cmdData.Parameters.AddWithValue("@Specialization", spec);
                cmdData.Parameters.AddWithValue("@Year", year);
                cmdData.Parameters.AddWithValue("@Semester", sem);
                cmdData.ExecuteScalar();

                conn.Close();
            }
        }
    }
}
