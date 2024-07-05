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

        public string Name { get => username; set => username = value; }
        public string DisplayName { get => displayname; set => displayname = value; }
        public string Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }

        public UserDTO(DataRow data)
        {
            this.username = data["UserName"].ToString();
            this.displayname = data["DisplayName"].ToString();
            this.role = data["Role"].ToString();
            this.password = data["Password"].ToString();
        }
    }
}
