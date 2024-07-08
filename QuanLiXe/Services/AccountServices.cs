using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public bool CheckUserName(string username)
        {
            string query = $"EXEC FindUserByUserName @UserName = N'{username}'";
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
            string query = $"EXEC FindUserById @Id = {id}";
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

        public bool CreateUser(string username, string password, string displayname, string role,string image)
        {
            string query = $"EXEC CreateUser " +
                $"@UserName = N'{username}', @Image = N'{image}'" +
                $"@DisplayName = N'{displayname}'," +
                $"@Password = '{password}' , @Role = N'{role}' ";
            return GetSuccessQuery(query);
        }

        public bool UpdateUser(string id, string username, string password, string displayname, string role, string image)
        {
            string query = $"EXEC UpdateUser @Id = {id}, @UserName = N'{username}', @DisplayName = N'{displayname}',@Password = N'{password}', @Role = N'{role}',@Image = N'{image}' ";
            return GetSuccessQuery(query);
        }

        public bool DeleteUser(string id)
        {
            string query = $"EXEC DeleteUserById @Id = {id}";
            return GetSuccessQuery(query);
        }

        public DataTable Search(string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                string query1 = $"EXEC FindUserById @Id = {id} ";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"EXEC SearchUserByUserName @UserName = N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"EXEC GetAllUser";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public bool CheckUserNameOther(string name, string id)
        {
            string query = $"EXEC FindUserByUserNameNotById @UserName = N'{name}', @Id = {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }
    }
}
