using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achados_e_perdidos_senac
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = "senac";
            string Password = "senac123";

            if(txtUsuario.Text == User & txtSenha.Text == Password)
            {
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }
            else
            {

            }
            {
                MessageBox.Show("Usuário ou Senha incorreto");
            }
        }
    }
}
