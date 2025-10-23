using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QLThuVien
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Hàm trả về kết nối (mở sẵn)
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Hàm lấy dữ liệu (SELECT)
        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                 
                    SqlDataAdapter da = new SqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                
            }
        }
        public static DataTable GetData(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Hàm thực thi lệnh không trả dữ liệu (INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.ExecuteNonQuery();
            }
        }
        public static int ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return 0;

                // Thử parse an toàn
                int outInt;
                if (int.TryParse(result.ToString(), out outInt))
                    return outInt;

                // Nếu result là numeric nhưng không parse thành int trực tiếp (vd decimal/long), chuyển bằng Convert và catch
                try
                {
                    return Convert.ToInt32(result);
                }
                catch
                {
                    // fallback: nếu không chuyển được, trả 0 (hoặc bạn có thể throw nếu muốn)
                    return 0;
                }
            }
        }
    }
}
