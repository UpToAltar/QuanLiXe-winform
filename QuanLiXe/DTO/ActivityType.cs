using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DTO
{
    internal class ActivityType
    {
        public const string Register = "Đăng kí";
        public const string Login = "Đăng nhập";
        public const string Add = "Thêm mới";
        public const string Update = "Cập nhật";
        public const string Delete = "Xóa";
        public const string Search = "Tìm kiếm";
        public const string View = "Xem";
        public const string Export = "Xuất file";
        public const string ResetPassword = "Đổi mật khẩu";

        public static List<string> GetAllConstantValues()
        {
            List<string> values = new List<string>();

            // Get all fields of the class
            FieldInfo[] fields = typeof(ActivityType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (FieldInfo field in fields)
            {
                // Check if the field is a constant
                if (field.IsLiteral && !field.IsInitOnly && field.FieldType == typeof(string))
                {
                    string value = field.GetRawConstantValue() as string;
                    if (value != null)
                    {
                        values.Add(value);
                    }
                }
            }

            return values;
        }
    }
}
