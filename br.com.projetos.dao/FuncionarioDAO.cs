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
    /// <summary>
    /// Classe que faz conexão com a tabela funcionario no banco de dados
    /// </summary>
    public class FuncionarioDAO
    {
        #region Connection
        /// <summary>
        /// Atributo privado de conexão da classe
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region Construtor
        /// <summary>
        /// construtor que não recebe nenhum parametro, mais faz conexão com o banco de dados
        /// </summary>
        public FuncionarioDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarFuncionaio
        /// <summary>
        /// cadastro de <paramref name="funcionario"/> no banco de dados
        /// </summary>
        /// <param name="funcionario"></param>
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                // 1 passo - Criar o comando SQL
                string cmdSql = @"insert into bdvendas.tb_funcionarios(nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // 2 passo - Organizar e executar o comando sql
                MySqlCommand sqlcmd = new MySqlCommand(cmdSql,connection);
                sqlcmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                sqlcmd.Parameters.AddWithValue("@rg", funcionario.RG);
                sqlcmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
                sqlcmd.Parameters.AddWithValue("@email", funcionario.Email);
                sqlcmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                sqlcmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                sqlcmd.Parameters.AddWithValue("@nivel_acesso", funcionario.NivelAcesso);
                sqlcmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                sqlcmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                sqlcmd.Parameters.AddWithValue("@cep", funcionario.CEP);
                sqlcmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                sqlcmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                sqlcmd.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
                sqlcmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                sqlcmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                sqlcmd.Parameters.AddWithValue("@estado", funcionario.Estado);

                // 3 passo - Abrir a connection e executar sql
                connection.Open();
                sqlcmd.ExecuteNonQuery();

                // Menssagem de confirmação da execução
                MessageBox.Show($"Funcionário {funcionario.Nome} Foi cadastrado com sucesso");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conteceu um erro no caminho: {ex.StackTrace} com a mesagem: {ex.Message}");
            }
        }

        #endregion
    }
}
