using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Model
{
    internal class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string curso { get; set; }
        public string sala { get; set; }
        public TipoUsuario tipo_usuario { get; set; }


        public enum TipoUsuario
        {
            Administrador,
            Professor,
            Aluno,
            Visitante
        }


        public static Usuario UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuario
            {
                id = Convert.ToInt32(reader["id"].ToString()),
                nome = reader["nome"].ToString(),
                email = reader["email"].ToString(),
                matricula = reader["matricula"].ToString(),
                telefone = reader["telefone"].ToString(),
                curso = reader["curso"].ToString(),
                sala = reader["sala"].ToString(),
                tipo_usuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), reader["tipo_usuario"].ToString()),
            };
           
           
              
        }
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
}
