using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.view
{
    public partial class frmPagamentos : Form
    {
        #region Componentes da classe
        Clientes obj = new Clientes();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;
        DateTime horaAtual;
        #endregion

        public frmPagamentos(Clientes cliente,DataTable carrinho, DateTime dataAtual, DateTime horaAtual)
        {
            this.obj = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            this.horaAtual = horaAtual;

            InitializeComponent();
        }

        private void frmPagamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
