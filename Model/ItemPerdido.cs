using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Model
{
    public class ItemPerdido
    {
        public int id_item { get; set; }
        public string tipo { get; set; }
        public string marcar { get; set; }
        public string descricao { get; set; }
        public string local_perda { get; set; }
        public string imagem_url { get; set; }
        public int id_usuario { get; set; }

        public static ItemPerdido ItemFromDataReader(MySqlDataReader reader)
        {
            return new ItemPerdido
            {
                id_item = Convert.ToInt32(reader["id_item"].ToString()),
                tipo = reader["tipo"].ToString(),
                marcar = reader["marcar"].ToString(),
                descricao = reader["descricao"].ToString(),
                local_perda = reader["local_perda"].ToString(),
                imagem_url = reader["imagem_url"].ToString(),
                id_usuario = Convert.ToInt32(reader["id_usuario"].ToString())
            };
        }
    }
}
