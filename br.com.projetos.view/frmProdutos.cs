using ProjetosControle_De_Vendas.br.com.projetos.dao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.view
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        #region Load (tela)
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            FornecedoresDAO f_dao = new FornecedoresDAO();
            cbFornecedor.DataSource = f_dao.ConsultarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            ProdutosDAO obj = new ProdutosDAO();

            dgListaProdutos.DataSource = obj.ConsultarProdutos();
        }
        #endregion

        #region btnSalvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.Descricao = txtDescricao.Text;
            obj.Preco = decimal.Parse(txtValor.Text);
            obj.Estoque = Convert.ToInt32(txtEstoque.Text);
            obj.CodigoFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());

            ProdutosDAO dao = new ProdutosDAO();
            dao.CadastrarProdutos(obj);

            //dgListaProdutos.DataSource = dao.ConsultarProdutos();

            new Helpers().LimparTela(this);
        }
        #endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
