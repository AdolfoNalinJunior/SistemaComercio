using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosControle_De_Vendas.br.com.projetos.model
{
    /// <summary>
    /// Calsse Funcionario herda de Cliente
    /// </summary>
    public class Funcionario : Clientes
    {
        #region Atributos
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string NivelAcesso{ get; set; }
        #endregion
    }
}
