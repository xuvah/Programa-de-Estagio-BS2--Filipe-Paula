using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Programa_de_Estagio_BS2__Filipe_Paula.Models
{
    public class Cliente
    {
     

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Cad { get; set; }

        public static List<Cliente> Todos()
        {
            var lista = new List<Cliente>();
            SqlConnection conn = new SqlConnection(Conexao.Dados);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * FROM Clientes", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(item: new Cliente
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Data_Cad = (DateTime)reader["Data_Cad"]
                });
            }
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return lista;
        }
    }
}
