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
        public string categoria { get; set; }
        public string descricao { get; set; }
        public string andar { get; set; }
        public string imagem_url { get; set; }
        public DateTime data { get; set; }

        public static ItemPerdido ItemFromDataReader(MySqlDataReader reader)
        {
            return new ItemPerdido
            {
                id_item = Convert.ToInt32(reader["id_item"]),
                categoria = reader["categoria"].ToString(),
                descricao = reader["descricao"].ToString(),
                andar = reader["andar"].ToString(),
                imagem_url = reader["imagem_url"].ToString(),
                data = Convert.ToDateTime(reader["data"]),
            };
        }
    }
}
