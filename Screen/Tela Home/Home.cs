using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.CadastroItens;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac
{
    public partial class Home : Form
    {
        public Home()
        {
            //Fechar toda a aplicação
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            //Abrir tela de pesquisa de item
            FrmSelecionarItem frmSelecionarItem = new FrmSelecionarItem();
            frmSelecionarItem.ShowDialog();
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            //Abrir tela de cadastro de item novo
            FrmCadastroItens frmCadastroItem = new FrmCadastroItens();
            frmCadastroItem.ShowDialog();
            
        }
    }
}
