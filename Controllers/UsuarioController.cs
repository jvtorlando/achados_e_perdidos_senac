using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Repositorios;

namespace achados_e_perdidos_senac.Controllers
{
    internal class UsuarioController
    {
        private UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public bool CadastrarUsuario(Usuario usuario) {

           bool result = _usuarioRepositorio.CriarNovoUsuario(usuario, usuario.senha);

            if (result == false)
            {
                return false;
            }

            return true;
        }


    }
}
