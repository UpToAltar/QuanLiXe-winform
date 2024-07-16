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
    internal class ActivityHistoryServices
    {
        private static ActivityHistoryServices instance;

        public static ActivityHistoryServices Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ActivityHistoryServices();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private ActivityHistoryServices() { }

        public DataTable Load(out string msgError)
        {
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllActivityHistory]");
            CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách lịch sử hoạt động");
            return data;
        }

        public void CreateActivityHistory(int id, string actionType, string actionDescription)
        {
            string msgError = "";
            var pr = new List<DbParamsSProduce> {
                new DbParamsSProduce("@AccountId", id, SqlDbType.NVarChar),
                new DbParamsSProduce("@ActionType", actionType, SqlDbType.NVarChar),
                new DbParamsSProduce("@ActionDescription", actionDescription, SqlDbType.NVarChar),
            };

            AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[CreateActivityHistory]", pr);
        }

        public DataTable Filter(out string msgError,string actionType, string username)
        {
            var param = new List<DbParamsSProduce> {
                new DbParamsSProduce("@ActionType", actionType, SqlDbType.NVarChar),
                new DbParamsSProduce("@UserName", $"%{username}%", SqlDbType.NVarChar),
                new DbParamsSProduce("@Type", String.IsNullOrEmpty(actionType) ? 0 : 1, SqlDbType.Int)
            };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[SearchActivityHistoryByUserNameAndActionType]", param);
            CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Search, "Tìm kiếm lịch sử hoạt động");
            return data;
        }
    }
}
