using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using QuanLiXe.Services;
namespace QuanLiXe.Helper
{
    public class PasswordHelper
    {
        private readonly IPasswordHasher<string> _passwordHasher = new PasswordHasher<string>();
        private static PasswordHelper instance;

        public static PasswordHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PasswordHelper();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private PasswordHelper()
        {
            
        }

        public string HashPassword(string plainTextPassword)
        {
            return _passwordHasher.HashPassword(null, plainTextPassword);
        }

        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(null, storedHashedPassword, enteredPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
