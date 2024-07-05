using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.Services
{
    public class AppDBContext
    {
        private static AppDBContext context;

        public static AppDBContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new AppDBContext();
                }
                return context;
            }

            private set
            {
                context = value;
            }
        }

        private AppDBContext() { }

        public const string connectionStr = "data source=DESKTOP-5EA7F83\\SQLEXPRESS;initial catalog=QuanLiXe;trusted_connection=true";
        public DataTable GetDataFromQuery(string query)
        {

            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader data = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(data);
                connection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int GetDataTypeIntFromQuery(string query)
        {

            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader data = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(data);
                connection.Close();
                return dataTable.Rows.Count;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int NonQuery(string query)
        {
            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thực thi lệnh INSERT và trả về số hàng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {

                    return -1; // Trả về -1 để chỉ ra lỗi
                }
                finally
                {

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
