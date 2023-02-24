using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    public class ProdutosDAO
    {
        #region Connection 
        private MySqlConnection connection;
        #endregion

        #region ProdutoDAO
        public ProdutosDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarProdutos
        public void CadastrarProdutos(Produtos obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
values(@descricao,@preco,@qtd_estoque,@for_id)";
                
                MySqlCommand cmdSql = new MySqlCommand(sql,connection);
                cmdSql.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmdSql.Parameters.AddWithValue("@preco", obj.Preco);
                cmdSql.Parameters.AddWithValue("@qtd_estoque", obj.Estoque);
                cmdSql.Parameters.AddWithValue("@for_id", obj.CodigoFornecedor);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"Produto foi cadastrado com sucesso ");


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do Tipo {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarProdutos
        public DataTable ConsultarProdutos()
        {
            try
            {
                DataTable tabProduto = new DataTable();

                string sql = "select * from bdvendas.tb_produtos";

                MySqlCommand cmd = new MySqlCommand( sql,connection);
                
                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabProduto);

                connection.Close();  
                return tabProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
                return null;
            }
        }
        #endregion
    }
}
