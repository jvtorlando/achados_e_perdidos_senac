using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Controllers;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Repositorios;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac.Screen
{
    public partial class telaCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;

        public telaCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(new UsuarioRepositorio(new DatabaseService()));
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJaTemCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login FrmLogin = new login();
            FrmLogin.Show();
            this.Hide();
            return;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.nome = txtCadastroNome.Text;
            usuario.cpf = txtCadastroCpf.Text;
            usuario.email = txtCadastroEmail.Text;
            usuario.senha = txtCadastroSenha.Text;
            usuario.telefone = txtCadastroTelefone.Text;

          bool result =  _usuarioController.CadastrarUsuario(usuario);

            if (result)
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
                //FEchar a tela e mandar para tela de login
            }
            else {

                MessageBox.Show("Erro ao cadastrar usuário");

            }

        }
    }
}
