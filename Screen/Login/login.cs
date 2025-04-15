using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac
{
    public partial class login : Form
    {
        int tentativasLogin = 0;

        public login()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show(
                    "Por favor, preencha todos os campos para continuar.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string User = "senac";
            string Password = "senac123";

            if (txtUsuario.Text == User & txtSenha.Text == Password)
            {
                tentativasLogin = 0; // reseta tentativas após login bem-sucedido
                Home FrmHome = new Home();
                FrmHome.Show();
                this.Hide();
            }
            else
            {
                tentativasLogin++; // incrementa tentativa

                // Mensagem com ícone de erro e botão OK
                MessageBox.Show(
                    "Usuário ou senha incorretos. Por favor, tente novamente.",
                    "Falha no Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                // Verifica se ultrapassou o limite de tentativas
                if (tentativasLogin >= 3)
                {
                    MessageBox.Show(
                        "Você excedeu o número de tentativas permitidas.",
                        "Acesso Bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                            string message = "Se esqueceu sua senha ou login, entre em contato com:\n\n" +
                            "• Suporte técnico: pedido@sp.senac.br\n" +
                            "• Telefone: (11) 2187-4450\n\n" +
                            "Horário de atendimento: 08h às 19h";

                    // Opcional: desabilita botão de login ou fecha app
                    MessageBox.Show(message, "Recuperação de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
    }
}
