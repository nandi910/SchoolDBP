using System;

namespace SchoolDBP
{
    public static class GVars
    {
        private static int _userID;
        public static void setUserID(int userID)
        {
            _userID = userID;
        }
        public static int getUserID()
        {
            return _userID;
        }
        private static readonly string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\Data.mdf;Integrated Security=True;";
        public static string connectionString()
        {
            return _connectionString;
        }
    }
}
