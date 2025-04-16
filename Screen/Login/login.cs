using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            pictureBoxLogin.Cursor = Cursors.Hand;  // Muda o cursor para "mãozinha"

            // Adiciona os eventos
            pictureBoxLogin.Click += pictureBoxLogin_Click;
            pictureBoxLogin.MouseEnter += PictureBoxLogin_MouseEnter;  // Efeito hover
            pictureBoxLogin.MouseLeave += PictureBoxLogin_MouseLeave;

            // Efeitos visuais na PictureBox
            pictureBoxLogin.MouseDown += (sender, e) =>
            {
                // Escurece a imagem (75% do brilho original)
                pictureBoxLogin.BackColor = Color.FromArgb(190, 190, 190);

                // Reduz levemente o tamanho (5% menor)
                pictureBoxLogin.Size = new Size(
                    (int)(pictureBoxLogin.Width * 0.95),
                    (int)(pictureBoxLogin.Height * 0.95)
                );

                // Centraliza novamente (caso esteja com Anchor ou Dock)
                pictureBoxLogin.Location = new Point(
                    pictureBoxLogin.Location.X + (int)(pictureBoxLogin.Width * 0.025),
                    pictureBoxLogin.Location.Y + (int)(pictureBoxLogin.Height * 0.025)
                );
            };

            pictureBoxLogin.MouseUp += (sender, e) =>
            {
                // Volta ao normal
                pictureBoxLogin.BackColor = SystemColors.Control; // Ou a cor original
                pictureBoxLogin.Size = originalSize; // Restaura o tamanho
                pictureBoxLogin.Location = originalLocation; // Restaura a posição
            };

            pictureBoxLogin.MouseLeave += (sender, e) =>
            {
                // Garante que volte ao normal se o mouse sair durante o clique
                pictureBoxLogin.BackColor = SystemColors.Control;
                pictureBoxLogin.Size = originalSize;
                pictureBoxLogin.Location = originalLocation;
            };
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
            originalSize = pictureBoxLogin.Size;
            originalLocation = pictureBoxLogin.Location;
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

        private void PictureBoxLogin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLogin.BackColor = Color.LightGray;  // Ou qualquer efeito visual
        }

        private void PictureBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogin.BackColor = this.BackColor;  // Volta à cor original
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
