using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class CheckResetPass
    {
        private static CheckResetPass checkLogin;

        public static CheckResetPass Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new CheckResetPass();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private CheckResetPass() { }

        public bool CheckUserExistedAndPassword(string username,string password)
        {
            string query = $"EXEC FindUserByUserNameAndPassword @UserName = N'{username}', @Password = N'{password}'";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckPassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            return true;
        }

        public bool ResetPassword(string username, string password)
        {
            string query = $"EXEC UpdatePassword @UserName = N'{username}',@Password = N'{password}' ";
            var data = AppDBContext.Context.NonQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
