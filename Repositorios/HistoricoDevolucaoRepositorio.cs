using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using achados_e_perdidos_senac.Model;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac.Repositorios
{
    public class HistoricoDevolucaoRepositorio
    {
        private readonly DatabaseService databaseService;

        public HistoricoDevolucaoRepositorio(DatabaseService dbService)
        {
            this.databaseService = dbService;
        }

        public bool RegistrarDevolucao(HistoricoDevolucao historico)
        {
            string query = @"INSERT INTO historico_devolucao (id_item, usuario_responsavel, data_devolucao)
                             VALUES (@id_item, @usuario_responsavel, @data_devolucao)";

            var parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_item", historico.id_item),
                new MySqlParameter("@usuario_responsavel", historico.usuario_responsavel),
                new MySqlParameter("@data_devolucao", historico.data_devolucao)
            };

            int resultado = databaseService.ExecuteNonQuery(query, parametros);
            return resultado > 0;
        }

        public List<HistoricoDevolucao> BuscarTodos()
        {
            string query = "SELECT * FROM historico_devolucao";
            var lista = new List<HistoricoDevolucao>();

            using (var reader = databaseService.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    lista.Add(new HistoricoDevolucao
                    {
                        id_historico = Convert.ToInt32(reader["id_historico"]),
                        id_item = Convert.ToInt32(reader["id_item"]),
                        usuario_responsavel = reader["usuario_responsavel"].ToString(),
                        data_devolucao = Convert.ToDateTime(reader["data_devolucao"])
                    });
                }
            }

            return lista;
        }
    }
}
