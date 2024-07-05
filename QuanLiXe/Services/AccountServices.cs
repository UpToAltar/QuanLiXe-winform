using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class AccountServices
    {
        private static AccountServices checkLogin;

        public static AccountServices Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new AccountServices();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private AccountServices() { }

        public bool CheckUserName(string name)
        {
            string query = $"SELECT * FROM Account WHERE UserName = N'{name}'";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckFindById(string idStr)
        {
            int id = 0;
            if (!int.TryParse(idStr, out id))
            {
                return false;
            }
            string query = $"SELECT * FROM Account WHERE ID = {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }

        public bool GetSuccessQuery(string query)
        {
            var data = AppDBContext.Context.NonQuery(query);
            return data > 0;
        }

        public DataTable Search(string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                string query1 = $"SELECT * FROM Account WHERE ID = {id} ";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"SELECT * FROM Account WHERE UserName LIKE N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"SELECT TOP 100 * FROM Account";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public bool CheckUserNameOther(string name, string id)
        {
            string query = $"SELECT * FROM Account WHERE UserName = N'{name}' AND ID != {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
