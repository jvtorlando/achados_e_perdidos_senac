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
using achados_e_perdidos_senac.Model;

namespace achados_e_perdidos_senac.Screen.Devolucao_Item
{
    public partial class FrmDevolverItem : Form
    {
        public FrmDevolverItem()
        {
            InitializeComponent();
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (dgvItensEntrega.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para marcar como devolvido.");
                return;
            }

            var linha = dgvItensEntrega.SelectedRows[0];
            int idItem = Convert.ToInt32(linha.Cells["id_item"].Value);
            string statusAtual = linha.Cells["status_item"].Value.ToString();

            if (statusAtual == "Devolvido")
            {
                MessageBox.Show("Este item já está marcado como devolvido.");
                return;
            }

            // Atualizar status no banco
            var itemController = new ItemPerdidoController();
            bool sucesso = itemController.AtualizarStatusItem(idItem, "Devolvido");

            if (sucesso)
            {
                // Registrar no histórico
                var historico = new HistoricoDevolucao
                {
                    id_item = idItem,
                    usuario_responsavel = "usuario_logado", // Substitua pelo nome real
                    data_devolucao = DateTime.Now
                };

                var historicoController = new HistoricoDevolucaoController();
                historicoController.Registrar(historico);

                MessageBox.Show("Item marcado como devolvido com sucesso!");
                dgvItensEntrega.DataSource = itemController.BuscarTodosItens(); // Recarrega
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o status.");
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var controller = new ItemPerdidoController();
            dgvItensEntrega.DataSource = controller.BuscarTodosItens();
        }
    }
}
