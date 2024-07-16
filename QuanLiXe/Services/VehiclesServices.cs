using GLib;
using QuanLiXe.DatabaseHelper;
using QuanLiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.Services
{
    internal class VehiclesServices
    {
        private static VehiclesServices checkLogin;

        public static VehiclesServices Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new VehiclesServices();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private VehiclesServices() { }

        public bool IsPlateExisted(out string msgError,string plate)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@LiscensePlate", plate, SqlDbType.NVarChar) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError,"", "[dbo].[FindVehiclesByPlate]", param);
            return data == null ? false : (int)data > 0;
        }



        public bool IsVehiclesExistedCheckById(out string msgError, string idStr)
        {
            int id = 0;
            if (!int.TryParse(idStr, out id))
            {
                msgError = "Id không phải là số";
                return false;
            }
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@Id", id, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindVehiclesById]", param);
            return data == null ? false : (int)data > 0;
        }

        public VehiclesUpdateDTO SearchById(out string msgError, string id)
        {
            var param = new List<DbParamsSProduce> { 
                new DbParamsSProduce("@Id", id, SqlDbType.Int),
                new DbParamsSProduce("@Name", "", SqlDbType.NVarChar),
                new DbParamsSProduce("@Type", 1, SqlDbType.Int)
            };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetVehiclesByIdOrSearchByName]", param);
            foreach (DataRow item in data.Rows)
            {
                var dto = new VehiclesUpdateDTO(item);
                return dto;
            }
            return null;
        }

        public List<VehiclesDTO> Load(out string msgError)
        {
            var list = new List<VehiclesDTO>();
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllVehicles]");
            foreach (DataRow item in data.Rows) list.Add(new VehiclesDTO(item));
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách xe");
            return list ;
        }

        public List<VehiclesDTO> LoadByDate(out string msgError, System.DateTime from, System.DateTime to)
        {
            var list = new List<VehiclesDTO>();
            var param = new List<DbParamsSProduce> {
                new DbParamsSProduce("@StartDate", from, SqlDbType.DateTime),
                new DbParamsSProduce("@EndDate", to, SqlDbType.DateTime)
            };
            DataTable data = AppDBContext.Context.ExecuteSProcedureReturnDataTable(out msgError, "", "[dbo].[GetVehicleFromDateToDate]", param);
            foreach (DataRow item in data.Rows) list.Add(new VehiclesDTO(item));
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.View, "Xem danh sách xe từ " + from + " đến " + to);
            return list;
        }

        public List<ManufacturesDTO> LoadManufactures(out string msgError)
        {
            var list = new List<ManufacturesDTO>();
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllManufactures]");
            foreach (DataRow item in data.Rows) list.Add(new ManufacturesDTO(item));
            return list;
        }

        public List<OwnerDTO> LoadOwners(out string msgError)
        {
            var list = new List<OwnerDTO>();
            DataTable data = AppDBContext.Context.ExecuteNonQueryProcedureReturnDataTable(out msgError, "", "[dbo].[GetAllOwner]");
            foreach (DataRow item in data.Rows) list.Add(new OwnerDTO(item));
            return list;
        }

        public bool IsOtherPlateExisted(out string msgError, string plate, string id)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@LiscensePlate", plate, SqlDbType.NVarChar), new DbParamsSProduce("@Id", id, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[FindVehiclesByPlateNotById]", param);
            return data == null ? false : (int)data > 0;
        }


        public bool CreateVehicles(out string msgError, TextBox color, TextBox engineDisplacement, TextBox engineType, TextBox fuelType, TextBox liscensePlate, TextBox name, NumericUpDown acceleration, NumericUpDown weigth, NumericUpDown topSpeed,ComboBox manufactures, ComboBox owner, string createdBy)
        {
            // Create specifications
            var paramSpec = new List<DbParamsSProduce> { 
                new DbParamsSProduce("@EngineType", engineType.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@FuelType", fuelType.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@EngineDisplacement", engineDisplacement.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@Weigth", weigth.Value, SqlDbType.Decimal),
                new DbParamsSProduce("@TopSpeed", topSpeed.Value, SqlDbType.Decimal),
                new DbParamsSProduce("@Acceleration", acceleration.Value, SqlDbType.Decimal)
            };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[CreateSpecification]", paramSpec);
            if(data == null)
            {
                return false;
            }
            int specId = (int)data;

            // Create vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;

            var paramVehicles = new List<DbParamsSProduce> { 
                new DbParamsSProduce("@VehicleName", name.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@LiscensePlate", liscensePlate.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@Color", color.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@ManufacturesId", manufacture.ID, SqlDbType.Int),
                new DbParamsSProduce("@OwnerId", ownerData.ID, SqlDbType.Int),
                new DbParamsSProduce("@SpecificationsId", specId, SqlDbType.Int),
                new DbParamsSProduce("@CreatedBy", createdBy, SqlDbType.Int)
            };

            int data2 = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[CreateVehicle]", paramVehicles);
            if(data2 >0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Add, "Thêm xe " + name.Text);
            return data2 > 0;
        }

        public bool UpdateVehicles(out string msgError, TextBox color, TextBox engineDisplacement, TextBox engineType, TextBox fuelType, TextBox liscensePlate, TextBox name, NumericUpDown acceleration, NumericUpDown weigth, NumericUpDown topSpeed, ComboBox manufactures, ComboBox owner,TextBox id, string updatedBy)
        {
            //Update specifications
            var paramSpec = new List<DbParamsSProduce> {
                new DbParamsSProduce("@EngineType", engineType.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@FuelType", fuelType.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@EngineDisplacement", engineDisplacement.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@Weigth", weigth.Value, SqlDbType.Decimal),
                new DbParamsSProduce("@TopSpeed", topSpeed.Value, SqlDbType.Decimal),
                new DbParamsSProduce("@Acceleration", acceleration.Value, SqlDbType.Decimal),
                new DbParamsSProduce("@VehiclesId", id.Text, SqlDbType.Int)
            };
            int data = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[UpdateSpecificationByVehiclesId]", paramSpec);
            if (data == 0 || data == -1)
            {
                return false;
            }
            // Update vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;

            var paramVehicles = new List<DbParamsSProduce> {
                new DbParamsSProduce("@VehicleName", name.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@LiscensePlate", liscensePlate.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@Color", color.Text, SqlDbType.NVarChar),
                new DbParamsSProduce("@ManufacturesId", manufacture.ID, SqlDbType.Int),
                new DbParamsSProduce("@OwnerId", ownerData.ID, SqlDbType.Int),
                new DbParamsSProduce("@VehiclesId", id.Text, SqlDbType.Int),
                new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int)
            };
            int data2 = AppDBContext.Context.ExecuteNonQueryProcedure(out msgError, "", "[dbo].[UpdateVehicles]", paramVehicles);
            if (data2 > 0) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Update, "Cập nhật xe " + name.Text);
            return data2 > 0;
        }

        public bool DeleteVehicles(out string msgError, string id, string updatedBy)
        {
            var param = new List<DbParamsSProduce> { new DbParamsSProduce("@VehiclesId", id, SqlDbType.Int), new DbParamsSProduce("@UpdatedBy", updatedBy, SqlDbType.Int) };
            object data = AppDBContext.Context.ExecuteScalarProcedure(out msgError, "", "[dbo].[DeleteVehicleById]", param);
            if(data != null) ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Delete, "Xóa xe " + data.ToString());
            return data!=null;
        }

        
    }
}
