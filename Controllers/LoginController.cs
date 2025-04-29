using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac.Controllers
{
    internal class LoginController
    {

        private Services.AuthService _authService;

        public LoginController(AuthService authService)
        {
            _authService = authService;
        }

        public Usuario Login(string email, string password)
        {
            try
            {
              Usuario usuario = _authService.AutenticarLogin(email, password);

                if (usuario == null)
                {
                    MessageBox.Show("Login não realizado. Tente novamente");
                    return null;
                }

                return usuario;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao tentar fazer login: " + ex.Message);
                return null;
                
            }

        }

    }
}
