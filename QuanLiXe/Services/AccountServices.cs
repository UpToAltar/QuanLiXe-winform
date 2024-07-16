using QuanLiXe.DatabaseHelper;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLiXe.Services
{
    internal class AccountServices
    {
        private static AccountServices instance;

        public static AccountServices Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountServices();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AccountServices() { }

        public bool IsUserNameExisted(out string msgError,string username)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError,"", "[dbo].[FindUserByUserName]", param);
            return data==null ? false : (int)data > 0 ;
        }

        public object GetUserIdByUserName(out string msgError,string username)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar) };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[FindUserByUserName]", param);
            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["ID"];
            }
            return null;
        }

        public bool IsUserExistedCheckById(out string msgError,string idStr)
        {
            int id = 0;
            if (!int.TryParse(idStr, out id))
            {
                msgError = "Id không phải là số";
                return false;
            }
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindUserById]", param);
            return data == null ? false : (int)data > 0;
        }

        public bool CreateUser(out string msgError,string username, string password, string displayname, string role,string image, int isActive, string createdBy, int typeCheck)
        {
            string passwordHash = PasswordHelper.Instance.HashPassword(password);

            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar),
                new DbParamsSProduce("@Image", image, SqlDbType.NVarChar),
                new DbParamsSProduce("@DisplayName", displayname, SqlDbType.NVarChar),
                new DbParamsSProduce("@CreatedBy", createdBy, SqlDbType.Int),
                new DbParamsSProduce("@Password", passwordHash, SqlDbType.NVarChar),
                new DbParamsSProduce("@Role", role, SqlDbType.NVarChar),
                new DbParamsSProduce("@IsActive", isActive, SqlDbType.Bit)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[CreateUser]", param);

            //Create History
            if(data != null && (int)data > 0)
            {
                if (typeCheck == 1)
                {
                    ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Add, $"Thêm tài khoản {username}");
                }
                else
                {
                    ActivityHistoryServices.Instance.CreateActivityHistory((int)data, ActivityType.Register, $"Người dùng đăng kí tài khoản {username}");

                }
            }
            return data != null && (int)data > 0;
        }

        public bool UpdateUser(out string msgError,string id, string username, string password, string displayname, string role, string image, int isActive, string updatedBy)
        {
            int type = 1;
            string passwordHash = PasswordHelper.Instance.HashPassword(password);
            if(string.IsNullOrEmpty(password))
            {
                passwordHash = "";
                type = 0;
            }
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@UserName", username, SqlDbType.NVarChar),
                new DbParamsSProduce("@Image", image, SqlDbType.NVarChar),
                new DbParamsSProduce("@DisplayName", displayname, SqlDbType.NVarChar),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int),
                new DbParamsSProduce("@Password", passwordHash, SqlDbType.NVarChar),
                new DbParamsSProduce("@Role", role, SqlDbType.NVarChar),
                new DbParamsSProduce("@IsActive", isActive, SqlDbType.Bit),
                new DbParamsSProduce("@Type", type, SqlDbType.Int)
            };
            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[UpdateUser]", param);
            //Create history
            if(data > 0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Update, $"Cập nhật tài khoản {username}");            
            return data > 0;
        }

        public bool DeleteUser(out string msgError, string id, string updatedBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[DeleteUserById]", param);
            //Create history
            if (data != null) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Delete, $"Xóa tài khoản {data.ToString()}");
            return data != null;
        }

        public DataTable Load(out string msgError)
        {
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllUser]");
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách tài khoản");
            return data;
        }

        public DataTable LoadByDate(out string msgError, DateTime from, DateTime to)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@StartDate", from, SqlDbType.DateTime),
                new DbParamsSProduce("@EndDate", to, SqlDbType.DateTime)
            };

            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetAccountsFromDateToDate]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách người dùng từ " + from + " đến " + to);
            return data;
        }

        public bool IsUserExisted(out string msgError,string name, string id)
        {

            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@UserName", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Id", id, SqlDbType.Int)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindUserByUserNameNotById]", param);
            return data == null ? false : (int)data > 0;
        }
    }
}
