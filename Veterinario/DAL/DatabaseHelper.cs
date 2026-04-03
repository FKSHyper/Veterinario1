using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario.DAL
{
    internal class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State != ConnectionState.Open) conn.Open();
            return conn;
        }

        public static int ExecuteCommand(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show("Erro SQL Real: " + ex.Message);
                return -1; 
            }
        }

        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                {
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        { 
                            cmd.Parameters.AddRange(parameters); 
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 
                System.Windows.Forms.MessageBox.Show("Erro na consulta: " + ex.Message); 
            }
            return dt;
        }
    }
}



