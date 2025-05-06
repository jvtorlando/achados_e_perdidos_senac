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
                login FrmLogin = new login();
                FrmLogin.Show();
                this.Close();
            }
            else {

                MessageBox.Show("Erro ao cadastrar usuário");

            }

        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Nome)
        private void txtCadastroNome_MouseEnter(object sender, EventArgs e)
        {
            if (txtCadastroNome.Text == "Nome")
            {
                txtCadastroNome.Text = "";
                txtCadastroNome.ForeColor = Color.Black;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Nome)
        private void txtCadastroNome_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroNome.Text))
            {
                txtCadastroNome.Text = "Nome";
                txtCadastroNome.ForeColor = Color.DarkGray;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Email)
        private void txtCadastroEmail_MouseEnter(object sender, EventArgs e)
        {
            if (txtCadastroEmail.Text == "Email")
            {
                txtCadastroEmail.Text = "";
                txtCadastroEmail.ForeColor = Color.Black;
            }
        
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Email)
        private void txtCadastroEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroEmail.Text))
            {
                txtCadastroEmail.Text = "Email";
                txtCadastroEmail.ForeColor = Color.DarkGray;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Telefone)
        private void txtCadastroTelefone_MouseEnter(object sender, EventArgs e)
        {
            if (txtCadastroTelefone.Text == "Telefone")
            {
                txtCadastroTelefone.Text = "";
                txtCadastroTelefone.ForeColor = Color.Black;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Telefone)
        private void txtCadastroTelefone_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroTelefone.Text))
            {
                txtCadastroTelefone.Text = "Telefone";
                txtCadastroTelefone.ForeColor = Color.DarkGray;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Senha)
        private void txtCadastroSenha_MouseEnter(object sender, EventArgs e)
        {
            if (txtCadastroSenha.Text == "Senha")
            {
                txtCadastroSenha.Text = "";
                txtCadastroSenha.ForeColor = Color.Black;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (Senha)
        private void txtCadastroSenha_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroSenha.Text))
            {
                txtCadastroSenha.Text = "Senha";
                txtCadastroSenha.ForeColor = Color.DarkGray;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (CPF)
        private void txtCadastroCpf_MouseEnter(object sender, EventArgs e)
        {
            if (txtCadastroCpf.Text == "CPF")
            {
                txtCadastroCpf.Text = "";
                txtCadastroCpf.ForeColor = Color.Black;
            }
        }
        //Ocultar nome do campo de preenchimento de campo ao coloar mouse encima (CPF)
        private void txtCadastroCpf_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroCpf.Text))
            {
                txtCadastroCpf.Text = "CPF";
                txtCadastroCpf.ForeColor = Color.DarkGray;
            }
        }
    }
}
