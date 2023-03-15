using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    public class VendasDAO
    {
        #region Connection
        public MySqlConnection connectio;
        #endregion

        #region Construtor
        public VendasDAO()
        {
            this.connectio = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarVenda
        public void CadastrarVenda(Vendas obj)
        {
            try
            {
                string sql = @"insert into bdvendas.tb_vendas (cliente_id, data_venda, total_venda, observacoes)
values (@cliente_id, @data_venda, @total_vendas, @observacoes)";

                MySqlCommand cmd = new MySqlCommand(sql, connectio);
                cmd.Parameters.AddWithValue("@cliente_id", obj.CodigoCliente);
                cmd.Parameters.AddWithValue("@data_venda", obj.Data);
                cmd.Parameters.AddWithValue("@total_vendas", obj.TotalVenda);
                cmd.Parameters.AddWithValue("@observacoes", obj.Observacao);

                connectio.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"A venda foi realizada com sucesso!");

                connectio.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region UltimaVenda
        /// <summary>
        /// Retorna o ultimo id, ou seja, a ultima venda que foi feita
        /// </summary>
        /// <returns>O id da venda</returns>
        public int ultimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = "select max(id) id from tb_vendas";

                MySqlCommand cmd = new MySqlCommand(sql, connectio );

                connectio.Open();

                MySqlDataReader DR = cmd.ExecuteReader();
                if(DR.Read())
                {
                    idvenda = DR.GetInt32("id");
                    connectio.Close();
                }
                return idvenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconeteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return 0;
            }
        }
        #endregion
    }
}
