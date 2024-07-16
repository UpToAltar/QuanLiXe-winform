using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DTO
{
    internal class OwnerDTO
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        

        public OwnerDTO(DataRow data)
        {
            this.PhoneNumber = data["PhoneNumber"].ToString();
            this.ID = data["OwnerId"].ToString();
            this.FullName = data["FullName"].ToString();
            this.Email = data["Email"].ToString();
            this.Address = data["Address"].ToString();
            this.CreatedAt = DateTime.Parse(data["CreatedAt"].ToString());
            this.UpdatedAt = DateTime.Parse(data["UpdatedAt"].ToString());

        }
        public OwnerDTO()
        {
        }
    }
}
