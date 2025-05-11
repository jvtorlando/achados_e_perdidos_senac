using achados_e_perdidos_senac.Controllers;
using achados_e_perdidos_senac.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.CadastroItens
{
    public partial class FrmSelecionarItem : Form
    {
        private ItemPerdidoController itemPerdidoController;
        public FrmSelecionarItem()
        {
            InitializeComponent();
            itemPerdidoController = new ItemPerdidoController(new Repositorios.ItemRepositorio(new Services.DatabaseService()));
        }
        private void FrmSelecionarItem_Load(object sender, EventArgs e)
        {
            CarregarItens("");
        }

        private void CarregarItens(string filtro)
        {
            using (var conexao = new SqlConnection("sua_conexao_string"))
            {
                var query = "SELECT Id, Descricao, DataCadastro FROM Itens WHERE Descricao LIKE @Filtro";
                var comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                conexao.Open();
                var adapter = new SqlDataAdapter(comando);
                var tabela = new DataTable();
                adapter.Fill(tabela);

                dataGridViewItens.DataSource = tabela;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
            private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //CarregarItens(txtPesquisa.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {

        }

        //botão pesquisar
        private void roundButton1_Click(object sender, EventArgs e)
        {
            List<ItemPerdido> listaItens = itemPerdidoController.BuscarItemPorDescricao(txtPesquisa.Text);
            dataGridViewItens.DataSource = listaItens;
            if (dataGridViewItens.Columns.Contains("id_item"))
            {
                dataGridViewItens.Columns["id_item"].Visible = false;
                dataGridViewItens.Columns["imagem_url"].Visible = false;
            }

        }
    }
}
