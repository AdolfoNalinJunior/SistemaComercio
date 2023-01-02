using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosControle_De_Vendas.br.com.projetos.conexao
{
    public class ConnectionFactory
    {
        // Método que conecta o banco de dados

        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
           return new MySqlConnection(connection);
        }
    }
}
