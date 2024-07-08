using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class CheckLogin
    {
        private static CheckLogin checkLogin;

        public static CheckLogin Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new CheckLogin();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private CheckLogin() { }

        public DataTable Check(string username, string password)
        {
            string query = $"EXEC FindUserByUserNameAndPassword @UserName = N'{username}', @Password = N'{password}'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }
    }
}
