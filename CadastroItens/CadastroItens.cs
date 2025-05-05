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
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.CadastroItens
{
    public partial class CadastroItens: Form
    {
        public CadastroItens()
        {
            InitializeComponent();
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens|*.jpg;*.jpeg;*.png;",
                Title = "Selecionar Foto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
            private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerDataCadastro.Value = DateTime.Now;
            dateTimePickerDataCadastro.Enabled = false; 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string caminhoFoto = pictureBoxFoto.ImageLocation;
            DateTime dataCadastro = dateTimePickerDataCadastro.Value;

            if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(caminhoFoto))
            {
                MessageBox.Show("Por favor, preencha todos os campos e selecione uma foto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CONEXÃO COM O BANCO - substitua pelos seus dados
            string connectionString = "server=localhost;database=achados_perdidos;uid=seu_usuario;pwd=sua_senha;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO itens (descricao, caminho_foto, data_cadastro) VALUES (@descricao, @caminhoFoto, @dataCadastro)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@caminhoFoto", caminhoFoto);
                        cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos
                    txtDescricao.Clear();
                    pictureBoxFoto.ImageLocation = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar no banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

