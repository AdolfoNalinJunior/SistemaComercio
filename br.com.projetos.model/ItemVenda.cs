using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosControle_De_Vendas.br.com.projetos.model
{
    public class ItemVenda
    {
        public int Codigo { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }
    }
}
