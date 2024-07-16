using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DTO
{
    internal class ManufacturesDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ManufacturesDTO(DataRow data)
        {
            this.ID = Int32.Parse(data["ManufacturesId"].ToString());
            this.Name = data["Name"].ToString();
            this.CreatedAt = DateTime.Parse(data["CreatedAt"].ToString());
            this.UpdatedAt = DateTime.Parse(data["UpdatedAt"].ToString());
        }

        public ManufacturesDTO()
        {
        }
    }
}
