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
    internal class AutomakerServices
    {
        private static AutomakerServices instance;

        public static AutomakerServices Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AutomakerServices();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AutomakerServices() { }

        public bool IsAutomakerNameExisted(out string msgError,string name)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Name", name, SqlDbType.NVarChar) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError,"", "[dbo].[GetManufacturesByName]", param);
            return data == null ? false : (int)data > 0;
        }

        public bool IsAutomakerExistedCheckById(out string msgError, string idStr)
        {
            int id = 0;
            if (!int.TryParse(idStr, out id))
            {
                msgError = "Id không phải là số";
                return false;
            }

            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[GetManufacturesById]", param);
            return data == null ? false : (int)data > 0;
        }

        public bool CreateAutomaker(out string msgError, string name, string icon, string createdBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Name", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Icon", icon, SqlDbType.NVarChar),
                new DbParamsSProduce("@CreatedBy", createdBy, SqlDbType.Int)
            };

            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError,"", "[dbo].[CreateManufacture]", param);
            //Create history
            if(data>0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Add, "Tạo mới hãng xe " + name);
            return data > 0;
        }

        public bool UpdateAutomaker(out string msgError, string id, string name, string icon, string updatedBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Name", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Icon", icon, SqlDbType.NVarChar),
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[UpdateManufacture]", param);
            //Create history
            if (data > 0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Update, "Cập nhật hãng xe " + name);
            return data > 0;
        }

        public bool DeleteAutomaker(out string msgError, string id, string updatedBy)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[DeleteManufactureById]", param);

            //Create history
            if (data != null) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Delete, "Xóa hãng xe " + data.ToString());
            return data != null;
        }

        public DataTable Search(out string msgError, string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                var pram = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
                DataTable dt = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetManufacturesById]", pram);
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Search, "Tìm kiếm hãng xe có Id = " + id);
                return dt;
            }

            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Name", $"%{name}%", SqlDbType.NVarChar) };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[SearchManufactureByName]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Search, "Tìm kiếm hãng xe có tên chứa : " + name);
            return data;
        }

        public DataTable Load(out string msgError)
        {
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllManufactures]");
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách hãng xe");
            return data;
        }

        public DataTable LoadByDate(out string msgError, DateTime from , DateTime to)
        {
            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@StartDate", from, SqlDbType.DateTime),
                new DbParamsSProduce("@EndDate", to, SqlDbType.DateTime)
            };

            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetManufacturesFromDateToDate]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách hãng xe từ " + from + " đến " + to);
            return data;
        }

        public DataTable GetVehiclesByAutomakerName(out string msgError,string name)
        {
            List<DbParamsSProduce> param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@ManufactureName", name,SqlDbType.NVarChar)
            };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetVehiclesByManufactureName]", param);
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách xe của hãng " + name);
            return data;
        }

        public bool IsOtherAutomakerExisted(out string msgError, string name, string id)
        {

            var param = new List<DbParamsSProduce>
            {
                new DbParamsSProduce("@Name", name, SqlDbType.NVarChar),
                new DbParamsSProduce("@Id", id, SqlDbType.Int)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindManufactureByNameNotById]", param);
            return data == null ? false : (int)data > 0;
        }
    }
}
