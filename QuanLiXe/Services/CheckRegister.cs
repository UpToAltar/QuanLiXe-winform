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
            string query = $"SELECT * FROM Account WHERE UserName = N'{username}'";
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
            string query = $"INSERT INTO Account (DisplayName, UserName, Password, Role) VALUES(N'{displayname}', N'{username}', N'{password}', N'Nhân viên')";
            var data = AppDBContext.Context.NonQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
