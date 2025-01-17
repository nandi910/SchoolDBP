﻿using System.Data.SqlClient;
using System;


namespace SchoolDBP
{
    

    class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nandi\\Desktop\\SchoolDBP\\SchoolDBP\\Data.mdf;Integrated Security=True";

        public static void addNewUsers(string user, string pass, string firstN, string lastN, int spec, int year, int sem, int d1, int c1, int d2, int c2)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            // SQL Users
            {
                string SQLUsers = "INSERT INTO users VALUES(@username, @password, @type)";
                SqlCommand cmdUsers = new SqlCommand(SQLUsers, conn);
                cmdUsers.Parameters.AddWithValue("@username", user);
                cmdUsers.Parameters.AddWithValue("@password", pass);
                cmdUsers.Parameters.AddWithValue("@type", "Student");
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
            }
            // SQL Disciplines
            {
                string SQLDisciplines = "INSERT INTO disciplines (Discipline1,Credits1,Discipline2,Credits2) VALUES(@D1,@C1,@D2,@C2)";
                SqlCommand cmdDisciplines = new SqlCommand(SQLDisciplines, conn);
                cmdDisciplines.Parameters.AddWithValue("@D1", d1);
                cmdDisciplines.Parameters.AddWithValue("@C1", c1);
                cmdDisciplines.Parameters.AddWithValue("@D2", d2);
                cmdDisciplines.Parameters.AddWithValue("@C2", c2);
                cmdDisciplines.ExecuteScalar();

                conn.Close();
            }
        }

        public static int getDiscipData(string slct, string from, string userID)
        {
            // I know this is vulnerable to SQL injection but the user cannot influence the input of this in any way, shape or form so it's not an issue

            string SQL = "SELECT " + slct + " FROM " + from + " WHERE " + userID + "=" + GVars.getUserID();
            SqlConnection conn = new SqlConnection(GVars.connectionString());
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return temp;
        }
    }
}
