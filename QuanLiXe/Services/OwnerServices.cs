using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class OwnerServices
    {
        private static OwnerServices checkLogin;

        public static OwnerServices Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new OwnerServices();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private OwnerServices() { }

        public bool CheckEmail(string email)
        {
            string query = $"SELECT * FROM Owners WHERE Email = N'{email}'";
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
            string query = $"SELECT * FROM Owners WHERE OwnerId = {id}";
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
                string query1 = $"SELECT * FROM Owners WHERE OwnerId = {id} ";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"SELECT * FROM Owners WHERE FullName LIKE N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"SELECT TOP 100 * FROM Owners";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public bool CheckEmailOther(string email, string id)
        {
            string query = $"SELECT * FROM Owners WHERE Email = N'{email}' AND OwnerId != {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
