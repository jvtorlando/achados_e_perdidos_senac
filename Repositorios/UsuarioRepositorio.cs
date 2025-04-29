using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Services;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Repositorios
{
    internal class UsuarioRepositorio
    {

        DatabaseService databaseService;

        public UsuarioRepositorio(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }


        public List<Usuario> getAllUser()
        {

            List<Usuario> usuarios = new List<Usuario>();

            try
            {

                string query = "SELECT * FROM usuarios JOIN regras on usuarios.idRegra = regras.idregra";
                MySqlDataReader resultadoBanco = databaseService.ExecuteQuery(query);

                while (resultadoBanco.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario = Usuario.UserFromDataReader(resultadoBanco);


                    usuarios.Add(usuario);
                }
                databaseService.CloseConnection();

                return usuarios;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuários: " + ex.Message);
            }


        }



    }
}
