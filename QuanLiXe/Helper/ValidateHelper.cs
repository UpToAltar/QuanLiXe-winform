using DevExpress.XtraEditors;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.Helper
{
    internal class ValidateHelper
    {
        private static ValidateHelper checkLogin;

        public static ValidateHelper Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new ValidateHelper();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private ValidateHelper() { }
        public bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            return true;
        }

        public bool IsEmptyTextBox(List<TextBox> list)
        {
            foreach (var item in list)
            {
                if (item.Text == "") return true;
            }
            return false;
        }
        public bool IsEmptyTextEdit(List<TextEdit> list)
        {
            foreach (var item in list)
            {
                if (item.Text == "") return true;
            }
            return false;
        }

        public bool IsValidMaxLengthTextBox(List<TextBox> list, int maxLength)
        {
            foreach (var item in list)
            {
                if (item.Text.Length > maxLength) return false;
            }
            return true;
        }

        public bool IsValidMaxLengthTextEdit(List<TextEdit> list, int maxLength)
        {
            foreach (var item in list)
            {
                if (item.Text.Length > maxLength) return false;
            }
            return true;
        }

        public bool IsValidMinMax(decimal value, int min, int max)
        {
            
            return value > 0 && value < 1000000;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra số điện thoại
            string pattern = @"^\+?[0-9]\d{1,11}$";

            // Tạo đối tượng Regex với pattern
            Regex regex = new Regex(pattern);

            // Kiểm tra sự khớp của số điện thoại với pattern
            return regex.IsMatch(phoneNumber);
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
