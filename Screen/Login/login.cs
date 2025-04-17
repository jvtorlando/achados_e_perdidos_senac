using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using achados_e_perdidos_senac.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace achados_e_perdidos_senac
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;

            txtUsuario.Text = "Digite seu nome de usuário";
            txtUsuario.ForeColor = Color.Gray;
            txtSenha.Text = "Digite sua senha";
            txtSenha.ForeColor = Color.Gray;
            txtSenha.UseSystemPasswordChar = false; 

            
            txtUsuario.Enter += RemovePlaceholderUsuario;
            txtUsuario.Leave += RestorePlaceholderUsuario;
            txtSenha.Enter += RemovePlaceholderSenha;
            txtSenha.Leave += RestorePlaceholderSenha;

            txtSenha.TextChanged += txtSenha_TextChanged;

            btnLogin.Click += btnLogin_Click_1;

        }

        private Size originalSize;
        private Point originalLocation;

        private void linkLabelEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           string message = "Se esqueceu sua senha ou login, entre em contato com:\n\n" +
                 "• Suporte técnico: pedido@sp.senac.br\n" +
                 "• Telefone: (11) 2187-4450\n\n" +
                 "Horário de atendimento: 08h às 21h";

            MessageBox.Show(
                message,
                "Recuperação de Acesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void lblTexto1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "Digite sua senha" && !string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemovePlaceholderUsuario(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Digite seu nome de usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void RestorePlaceholderUsuario(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Digite seu nome de usuário";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderSenha(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite sua senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void RestorePlaceholderSenha(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = "Digite sua senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            
            string User = "senac";
            string Password = "senac123";

            if (!ValidarCampos())
                return;

            if (txtUsuario.Text == "Digite seu nome de usuário" || txtSenha.Text == "Digite sua senha")
            {
                MessageBox.Show("Por favor, preencha ambos os campos corretamente");
                return;
            }

            if (txtUsuario.Text.Trim() == User && txtSenha.Text.Trim() == Password)
            {
                Home FrmHome = new Home();
                FrmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos. Por favor, tente novamente.",
                    "Falha no Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        } 

        private bool ValidarCampos()
        {
            // Verifica se o usuário está vazio ou é o placeholder
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "Digite seu nome de usuário")
            {
                MessageBox.Show("Por favor, insira um usuário válido!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus(); // Foca no campo usuário
                return false;
            }

            // Verifica se a senha está vazia ou é o placeholder
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text == "Digite sua senha")
            {
                MessageBox.Show("Por favor, insira sua senha!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus(); // Foca no campo senha
                return false;
            }

            return true; // Campos válidos
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Configurações de design (cor e borda)
            btnLogin.BackColor = Color.FromArgb(0, 69, 135); // Equivalente ao #004587
            btnLogin.ForeColor = Color.White; 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0; 

            // Efeitos de hover
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 58, 115); 
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 47, 95); 


            string User = "senac";
            string Password = "senac123";

            if (!ValidarCampos())
                return;

            if (txtUsuario.Text == "Digite seu nome de usuário" || txtSenha.Text == "Digite sua senha")
            {
                MessageBox.Show("Por favor, preencha ambos os campos corretamente");
                return;
            }

            if (txtUsuario.Text.Trim() == User && txtSenha.Text.Trim() == Password)
            {
                Home FrmHome = new Home();
                FrmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos. Por favor, tente novamente.",
                    "Falha no Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
