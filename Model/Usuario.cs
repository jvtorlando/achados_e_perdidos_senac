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
        public string email { get; set; }
        public string senha { get; set; }

        public string cpf { get; set; }
        public string telefone { get; set; }
        //public TipoUsuario tipo_usuario { get; set; }


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
                id = Convert.ToInt32(reader["id_usuario"].ToString()),
                nome = reader["nome"].ToString(),
                email = reader["email"].ToString(),
                cpf = reader["cpf"].ToString(),
                senha = reader["senha"].ToString(),
                telefone = reader["telefone"].ToString(),
            };
           
           
              
        }
       
       
       
    }
}
