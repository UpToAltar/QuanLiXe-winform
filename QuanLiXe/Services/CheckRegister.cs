using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class CheckRegister
    {
        private static CheckRegister checkLogin;

        public static CheckRegister Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new CheckRegister();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private CheckRegister() { }

        public bool CheckUserExisted(string username)
        {
            string query = $"EXEC FindUserByUserName @UserName = N'{username}'";
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

        public bool CreateUser(string username, string password, string displayname) { 
            string query = $"EXEC CreateUser " +
                $"@UserName = N'{username}', " +
                $"@DisplayName = N'{displayname}'," +
                $"@Password = '{password}' , @Role = N'Nhân viên' ";
            var data = AppDBContext.Context.NonQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
