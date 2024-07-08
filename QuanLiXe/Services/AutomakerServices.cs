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
            string query = $"EXEC GetManufacturesByName @Name = N'{name}'";
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
            string query = $"EXEC GetManufacturesById @Id = {id}";
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

        public bool CreateAutomaker(string name, string icon)
        {
            string query = $"EXEC CreateManufacture @Name = N'{name}', @Icon = '{icon}'";
            return GetSuccessQuery(query);
        }

        public bool UpdateAutomaker(string id, string name, string icon)
        {
            string query = $"EXEC UpdateManufacture @Name = N'{name}', @Icon = '{icon}', @Id = {id}";
            return GetSuccessQuery(query);
        }

        public bool DeleteAutomaker(string id)
        {
            string query = $"EXEC DeleteManufactureById @Id = {id}";
            return GetSuccessQuery(query);
        }

        public DataTable Search(string name)
        {
            int id = 0;
            if (int.TryParse(name, out id))
            {
                string query1 = $"EXEC GetManufacturesById @Id = {id}";
                var data1= AppDBContext.Context.GetDataFromQuery(query1);
                return data1;
            }
            string query = $"EXEC SearchManufactureByName @Name = N'%{name}%'";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable Load()
        {
            string query = $"EXEC GetAllManufactures";
            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }

        public DataTable GetVehiclesByAutomakerName(string name)
        {
            string query = $"EXEC GetVehiclesByManufactureName @ManufactureName = N'{name}'";

            var data = AppDBContext.Context.GetDataFromQuery(query);
            return data;
        }
    }
}
