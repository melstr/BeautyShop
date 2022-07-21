using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_shop
{
    static class GlobalConnection
    {
        public static String connectionString;

        public static SqlConnection connection;

        public static UserDB AuthedUser;
        public static void Open()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static void Close()
        {
            connection.Close();
        }

        public static void AuthUser(UserDB us)
        {
            AuthedUser = us;
        }

        public static void SignOut()
        {
            AuthedUser = new UserDB();
        }
    }
}
