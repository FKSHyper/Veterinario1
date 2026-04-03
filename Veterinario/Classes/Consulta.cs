using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinario.Classes;
using Veterinario.DAL;

namespace Veterinario.Classes
{
    internal class Consulta
    {
        public int ConsultaID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Data { get; set; }
        public string Motivo { get; set; }

        //private Animal animal;
        //private Cliente cliente;
        public Consulta(DateTime data, string motivo, int animalID)
        {
            Data = data;
            Motivo = motivo;
            //this.animal = animal;
            //this.cliente = cliente;
            AnimalID = animalID;
        }

        // Função para obter um dado específico de uma consulta
        public string GetDetalhesConsulta(int idConsulta)
        {
            string sql = "SELECT Observacoes FROM Consulta WHERE ConsultaID = @id";
            SqlParameter[] p = { new SqlParameter("@id", idConsulta) };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Observacoes"].ToString();
            }
            return "Nenhuma observação encontrada.";
        }
    }
}
