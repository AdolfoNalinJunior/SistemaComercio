using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        #region ConsultarFuncionario
        public DataTable ConsultarFuncionario()
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaFuncionario= new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_funcionarios";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaFuncionario);

                // 4 passo - Ferchar a conexão
                connection.Close();
                return tabelaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region BuscaFuncionarioNome
        public DataTable BuscarFuncionarioNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_funcionarios where nome = @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaFuncionario);

                // 4 passo - Ferchar a conexão
                connection.Close();
                return tabelaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} Mensagem de Erro: {ex.Message}");
                return null;
            }
        }
        #endregion

        #region EditarFuncionario
        public void EditarFuncionario(Funcionario obj)
        {
            try
            {
                string sqlCmd = @"update bdvendas.tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,celular=@celular,cep=@cep,
endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                MySqlCommand cmdSql = new MySqlCommand();
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);
                cmdSql.Parameters.AddWithValue("@nome", obj.Nome);
                cmdSql.Parameters.AddWithValue("@rg", obj.RG);
                cmdSql.Parameters.AddWithValue("@cpf", obj.CPF);
                cmdSql.Parameters.AddWithValue("@email", obj.Email);
                cmdSql.Parameters.AddWithValue("@senha", obj.Senha);
                cmdSql.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmdSql.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
                cmdSql.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmdSql.Parameters.AddWithValue("@celular", obj.Celular);
                cmdSql.Parameters.AddWithValue("@cep", obj.CEP);
                cmdSql.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmdSql.Parameters.AddWithValue("@numero", obj.Numero);
                cmdSql.Parameters.AddWithValue("@complemneto", obj.Complemento);
                cmdSql.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmdSql.Parameters.AddWithValue("@estado", obj.Estado);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"Funcionario {obj.Nome} editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirFuncionario
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sqlCmd = "delete from bdvendas.tb_funcionarios where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sqlCmd,connection);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"Funcionario {obj.Nome} excluido com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region ListarFuncionariosNome
        public DataTable ListarFuncionariosNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_funcionarios where nome like @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaFuncionario);

                // 4 passo - Ferchar a conexão
                connection.Close();
                return tabelaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} com a mensagem de: {ex.Message}");
                return null;
            }
        }


        #endregion
    }
}
