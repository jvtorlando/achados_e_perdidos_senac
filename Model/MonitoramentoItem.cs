using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Model
{
    public class MonitoramentoItem
    {
        public int id_monitoramento { get; set; }
        public int id_item { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_monitoramento { get; set; }
        public string status_monitoramento { get; set; } // Você pode criar um enum para isso, se desejar
        public string observacoes { get; set; }

        public static MonitoramentoItem MonitoramentoFromDataReader(MySqlDataReader reader)
        {
            return new MonitoramentoItem
            {
                id_monitoramento = Convert.ToInt32(reader["id_monitoramento"].ToString()),
                id_item = Convert.ToInt32(reader["id_item"].ToString()),
                id_usuario = Convert.ToInt32(reader["id_usuario"].ToString()),
                data_monitoramento = Convert.ToDateTime(reader["data_monitoramento"].ToString()),
                status_monitoramento = reader["status_monitoramento"].ToString(),
                observacoes = reader["observacoes"].ToString()
            };
        }
    }
}
