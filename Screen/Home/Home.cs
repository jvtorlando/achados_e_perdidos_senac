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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            cadastro cadastrarItem = new cadastro();
            this.Show();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            editar editarItem = new editar();
            this.Show();
        }
    }
}
