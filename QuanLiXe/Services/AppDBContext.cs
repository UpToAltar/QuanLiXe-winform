using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting;
using QuanLiXe.DatabaseHelper;

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
        private const string CONNECTION_STRING = "Server=192.168.10.21,1468;Database=Intern_202406_V1;User Id=QuanDao;Password=QuanDao@123";


        private const string CONNECTION_STRING_LOCAL = "data source=DESKTOP-5EA7F83\\SQLEXPRESS;initial catalog=QuanLiXe;trusted_connection=true";
        

        public DataTable ExecuteNonQueryProcedureReturnDataTable(out string msgError, string sqlConnection, string sprocedureName)
        {
            DataTable dataTable = new DataTable();
            string strConnection = string.Empty;
            if (string.IsNullOrEmpty(sqlConnection))
                strConnection = CONNECTION_STRING;
            else
                strConnection = sqlConnection;
            //Tạo connection ở đây để có thể đóng khi try catch
            SqlConnection connection = new SqlConnection(strConnection);

            try
            {
                if (string.IsNullOrEmpty(CONNECTION_STRING))
                {
                    msgError = "Lỗi kết nối máy chủ! Xin vui lòng thử lại sau!";
                    return null;
                }

                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sprocedureName
                };
                //Mở connection
                connection.Open();
                command.Connection = connection;

                SqlDataAdapter adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataTable);
                command.Dispose();
                adapter1.Dispose();
                connection.Dispose();
                msgError = "";
            }
            catch (Exception exception)
            {
                dataTable = null;
                msgError = exception.ToString();
            }
            finally
            {
                connection.Dispose();
            }
            return dataTable;
        }

        /// <summary>
        /// Chạy Store Procedure truyền vào chuỗi tham số trả về dataTable
        /// </summary>
        /// <param name="msgError">Nếu bị lỗi sẽ trả về msgError</param>
        /// <param name="sprocedureName">Tên stored proceduce</param>
        /// <param name="paramObjects">"@Id", id, "@Ma", ma</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteSProcedureReturnDataTable(out string msgError, string sqlConnection, string sprocedureName, List<DbParamsSProduce> parameters)
        {
            DataTable dataTable = new DataTable();
            string strConnection = string.Empty;
            if (string.IsNullOrEmpty(sqlConnection))
                strConnection = CONNECTION_STRING;
            else
                strConnection = sqlConnection;
            //Tạo connection ở đây để có thể đóng khi try catch
            SqlConnection connection = new SqlConnection(strConnection);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sprocedureName,
                    Connection = connection,
                    CommandTimeout = 360
                };

                foreach (var item in parameters)
                {
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = item.Name,
                        Value = item.Value ?? DBNull.Value,
                        SqlDbType = item.Type
                    };
                    command.Parameters.Add(parameter);
                }

                SqlDataAdapter adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataTable);
                command.Dispose();
                adapter1.Dispose();
                connection.Dispose();
                msgError = "";
            }
            catch (Exception exception)
            {
                dataTable = null;
                msgError = exception.ToString();
            }
            finally
            {
                connection.Dispose();
            }
            return dataTable;
        }

        public int ExecuteNonQueryProcedure(out string msgError, string sqlConnection, string sprocedureName, List<DbParamsSProduce> parameters)
        {
            DataTable dataTable = new DataTable();
            string strConnection = string.Empty;
            if (string.IsNullOrEmpty(sqlConnection))
                strConnection = CONNECTION_STRING;
            else
                strConnection = sqlConnection;
            //Tạo connection ở đây để có thể đóng khi try catch
            SqlConnection connection = new SqlConnection(strConnection);

            int success = 0;
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = sprocedureName;
                    command.Transaction = transaction;
                    command.Connection = connection;
                    foreach (var item in parameters)
                    {
                        SqlParameter parameter = new SqlParameter
                        {
                            ParameterName = item.Name,
                            Value = item.Value ?? DBNull.Value,
                            SqlDbType = item.Type
                        };
                        command.Parameters.Add(parameter);
                    }
                    success = command.ExecuteNonQuery();
                    command.Dispose();
                    transaction.Commit();
                    msgError = "";
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    success = 0;
                    dataTable = null;
                    msgError = exception.ToString();
                }
                return success;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return 0;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public object ExecuteScalarProcedure(out string msgError, string sqlConnection, string sprocedureName, List<DbParamsSProduce> parameters)
        {
            DataTable dataTable = new DataTable();
            string strConnection = string.Empty;
            if (string.IsNullOrEmpty(sqlConnection))
                strConnection = CONNECTION_STRING;
            else
                strConnection = sqlConnection;
            //Tạo connection ở đây để có thể đóng khi try catch
            SqlConnection connection = new SqlConnection(strConnection);

            object success = 0;
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = sprocedureName;
                    command.Transaction = transaction;
                    command.Connection = connection;
                    foreach (var item in parameters)
                    {
                        SqlParameter parameter = new SqlParameter
                        {
                            ParameterName = item.Name,
                            Value = item.Value ?? DBNull.Value,
                            SqlDbType = item.Type
                        };
                        command.Parameters.Add(parameter);
                    }
                    success = command.ExecuteScalar();
                    command.Dispose();
                    transaction.Commit();
                    msgError = "";
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    success = 0;
                    dataTable = null;
                    msgError = exception.ToString();
                }
                return success;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return 0;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
