using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    public class FornecedoresDAO
    {
        #region AtributosClasse
        private MySqlConnection connection;
        #endregion

        #region FornecedorDAO
        public FornecedoresDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarFonecedor
        public void CadastrarFornecedor(Fornecedores obj)
        {
            try
            {
                // 1 passo - define the cmd sql = insert into
                string cmdSql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular,endereco,numero,complemento,bairro,cidade,estado)
values(@nome,@cnpj,@email,@telefone,@celular,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Transcribe the commands of SQL to CSharp
                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@nome", obj.Nome);
                sqlCmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                sqlCmd.Parameters.AddWithValue("@email", obj.Email);
                sqlCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                sqlCmd.Parameters.AddWithValue("@celular", obj.Celular);
                sqlCmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                sqlCmd.Parameters.AddWithValue("@numero", obj.Numero);
                sqlCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                sqlCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                sqlCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                sqlCmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3 passo - Opening the connection and execulte the command SQL
                this.connection.Open();

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} foi cadastrado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro! Erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarFornecedores
        public DataTable ConsultarFornecedores()
        {
            try
            {
                DataTable tabFornecedortes = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_fornecedores";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabFornecedortes);

                connection.Close();
                return tabFornecedortes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conteceu um erro de tipo: {ex.Message} com o caminho de {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region EditarFornecedor
        public void EditarFornecedor(Fornecedores obj)
        {
            try
            {
                string sql = @"update from bdvendas.tb_forncedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero
complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", obj.Nome);
                cmdSql.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmdSql.Parameters.AddWithValue("@email", obj.Email);
                cmdSql.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmdSql.Parameters.AddWithValue("@celular", obj.Celular);
                cmdSql.Parameters.AddWithValue("@cep", obj.CEP);
                cmdSql.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmdSql.Parameters.AddWithValue("@numero", obj.Numero);
                cmdSql.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmdSql.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmdSql.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmdSql.Parameters.AddWithValue("@estado", obj.Estado);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} for editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirFornecedor
        public void ExcluirFornecedor(Fornecedores obj)
        {
            try
            {
                string sql = "delete from bdvendas.tb_fornecedores where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} foi deletado com sucesso!");

                connection.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion
    }
}
