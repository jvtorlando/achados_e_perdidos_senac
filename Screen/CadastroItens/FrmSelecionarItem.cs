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
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                int idItem = Convert.ToInt32(dataGridViewItens.SelectedRows[0].Cells["id_item"].Value);

                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir este item?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.Yes)
                {
                    bool sucesso = itemPerdidoController.DeletarItem(idItem);

                    if (sucesso)
                    {
                        MessageBox.Show("Item excluído com sucesso!");

                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o item.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }

        }

        //botão pesquisar
        private void roundButton1_Click(object sender, EventArgs e)
        {
            List<ItemPerdido> listaItens = itemPerdidoController.BuscarItemPorDescricao(txtPesquisa.Text);
            dataGridViewItens.DataSource = listaItens;
            if (dataGridViewItens.Columns.Contains("id_item"))
            {
                //ocultar ou mostrar tabela id_itens (isso deu dor de cabeça de mais!!!)
                dataGridViewItens.Columns["id_item"].Visible = false;
                dataGridViewItens.Columns["imagem_url"].Visible = false;
            }

        }

        private void pictureBoxMonstarDetalhes_Click(object sender, EventArgs e)
        {

        }

        //Mostrar Detalhes (Descrição de item)
        private void dataGridViewItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                var linha = dataGridViewItens.SelectedRows[0];
                lblDescricao.Text = linha.Cells["descricao"].Value.ToString();

            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(

                "🔍 *Como usar esta tela:*\n\n" +
                "• Digite uma palavra-chave na caixa de pesquisa para localizar o item desejado.\n" +
                "• Para *deletar um item*, selecione-o na lista e clique no ícone da lixeira 🗑️.\n" +
                "Caso tenha dúvidas, entre em contato com o suporte.",
                "Ajuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information


            );
        }
    }
}
