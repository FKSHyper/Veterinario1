using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Veterinario.DAL
{
    internal class FiltroUsuario
    {
        public DataTable FiltrarDados(string busca)
        {
            string sql = "SELECT * FROM Cliente WHERE nif LIKE @busca";

            SqlParameter[] ps = {
                new SqlParameter("@busca", "%" + busca + "%")
            };

            return DatabaseHelper.ExecuteQuery(sql, ps);
        }
    }
}
