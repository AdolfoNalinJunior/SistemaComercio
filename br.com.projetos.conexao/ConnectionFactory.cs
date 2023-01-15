using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosControle_De_Vendas.br.com.projetos.conexao
{
    /// <summary>
    /// Classe responsavel pela conecxão do banco de dados
    /// </summary>
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
           return new MySqlConnection(connection);
        }
    }
}
