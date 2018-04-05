using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
