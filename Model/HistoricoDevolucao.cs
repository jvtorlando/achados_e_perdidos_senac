using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Model
{
    public class HistoricoDevolucao
    {
        public int id_devolucao { get; set; }
        public int id_item { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_devolucao { get; set; }

        public static HistoricoDevolucao HistoricoFromDataReader(MySqlDataReader reader)
        {
            return new HistoricoDevolucao
            {
                id_devolucao = Convert.ToInt32(reader["id_devolucao"].ToString()),
                id_item = Convert.ToInt32(reader["id_item"].ToString()),
                id_usuario = Convert.ToInt32(reader["id_usuario"].ToString()),
                data_devolucao = Convert.ToDateTime(reader["data_devolucao"].ToString())
            };
        }
    }
}
