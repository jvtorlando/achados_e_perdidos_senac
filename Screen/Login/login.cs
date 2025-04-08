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
        public login()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;

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
                MessageBox.Show("Usuário ou Senha incorreto");
            }
        }
    }
}
