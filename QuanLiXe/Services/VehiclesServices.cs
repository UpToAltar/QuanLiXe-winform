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
            string query = $"SELECT * FROM Vehicles WHERE LiscensePlate = N'{plate}'";
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
            string query = $"SELECT * FROM Vehicles WHERE VehiclesId = {id}";
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
                string query1 = QueryGetBase + $" WHERE v.VehiclesId = {id}";
                var data1 = AppDBContext.Context.GetDataFromQuery(query1);
                foreach (DataRow item in data1.Rows)
                {
                    list.Add(new VehiclesDTO(item));
                }
                return list;
                
            }
            string query = QueryGetBase + $"WHERE v.VehicleName LIKE N'%{name}%'";

            
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new VehiclesDTO(item));
            }
            return list;
        }

        public VehiclesUpdateDTO SearchById(string id)
        {
            string query = QueryGetBase + $" WHERE v.VehiclesId = {id}";
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
            string query = QueryGetBase;
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
            string query = $"SELECT * FROM Manufactures";
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
            string query = $"SELECT * FROM Owners";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new OwnerDTO(item));
            }
            return list;
        }

        public bool CheckPlateOther(string plate, string id)
        {
            string query = $"SELECT * FROM Vehicles WHERE LiscensePlate = N'{plate}' AND VehiclesId != {id}";
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
            string querySpecifications = $"INSERT INTO dbo.Specifications (EngineType, FuelType, Weigth, TopSpeed, Acceleration, EngineDisplacement) " +
                $"VALUES (N'{engineType.Text}', N'{fuelType.Text}', {weigth.Value}, {topSpeed.Value}, {acceleration.Value}, N'{engineDisplacement.Text}')";
            var data = AppDBContext.Context.NonQuery(querySpecifications);
            if (data == 0 || data== -1)
            {
                return false;
            }
            // Create vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;

            // Get specId
            string queryGetSpecId = $"SELECT TOP 1 SpecificationsId FROM dbo.Specifications ORDER BY SpecificationsId DESC";
            var data1 = AppDBContext.Context.GetDataFromQuery(queryGetSpecId);
            int specId = 0;
            foreach (DataRow item in data1.Rows)
            {
                specId = Int32.Parse(item["SpecificationsId"].ToString());
            }

            string queryCreateVehicles = $"INSERT INTO dbo.Vehicles (VehicleName, LiscensePlate, Color, ManufacturesId, OwnerId, SpecificationsId) " +
                $"VALUES (N'{name.Text}', N'{liscensePlate.Text}', N'{color.Text}', {manufacture.ID}, {ownerData.ID}, {specId})";
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
            string querySpecifications = $"UPDATE dbo.Specifications SET " +
                $"EngineType = N'{engineType.Text}', " +
                $"FuelType = N'{fuelType.Text}', " +
                $"Weigth = {weigth.Value}, " +
                $"TopSpeed = {topSpeed.Value}, " +
                $"Acceleration = {acceleration.Value}, " +
                $"EngineDisplacement = N'{engineDisplacement.Text}' " +
                $"WHERE SpecificationsId = " +
                $"(SELECT SpecificationsId FROM dbo.Vehicles WHERE VehiclesId = {id.Text})";
            var data = AppDBContext.Context.NonQuery(querySpecifications);
            if (data == 0 || data == -1)
            {
                return false;
            }

            // Update vehicles
            var manufacture = manufactures.SelectedItem as ManufacturesDTO;
            var ownerData = owner.SelectedItem as OwnerDTO;
            string queryUpdateVehicles = $"UPDATE dbo.Vehicles SET " +
                $"VehicleName = N'{name.Text}', " +
                $"LiscensePlate = N'{liscensePlate.Text}', " +
                $"Color = N'{color.Text}', " +
                $"ManufacturesId = {manufacture.ID}, " +
                $"OwnerId = {ownerData.ID} " +
                $"WHERE VehiclesId = {id.Text}";
            var data2 = AppDBContext.Context.NonQuery(queryUpdateVehicles);
            if (data2 == 0 || data2 == -1)
            {
                return false;
            }
            return true;
        }

        public bool DeleteVehicles(string id)
        {
            string query = $"DELETE FROM dbo.Vehicles WHERE VehiclesId = {id}";
            var data = AppDBContext.Context.NonQuery(query);
            if (data == 0 || data == -1)
            {
                return false;
            }
            return true;
        }
    }
}
