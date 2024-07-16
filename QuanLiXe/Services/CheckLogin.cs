using QuanLiXe.DatabaseHelper;
using QuanLiXe.Helper;
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

        public DataTable GetUserByUserName(out string msgError,string username, string password)
        {
            try
            {
                var param = new List<DbParamsSProduce> { new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar) };
                DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[FindUserByUserName]", param);
                if (PasswordHelper.Instance.VerifyPassword(password, data.Rows[0]["Password"].ToString()))
                {
                    return data;
                }
            } catch (Exception e)
            {
                msgError = e.Message;
                return null;
            }
            return null;
            
        }


    }
}
