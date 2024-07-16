using QuanLiXe.DatabaseHelper;
using QuanLiXe.DTO;
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

        public bool IsEmailExisted(out string msgError,string email)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Email", email, SqlDbType.NVarChar) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[GetOwnerByEmail]", param);
            return data == null ? false : (int)data > 0;
        }

        public bool IsOwnerExistedCheckById(out string msgError, string idStr)
        {
            int id = 0;
            if (!int.TryParse(idStr, out id))
            {
                msgError = "Id không phải là số";
                return false;
            }

            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[GetOwnerById]", param);
            return data == null ? false : (int)data > 0;
        }


        public bool CreateOwner(out string msgError, string name, string email, string phone, string address, string createdBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Email", email, SqlDbType.NVarChar),
                new DbParamsSProduce("@FullName", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Address", address, SqlDbType.NVarChar),
                new DbParamsSProduce("@PhoneNumber", phone, SqlDbType.NVarChar),
                new DbParamsSProduce("@CreatedBy", createdBy, SqlDbType.Int)
            };

            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[CreateOwner]", param);
            if(data >0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Add, "Tạo mới chủ xe " + name);
            return data > 0;
        }

        public bool UpdateOwner(out string msgError, string id, string name, string email, string phone, string address , string updatedBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@Email", email, SqlDbType.NVarChar),
                new DbParamsSProduce("@FullName", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Address", address, SqlDbType.NVarChar),
                new DbParamsSProduce("@PhoneNumber", phone, SqlDbType.NVarChar),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[UpdateOwner]", param);
            if(data > 0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Update, "Cập nhật chủ xe " + name);
            return data > 0;
        }

        public bool DeleteOwner(out string msgError, string id , string updatedBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[DeleteOwner]", param);
            if(data != null) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Delete, "Xóa chủ xe " + data.ToString());
            return data != null;
        }

        public DataTable Search(out string msgError, string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                var pram = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
                DataTable dt = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetOwnerById]", pram);
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Search, "Tìm kiếm chủ xe có Id = " + id);
                return dt;
            }
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@FullName", $"%{name}%", SqlDbType.NVarChar) };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[SearchOwnerByFullName]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Search, "Tìm kiếm chủ xe có tên chứa : " + name);
            return data;
        }

        public DataTable Load(out string msgError)
        {
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllOwner]");
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách chủ xe");
            return data;
        }

        public DataTable LoadByDate(out string msgError, DateTime from, DateTime to)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@StartDate", from, SqlDbType.DateTime),
                new DbParamsSProduce("@EndDate", to, SqlDbType.DateTime)
            };

            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetOwnersFromDateToDate]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách chủ xe từ " + from + " đến " + to);
            return data;
        }

        public bool IsEmailOtherExisted(out string msgError, string email, string id)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Email", email, SqlDbType.NVarChar),
                new DbParamsSProduce("@Id", id, SqlDbType.Int)
            };

            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindOwnerByEmailNotById]", param);
            return data == null ? false : (int)data > 0;
        }
    }
}
