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
            DialogResult result = MessageBox.Show("Deseja substituir a imagem atual?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImagem.Image = new Bitmap(ofd.FileName);
                    imageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
            else
            {
                // 1. Obtenha o nome da imagem a partir do banco de dados
                string nomeImagemDoBanco = ObterNomeImagemDoBanco(); // você vai criar esse método

                // 2. Abra o OpenFileDialog apontando para a pasta padrão e pré-selecionando o arquivo
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;";
                ofd.InitialDirectory = Application.StartupPath + @"\imagens\"; // pasta onde as imagens estão
                ofd.FileName = nomeImagemDoBanco;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImagem.Image = new Bitmap(ofd.FileName);
                    imageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        } // <-- FECHA AQUI o método btnSelecionarFoto_Click

        // Método fora de qualquer outro
        private string ObterNomeImagemDoBanco()
        {
            string nomeImagem = "";

            // Substitua pela sua string de conexão real
            string connectionString = "Data Source=SERVIDOR;Initial Catalog=SEUBANCO;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Substitua pela sua consulta e tabela corretas
                string query = "SELECT Imagem FROM SuaTabela WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", 1); // substitua por lógica dinâmica se necessário

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nomeImagem = reader["NomeImagem"].ToString();
                }
            }

            return nomeImagem;
        }

    }
}


