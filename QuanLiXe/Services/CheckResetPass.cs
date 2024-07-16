using QuanLiXe.DatabaseHelper;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    internal class CheckResetPass
    {
        private static CheckResetPass instance;

        public static CheckResetPass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckResetPass();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private CheckResetPass() { }

        public bool IsUserExistedCheckByUserNameAndPassword(out string msgError, string username,string password)
        {
            try
            {
                var param = new List<DbParamsSProduce> { new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar) };
                DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[FindUserByUserName]", param);
                if (data != null)
                {
                    return PasswordHelper.Instance.VerifyPassword(password, data.Rows[0]["Password"].ToString());
                }
                else
                {
                    return false;
                }
                
                
            }
            catch
            {
                msgError = "Lỗi không xác định";
                return false;
            }
        }

        public bool ResetPassword(out string msgError,string username, string password)
        {
            string passwordHash = PasswordHelper.Instance.HashPassword(password);

            object userId = AccountServices.Instance.GetUserIdByUserName(out msgError, username);
            if (userId != null) {

                var param = new List<DbParamsSProduce>
                    {
                        new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar),
                        new DbParamsSProduce("@Password", passwordHash, SqlDbType.NVarChar),
                        new DbParamsSProduce("@UpdatedBy", Int32.Parse(userId.ToString()), SqlDbType.Int)
                    };

                object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[UpdatePassword]", param);
                if (data != null) ActivityHistoryServices.Instance.CreateActivityHistory((int)data, ActivityType.ResetPassword, "Người dùng đổi mật khẩu");
                return data != null;
            }
            else
            {
                return false;
            }
        }
    }
}
