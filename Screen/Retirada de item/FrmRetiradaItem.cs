using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Controllers;

namespace achados_e_perdidos_senac.Screen.Retirada_de_item
{
    public partial class FrmRetiradaItem : Form
    {
        public FrmRetiradaItem()
        {
            CarregarItens();
        }

        private void CarregarItens()
        {
            var controller = new ItemPerdidoController();
            dgvItens.DataSource = controller.BuscarTodosItens(); // método já existente

            dgvItens.Columns["imagem_url"].Visible = false;
            dgvItens.Columns["id_item"].Visible = false;

            SubstituirColunaStatusPorComboBox();
        }

        private void btnRetirarItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens.Columns[e.ColumnIndex].Name == "status_item" && e.RowIndex >= 0)
            {
                var linha = dgvItens.Rows[e.RowIndex];
                int idItem = Convert.ToInt32(linha.Cells["id_item"].Value);
                string novoStatus = linha.Cells["status_item"].Value.ToString();

                var controller = new ItemPerdidoController();
                bool sucesso = controller.AtualizarStatusItem(idItem, novoStatus);

                if (!sucesso)
                {
                    MessageBox.Show("Erro ao atualizar o status.");
                }

            }
        }
    }
}
