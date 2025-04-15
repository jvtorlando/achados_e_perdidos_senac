﻿using System;
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = "senac";
            string Password = "senac123";

            if(txtUsuario.Text == User & txtSenha.Text == Password)
            {
                Home FrmHome = new Home();
                FrmHome.Show();
                this.Hide();
            }
            else
            {
                // Mensagem com ícone de erro e botão OK
                MessageBox.Show(
                    "Usuário ou senha incorretos. Por favor, tente novamente.",
                    "Falha no Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

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
    }
}
