using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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

            dgListaProdutos.DataSource = dao.ConsultarProdutos();

            new Helpers().LimparTela(this);
        }
        #endregion

        #region btnNovo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

        #region dgListarProdutos
        private void dgListaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgListaProdutos.CurrentRow.Cells[0].Value.ToString(); 
            txtDescricao.Text = dgListaProdutos.CurrentRow.Cells[1].Value.ToString(); 
            txtValor.Text = dgListaProdutos.CurrentRow.Cells[2].Value.ToString(); 
            txtEstoque.Text = dgListaProdutos.CurrentRow.Cells[3].Value.ToString(); 
            cbFornecedor.Text = dgListaProdutos.CurrentRow.Cells[4].Value.ToString();

            tabFornecedores.SelectedTab = tabCadastrarProdutos;
        }
        #endregion

        #region btnEditarProduto
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.Descricao = txtDescricao.Text;
            obj.Preco = decimal.Parse(txtValor.Text);
            obj.Estoque = int.Parse(txtEstoque.Text);
            obj.CodigoFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.Codigo = int.Parse(txtCodigo.Text);

            ProdutosDAO dao = new ProdutosDAO();
            dao.EditarProduto(obj);

            dgListaProdutos.DataSource = dao.ConsultarProdutos();
        }

        #endregion

        #region btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);

            ProdutosDAO dao = new ProdutosDAO();
            dao.ExcluirProduto(obj);

            dgListaProdutos.DataSource = dao.ConsultarProdutos();
        }
        #endregion

        #region txtNomeConsultar_KeyPress
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string descricao = "%" + txtNomeConsulta.Text + "%";

            ProdutosDAO dao = new ProdutosDAO();
            dgListaProdutos.DataSource = dao.ListarProdutoNome(descricao);

            if (dgListaProdutos.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                dgListaProdutos.DataSource = dao.ConsultarProdutos();
            }
        }
        #endregion

        #region btnPesquisa_Click
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string descricao = txtNomeConsulta.Text;

            ProdutosDAO dao = new ProdutosDAO();
            dgListaProdutos.DataSource = dao.BuscarProduto(descricao);

            if(dgListaProdutos.Rows.Count == 0 || txtNomeConsulta.Text== String.Empty)
            {
                dgListaProdutos.DataSource = dao.ConsultarProdutos();
            }
        }
        #endregion
    }
}
