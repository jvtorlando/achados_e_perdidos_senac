using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Services;
using MySql.Data.MySqlClient;

namespace achados_e_perdidos_senac.Repositorios
{
    internal class ItemRepositorio
    {
        private DatabaseService databaseService;
        public ItemRepositorio(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

            
        public List<ItemPerdido> getAllItens()
        {

            List<ItemPerdido> itensPerdidos = new List<ItemPerdido>();

            try
            {

                string query = "SELECT * FROM item_perdido";
                MySqlDataReader resultadoBanco = databaseService.ExecuteQuery(query);

                while (resultadoBanco.Read())
                {
                    ItemPerdido itemPerdido = new ItemPerdido();
                    itemPerdido = ItemPerdido.ItemFromDataReader(resultadoBanco);


                    itensPerdidos.Add(itemPerdido);
                }
                databaseService.CloseConnection();

                return itensPerdidos;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar itens: " + ex.Message);
            }


        }

        public List<ItemPerdido> BuscarItemPorDescricao(string descricao)
        {

            List<ItemPerdido> itensPerdidos = new List<ItemPerdido>();

            try
            {

                string query = "SELECT * FROM item_perdido WHERE descricao LIKE @descricao";


                var parameters = new MySqlParameter[]
               {
                    new MySqlParameter("@descricao", "%" + descricao + "%"),
                   
               };


                MySqlDataReader resultadoBanco = databaseService.ExecuteQuery(query, parameters);

                while (resultadoBanco.Read())
                {
                    MessageBox.Show(resultadoBanco["descricao"].ToString());

                    ItemPerdido itemPerdido = new ItemPerdido();
                    itemPerdido = ItemPerdido.ItemFromDataReader(resultadoBanco);


                    itensPerdidos.Add(itemPerdido);
                }

                databaseService.CloseConnection();
                return itensPerdidos;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar itens: " + ex.Message);
            }


        }



        public bool InserirItem(ItemPerdido itemPerdido)
        {
            try
            {
                string query = @"INSERT INTO item_perdido
                                (categoria, descricao, andar, imagem_url, data, nome_item, status_item) 
                                VALUES 
                                (@categoria, @descricao, @andar, @imagem_url, @data, @nome_item, @status_item)";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@categoria", itemPerdido.categoria),
                    new MySqlParameter("@descricao", itemPerdido.descricao),
                    new MySqlParameter("@andar", itemPerdido.andar),
                    new MySqlParameter("@imagem_url", itemPerdido.imagem_url),
                    new MySqlParameter("@nome_item", itemPerdido.nomeItem),
                    new MySqlParameter("@data", itemPerdido.data),
                    new MySqlParameter("@status_item", itemPerdido.status_item),
                };

                int affectedRows = databaseService.ExecuteNonQuery(query, parameters);
                if (affectedRows > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar item perdido: " + ex.Message);
            }
        }

        public bool Excluir(int idItem)
        {
            string query = "DELETE FROM item_perdido WHERE id_item = @id";

            using (var conexao = databaseService.AbrirConexao())
            using (var comando = new MySqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@id", idItem);

                int linhasAfetadas = comando.ExecuteNonQuery();
                return linhasAfetadas > 0;
            }
        }

    }

}

