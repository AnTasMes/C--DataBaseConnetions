using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimoAndrej
{
    class accountInfo
    {
        public static string connection = "datasource=127.0.0.1;" +
                "Database=projekatprogramiranje;" +
                ";username=root;password=";
        private static string username;
        private static string password;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
    }
}
