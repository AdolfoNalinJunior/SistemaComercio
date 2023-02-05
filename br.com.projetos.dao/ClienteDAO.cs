﻿using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    /// <summary>
    /// Classe que tem conexão com a tabela Cliente no banco de dados
    /// </summary>
    public class ClienteDAO
    {
        #region connetion
        /// <summary>
        /// Atributo MySqlCoonction 
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region ClienteDAO  
        /// <summary>
        /// Contrutor com a conecxão da classe ConnetionFactory
        /// </summary>
        public ClienteDAO()
        {
            this.connection =  new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarCliente
        /// <summary>
        /// Cadastro do <paramref name="obj"/> no banco de dados
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

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro! Erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarClientes
        /// <summary>
        /// Consulta do banco de dados, para listar os clientes cadastrado nele
        /// </summary>
        /// <returns>Retorna a  lista de clientes que está no banco de dados </returns>
        public DataTable ConsultarClientes()
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
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql); 
                DA.Fill(tabelaCliente);

                // 4 passo - Fechar a conexão
                connection.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region EditarCliente
        /// <summary>
        /// Realiza a edição dos dados do cliente
        /// </summary>
        /// <param name="cliente">Parametro do tipo cliente</param>
        public void EditarCliente(Clientes cliente)
        {
            try
            {

                string sqlcmd = @"update bdvendas.tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,
complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
where id=@id";
                MySqlCommand cmdSql = new MySqlCommand(sqlcmd,connection);
                cmdSql.Parameters.AddWithValue("@nome",cliente.Nome);
                cmdSql.Parameters.AddWithValue("@rg",cliente.RG);
                cmdSql.Parameters.AddWithValue("@cpf",cliente.CPF);
                cmdSql.Parameters.AddWithValue("@email",cliente.Email);
                cmdSql.Parameters.AddWithValue("@telefone",cliente.Telefone);
                cmdSql.Parameters.AddWithValue("@celular",cliente.Celular);
                cmdSql.Parameters.AddWithValue("@cep",cliente.CEP);
                cmdSql.Parameters.AddWithValue("@endereco",cliente.Endereco);
                cmdSql.Parameters.AddWithValue("@numero",cliente.Numero);
                cmdSql.Parameters.AddWithValue("@complemento",cliente.Complemento);
                cmdSql.Parameters.AddWithValue("@bairro",cliente.Bairro);
                cmdSql.Parameters.AddWithValue("@cidade",cliente.Cidade);
                cmdSql.Parameters.AddWithValue("@estado",cliente.Estado);
                cmdSql.Parameters.AddWithValue("@id",cliente.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O Cliente {cliente.Nome} foi editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O cliente {cliente.Nome} não foi editado com sucesso!: Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirClientes
        /// <summary>
        /// Método responsável pela exclusão do <paramref name="cliente"/> pelo id
        /// </summary>
        /// <param name="cliente">Parametro do tipo <paramref name="cliente" \/></param>
        public void ExcluirClientes(Clientes cliente)
        {
            try
            {
                string cmdSql = "delete from bdvendas.tb_clientes where id=@id";

                MySqlCommand sqlCmd = new MySqlCommand(cmdSql,connection);
                sqlCmd.Parameters.AddWithValue("@id",cliente.Codigo);

                connection.Open();
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show($"O cliente {cliente.Nome} foi excluido com sucesso");

                // Fachando a conxão com o banco de dados
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A exclusão do cliente {cliente.Nome} não foi bem sucedida, mensagem de erro: {ex.Message}, Caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region BuscarPorNome
        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes where nome = @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();
                
                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaCliente);
                return tabelaCliente;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} {ex.Message}");
                return null;             
            }
        }
        #endregion

        #region ListarClienteNome
        public DataTable ListarClienteNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes where nome like @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaCliente);
                return tabelaCliente;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} {ex.Message}");
                return null;
            }
        }
        #endregion
    }
}
