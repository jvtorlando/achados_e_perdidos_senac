using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Controllers;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Repositorios;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac.CadastroItens
{
    public partial class FrmCadastroItens: Form
    {
        private ItemPerdidoController itemPerdidoController;

        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Imagens|*.jpg;*.jpeg;*.png;",
            Title = "Selecionar Foto"
        };

        public FrmCadastroItens()
        {
            InitializeComponent();
            itemPerdidoController = new ItemPerdidoController(new ItemRepositorio(new DatabaseService()));

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
            private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerDataCadastro.Value = DateTime.Now;
            dateTimePickerDataCadastro.Enabled = false; 
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubirArquivo_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {

            ItemPerdido itemPerdido = new ItemPerdido();

            CriarObjetoItemPerdido(itemPerdido);

            string selectCategoria = SelectCategoria.Text;
            string caminhoFoto = pictureBoxFoto.ImageLocation;
            DateTime dataCadastro = dateTimePickerDataCadastro.Value;

            if (string.IsNullOrEmpty(selectCategoria) || string.IsNullOrEmpty(caminhoFoto))
            {
                MessageBox.Show("Por favor, preencha todos os campos e selecione uma foto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (itemPerdidoController.InserirItemPerdido(itemPerdido))
            {
                AlterarLocalImagem();
            }



            // Aqui você pode salvar os dados em um banco de dados, arquivo ou listaMessageBox.Show("Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: Limpar os campos após salvartxtDescricao.Clear();
            pictureBoxFoto.ImageLocation = null;


        }

        private void AlterarLocalImagem() {

            string destinoPasta = Path.Combine(Application.StartupPath, "Imagens"); // pasta "Imagens" no diretório da aplicação
            if (!Directory.Exists(destinoPasta))
                Directory.CreateDirectory(destinoPasta);

            string nomeArquivo = Path.GetFileName(openFileDialog.FileName);
            string caminhoDestino = Path.Combine(destinoPasta, nomeArquivo);

            // Copiar o arquivo selecionado para o destino
            File.Copy(openFileDialog.FileName, caminhoDestino, true);

        }


        private void CriarObjetoItemPerdido(ItemPerdido itemPerdido) {

            itemPerdido.andar = SelectAndar.SelectedItem.ToString();
            itemPerdido.categoria = SelectCategoria.SelectedItem.ToString();
            itemPerdido.data = dateTimePickerDataCadastro.Value;
            itemPerdido.descricao = txtDescricao.Text;
            itemPerdido.imagem_url = Path.GetFileName(openFileDialog.FileName);

        }
    }
    }

