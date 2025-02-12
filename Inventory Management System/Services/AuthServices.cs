using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Services
{
    public static class AuthServices
    {
        public static User MainUser = null;
        public static User Authenticate(string username, string password)
        {
            password = hashPassword(password);
            User user = DatabaseService.GetUser(username);
            if (user == null)
            {
                return null;
            }
            if(user.Password != password)
            {
                return null;
            }
            MainUser = user;
            return user;
        }

        public static void Logout()
        {
            MainUser = null;
        }

        private static string hashPassword(string password)
        {
            return password;
        }
    }
}
