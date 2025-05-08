using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.CadastroItens
{

    public partial class EdicaoDeItens : Form
    {
        // Variáveis de apoio
        private string connectionString = "Data Source=AchadosPerdidos;Initial Catalog=AchadosPerdidos;Integrated Security=True";
        private int itemSelecionadoId; // ID do item sendo editado
        private byte[] imageBytes;     // Imagem carregada
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.PictureBox pbImagem;


        public EdicaoDeItens()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            dtpData.Value = DateTime.Today;
            pbImagem.Image = null;
            imageBytes = null;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este item?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM ItensAchados WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", itemSelecionadoId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item excluído com sucesso!");
                LimparCampos();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ItensAchados SET Descricao = @descricao, DataEncontro = @data, Imagem = @imagem WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@data", dtpData.Value);
                cmd.Parameters.AddWithValue("@imagem", imageBytes); // byte[] da imagem
                cmd.Parameters.AddWithValue("@id", itemSelecionadoId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item atualizado com sucesso!");
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagem.Image = new Bitmap(ofd.FileName);
                imageBytes = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
    
}
