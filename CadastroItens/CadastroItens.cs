using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Aqui você pode salvar os dados em um banco de dados, arquivo ou listaMessageBox.Show("Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: Limpar os campos após salvartxtDescricao.Clear();
            pictureBoxFoto.ImageLocation = null;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

