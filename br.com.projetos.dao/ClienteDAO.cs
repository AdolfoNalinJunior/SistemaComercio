using Microsoft.SqlServer.Server;
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
    public class ClienteDAO
    {
        // Atributo
        private MySqlConnection connection;

        public ClienteDAO()
        {
            this.connection =  new ConnectionFactory().getConnection();
        }

        #region CadastrarCliente
        /// <summary>
        /// Método de cadastro de Cliente
        /// </summary>
        public void CadastrarCliente(Clientes obj)
        {
            try
            {
                // 1 passo - define the cmd sql = insert into
                string cmdSql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,endereco,numero,complemento,bairro,cidade,estado)
values(@nome,@rg,@cpf,@email,@telefone,@celular,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Transcribe the commands of SQL to CSharp
                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@nome", obj.Nome);
                sqlCmd.Parameters.AddWithValue("@rg", obj.RG);
                sqlCmd.Parameters.AddWithValue("@cpf", obj.CPF);
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

                MessageBox.Show($"O cliente {obj.Nome} Foi cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro! Erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarClientes
        public DataTable ConsultaClientes()
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes;";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql,connection);

                // 3 passo - Abertura da connection
                connection.Open();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql); 
                DA.Fill(tabelaCliente);
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace}");
                return null;
            }
        }

        #endregion
    }

}
