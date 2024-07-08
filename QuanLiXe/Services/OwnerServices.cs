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
            string query = $"EXEC GetOwnerByEmail @Email = N'{email}'";
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
            string query = $"EXEC GetOwnerById @Id = {id}";
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

        public bool CreateOwner(string name, string email, string phone, string address)
        {
            string query = $"EXEC CreateOwner @Email = N'{email}' , @FullName = N'{name}', @Address = N'{address}', @PhoneNumber = N'{phone}'";
            return GetSuccessQuery(query);
        }

        public bool UpdateOwner(string id, string name, string email, string phone, string address)
        {
            string query = $"EXEC UpdateOwner @Id = {id}, @Email = N'{email}' , @FullName = N'{name}', @Address = N'{address}', @PhoneNumber = N'{phone}'";
            return GetSuccessQuery(query);
        }

        public bool DeleteOwner(string id)
        {
            string query = $"EXEC DeleteOwner @Id ={id}";
            return GetSuccessQuery(query);
        }

        public DataTable Search(string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                string query1 = $"EXEC GetOwnerById @Id = {id} ";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"EXEC SearchOwnerByFullName @FullName = N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"EXEC GetAllOwner";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public bool CheckEmailOther(string email, string id)
        {
            string query = $"EXEC FindOwnerByEmailNotById @Id = {id}, @Email = N'{email}'";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
