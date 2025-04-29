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
       
       
       
    }
}
