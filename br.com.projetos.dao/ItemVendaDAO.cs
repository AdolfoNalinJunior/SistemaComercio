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
    public class ItemVendaDAO
    {
        #region Connection 
        private MySqlConnection connection;
        #endregion

        #region construtor
        public ItemVendaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarItemVenda
        /// <summary>
        /// Cadastra o obj na tabela itensvendas
        /// </summary>
        /// <param name="obj">obj que vão ser cadastrados</param>
        public void CadastrarItemVenda(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into bdvendas.tb_itensvenda (venda_id, produto_id, qtd, subtotal)
values (@venda_id, @produtos_id, @qtd, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@venda_id", obj.CodigoVenda);
                cmd.Parameters.AddWithValue("@produto_id", obj.CodigoProduto);
                cmd.Parameters.AddWithValue("@qtd", obj.Quantidade);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Os itens foi cadastrado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu eu erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
            }
        }
        #endregion
    }
}
