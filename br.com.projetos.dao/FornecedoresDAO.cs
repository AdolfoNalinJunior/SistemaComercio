using MySql.Data.MySqlClient;
using ProjetosControle_De_Vendas.br.com.projetos.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosControle_De_Vendas.br.com.projetos.dao
{
    public class FornecedoresDAO
    {
        #region AtributosClasse
        private MySqlConnection connection;
        #endregion

        #region Construtor
        public FornecedoresDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

    }
}
