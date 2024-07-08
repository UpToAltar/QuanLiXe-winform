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

        private static string QueryGetBase = $"SELECT" +
                $" TOP 100 v.VehiclesId, v.VehicleName, v.LiscensePlate, v.Color, " +
                $"m.Name as ManufactureName,m.ManufacturesId as ManufacturesId , o.FullName as OwnerName,o.OwnerId as OwnerId , o.Email as OwnerEmail," +
                $"s.EngineType, s.FuelType , s.Weigth, s.TopSpeed, s.Acceleration, s.EngineDisplacement" +
                $" FROM Vehicles AS v " +
                $"JOIN Specifications AS s" +
                $" ON s.SpecificationsId = v.SpecificationsId " +
                $"JOIN Manufactures AS m" +
                $" ON m.ManufacturesId = v.ManufacturesId " +
                $"JOIN Owners AS o" +
                $" ON o.OwnerId = v.OwnerId ";

        private VehiclesServices() { }

        public bool CheckPlate(string plate)
        {
            string query = $"EXEC FindVehiclesByPlate @LiscensePlate = '{plate}'";
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
            string query = $"EXEC FindVehiclesById @Id = {id}";
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

        public List<VehiclesDTO> Search(string name)
        {
            int id = 0;
            var list = new List<VehiclesDTO>();
            if (int.TryParse(name, out id))
            {
                string query1 = $"EXEC GetVehiclesByIdOrSearchByName @Id = {id},@Name = N'', @Type = 1";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                foreach (DataRow item in data1.Rows)
                {
                    list.Add(new VehiclesDTO(item));
                }
                return list;
                
            }
            string query = $"EXEC GetVehiclesByIdOrSearchByName @Id = 0,@Name = N'%{name}%', @Type = 2"; ;

            
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new VehiclesDTO(item));
            }
            return list;
        }

        public VehiclesUpdateDTO SearchById(string id)
        {
            string query = $"EXEC GetVehiclesByIdOrSearchByName @Id = {id},@Name = N'', @Type = 1";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                var dto = new VehiclesUpdateDTO(item);
                return dto;
            }
            return null;
        }

        public List<VehiclesDTO> Load()
        {
            var list = new List<VehiclesDTO>();
            string query = "EXEC GetAllVehicles";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new VehiclesDTO(item));
            }
            return list ;
        }

        public List<ManufacturesDTO> LoadManufactures()
        {
            var list = new List<ManufacturesDTO>();
            string query = $"EXEC GetAllManufactures";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new ManufacturesDTO(item));
            }
            return list;
        }

        public List<OwnerDTO> LoadOwners()
        {
            var list = new List<OwnerDTO>();
            string query = $"EXEC GetAllOwner";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new OwnerDTO(item));
            }
            return list;
        }

        public bool CheckPlateOther(string plate, string id)
        {
            string query = $"EXEC FindVehiclesByPlateNotById @LiscensePlate = '{plate}', @Id = {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }


        public bool CreateVehicles(TextBox color, TextBox engineDisplacement, TextBox engineType, TextBox fuelType, TextBox liscensePlate, TextBox name, NumericUpDown acceleration, NumericUpDown weigth, NumericUpDown topSpeed,ComboBox manufactures, ComboBox owner)
        {
            // Create specifications
            string querySpecifications = $"EXEC CreateSpecification " +
                $"@EngineType = N'{engineType.Text}', @FuelType= N'{fuelType.Text}', " +
                $"@EngineDisplacement = N'{engineDisplacement.Text}', " +
                $"@Weigth = {weigth.Value}, @TopSpeed = {topSpeed.Value}, @Acceleration = {acceleration.Value}";
            var data = AppDBContext.Context.NonQuery(querySpecifications);
            if (data == 0 || data== -1)
            {
                return false;
            }
            // Create vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;

            // Get specId
            string queryGetSpecId = $"EXEC GetSpecificationId ";
            var data1 = AppDBContext.Context.GetDataFromQuery(queryGetSpecId);
            int specId = 0;
            foreach (DataRow item in data1.Rows)
            {
                specId = Int32.Parse(item["SpecificationsId"].ToString());
            }

            string queryCreateVehicles = $"EXEC CreateVehicle" +
                $" @VehicleName = N'{name.Text}', @LiscensePlate = N'{liscensePlate.Text}', " +
                $"@Color= N'{color.Text}', @ManufacturesId={manufacture.ID}, @OwnerId = {ownerData.ID}, @SpecificationsId = {specId}";
            var data2 = AppDBContext.Context.NonQuery(queryCreateVehicles);
            if (data2 == 0 || data2 == -1)
            {
                return false;
            }

            
            return true;
        }

        public bool UpdateVehicles(TextBox color, TextBox engineDisplacement, TextBox engineType, TextBox fuelType, TextBox liscensePlate, TextBox name, NumericUpDown acceleration, NumericUpDown weigth, NumericUpDown topSpeed, ComboBox manufactures, ComboBox owner,TextBox id)
        {
            //Update specifications
            string querySpecifications = $"EXEC UpdateSpecificationByVehiclesId " +
                $"@EngineType = N'{engineType.Text}', @FuelType= N'{fuelType.Text}', " +
                $"@EngineDisplacement = N'{engineDisplacement.Text}', @Weigth = {weigth.Value}," +
                $" @TopSpeed = {topSpeed.Value}, @Acceleration = {acceleration.Value}," +
                $" @VehiclesId = {id.Text}";
            var data = AppDBContext.Context.NonQuery(querySpecifications);
            if (data == 0 || data == -1)
            {
                return false;
            }

            // Update vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;
            string queryUpdateVehicles = $"EXEC UpdateVehicles " +
                $"@VehicleName = N'{name.Text}' , @LiscensePlate = N'{liscensePlate.Text}'," +
                $"@Color = N'{color.Text}', @ManufacturesId = {manufacture.ID}, " +
                $"@OwnerId = {ownerData.ID}, @VehiclesId = {id.Text}";
            var data2 = AppDBContext.Context.NonQuery(queryUpdateVehicles);
            if (data2 == 0 || data2 == -1)
            {
                return false;
            }
            return true;
        }

        public bool DeleteVehicles(string id)
        {
            string query = $"EXEC DeleteVehicleById @VehiclesId = {id}";
            var data = AppDBContext.Context.NonQuery(query);
            if (data == 0 || data == -1)
            {
                return false;
            }
            return true;
        }
    }
}
