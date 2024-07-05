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
        private static AutomakerServices checkLogin;

        public static AutomakerServices Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new AutomakerServices();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private AutomakerServices() { }

        public bool CheckName(string name)
        {
            string query = $"SELECT * FROM Manufactures WHERE Name = N'{name}'";
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
            string query = $"SELECT * FROM Manufactures WHERE ManufacturesId = {id}";
            var data = AppDBContext.Context.GetDataTypeIntFromQuery(query);
            if (data == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckFindByName(string name)
        {
            
            string query = $"SELECT * FROM Manufactures WHERE Name = N'{name}'";
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

        public DataTable Search(string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                string query1 = $"SELECT * FROM Manufactures WHERE ManufacturesId = {id} ";
                var data1= AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"SELECT * FROM Manufactures WHERE Name LIKE N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"SELECT TOP 100 * FROM Manufactures";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable GetVehiclesByAutomakerName(string name)
        {
            string query = $"SELECT" +
                $" v.VehiclesId, v.VehicleName, v.LiscensePlate, v.Color, " +
                $"m.Name as ManufactureName,m.ManufacturesId as ManufacturesId , o.FullName as OwnerName,o.OwnerId as OwnerId , o.Email as OwnerEmail," +
                $"s.EngineType, s.FuelType , s.Weigth, s.TopSpeed, s.Acceleration, s.EngineDisplacement" +
                $" FROM Vehicles AS v " +
                $"JOIN Specifications AS s" +
                $" ON s.SpecificationsId = v.SpecificationsId " +
                $"JOIN Manufactures AS m" +
                $" ON m.ManufacturesId = v.ManufacturesId " +
                $"JOIN Owners AS o" +
                $" ON o.OwnerId = v.OwnerId " +
                $"WHERE m.Name = N'{name}'";

            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }
    }
}
