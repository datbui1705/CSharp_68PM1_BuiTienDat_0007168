using System;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace CSharp_68PM1_BuiTienDat_0007168
{
    public class Database
    {
        private static string connectionString = @"Data Source=_DAT1705;Initial Catalog=QLSV_DB;User ID=sa;Password=123456789;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            conn.Open();
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("Lỗi kết nối CSDL!" + ex.Message, "Lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return dataTable;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Lỗi thực thi lệnh: " + ex.Message, "Lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
            return rowsAffected;
        }
    }
}