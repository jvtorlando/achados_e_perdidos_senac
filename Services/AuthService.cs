using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achados_e_perdidos_senac.Model;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Services
{
    internal class AuthService
    {

        private DatabaseService _databaseService;

        public AuthService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario AutenticarLogin(string email, string password)
        {
            try
            {
                // Primeiro busca o usuário pelo email
                string query = "SELECT * FROM usuario WHERE email = @emailDigitado AND senha = @senhaDigitada";
                var parameters = new MySqlParameter[]
                {

                    new MySqlParameter("@emailDigitado", email),
                    new MySqlParameter("@senhaDigitada", password),

                };

                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())

                    {
                                                                  
                            Usuario usuario = new Usuario();
                            usuario = Usuario.UserFromDataReader(respostaBanco);

                            return usuario;
                        
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante autenticação: " + ex.Message);
            }
        }
    }
}
