using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DTO
{
    internal class UserDTO
    {
        private string username;
        private string displayname;
        private string role;
        private string password;
        private bool isActive;
        private DateTime CreatedAt;
        private DateTime UpdatedAt;


        public string Name { get => username; set => username = value; }
        public string DisplayName { get => displayname; set => displayname = value; }
        public string Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }

        public bool IsActive { get => isActive; set => isActive = value; }

        public UserDTO(DataRow data)
        {
            this.username = data["UserName"].ToString();
            this.displayname = data["DisplayName"].ToString();
            this.role = data["Role"].ToString();
            this.password = data["Password"].ToString();
            this.isActive = int.Parse(data["IsActive"].ToString()) == 1 ? true : false ;
            this.CreatedAt = DateTime.Parse(data["CreatedAt"].ToString());
            this.UpdatedAt = DateTime.Parse(data["UpdatedAt"].ToString());
        }
    }
}
