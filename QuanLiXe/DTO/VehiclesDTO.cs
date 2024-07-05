using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DTO
{
    internal class VehiclesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LiscensePlate { get; set; }
        public string Color { get; set; }

        public string Manufacture { get; set; }

        public string OwnerName { get; set; }

        public string OwnerEmail { get; set; }

        public string EngineType { get; set; }

        public string FuelType { get; set; }

        public float Weigth { get; set; }

        public float TopSpeed { get; set; }

        public float Acceleration { get; set; }

        public string EngineDisplacement { get; set; }
        public VehiclesDTO(DataRow data)
        {
            this.ID = Int32.Parse(data["VehiclesId"].ToString());
            this.Name = data["VehicleName"].ToString();
            this.LiscensePlate = data["LiscensePlate"].ToString();
            this.Color = data["Color"].ToString();
            this.Manufacture = data["ManufactureName"].ToString();
            this.OwnerName = data["OwnerName"].ToString();
            this.OwnerEmail = data["OwnerEmail"].ToString();
            this.EngineType = data["EngineType"].ToString();
            this.FuelType = data["FuelType"].ToString();
            this.Weigth = float.Parse(data["Weigth"].ToString());
            this.TopSpeed = float.Parse(data["TopSpeed"].ToString());
            this.Acceleration = float.Parse(data["Acceleration"].ToString());
            this.EngineDisplacement = data["EngineDisplacement"].ToString();

        }
    }

    internal class VehiclesUpdateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LiscensePlate { get; set; }
        public string Color { get; set; }

        public ManufacturesDTO Manufacture { get; set; }

        public OwnerDTO Owner { get; set; }

        public string EngineType { get; set; }

        public string FuelType { get; set; }

        public float Weigth { get; set; }

        public float TopSpeed { get; set; }

        public float Acceleration { get; set; }

        public string EngineDisplacement { get; set; }
        public VehiclesUpdateDTO(DataRow data)
        {
            this.ID = Int32.Parse(data["VehiclesId"].ToString());
            this.Name = data["VehicleName"].ToString();
            this.LiscensePlate = data["LiscensePlate"].ToString();
            this.Color = data["Color"].ToString();
            this.Manufacture = new ManufacturesDTO()
            {
                ID = Int32.Parse(data["ManufacturesId"].ToString()),
                Name = data["ManufactureName"].ToString()
            };

            this.Owner= new OwnerDTO()
            {
                ID = data["OwnerId"].ToString(),
                FullName = data["OwnerName"].ToString(),
                Email = data["OwnerEmail"].ToString()
            };
            this.EngineType = data["EngineType"].ToString();
            this.FuelType = data["FuelType"].ToString();
            this.Weigth = float.Parse(data["Weigth"].ToString());
            this.TopSpeed = float.Parse(data["TopSpeed"].ToString());
            this.Acceleration = float.Parse(data["Acceleration"].ToString());
            this.EngineDisplacement = data["EngineDisplacement"].ToString();

        }
    }
}
