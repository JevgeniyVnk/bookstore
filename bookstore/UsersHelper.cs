using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ValueTuple;
namespace bookstore
{
    public class UsersHelper
    {

        public static List<(string name, string password)> _admins =
            new List<(string name, string password)>
            {
                ("admin", "admin"),
                ("Rasul", "Rasul"),
                ("Jenya", "Jenya")
            };

        public static List<(string name, string password)> _users =
            new List<(string name, string password)>
        {
                ("TyotaZina", "123123"),
                ("DyadaVasya", "12345"),
                ("Petya", "qwerty")
        };

        public static bool IsAdmin(string name, string pass) => _admins.Contains((name, pass));
        public static bool IsUser(string name, string pass) => _users.Contains((name, pass));
        public static bool IsLogged { get; set; } = false;
    }
}
