using ProjetosControle_De_Vendas.br.com.projetos.dao;
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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        #region Variaveis da classe
        int quantidade = 0;
        int quantidadeTotal = 0;
        decimal preco = 0;
        decimal subtotal = 0;
        decimal total = 0;
        #endregion

        #region Objs
        Clientes obj = new Clientes();
        ClienteDAO cDao = new ClienteDAO();
        DataTable carrinho = new DataTable();
        #endregion

        #region mtbCPF_KeyPress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                obj = cDao.BuscarClienteVendas(mtbCPF.Text);
                txtNomeCliente.Text = obj.Nome;
            }
        }

        #endregion

        #region Load
        private void frmVendas_Load(object sender, EventArgs e)
        {
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof (decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            dgCarrinho.DataSource = carrinho;

            // Configuração da data
            mtbData. Text = DateTime.Now.ToShortDateString();
            mtbHora.Text = DateTime.Now.ToShortTimeString();
        }
        #endregion

        #region btnAddProduto_Click
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                quantidade = int.Parse(txtQuantidade.Text);
                preco = decimal.Parse(txtValor.Text);
                subtotal = quantidade * preco;

               
                total += subtotal;
                txtTotalValor.Text = total.ToString();

                quantidadeTotal += quantidade;
                txtTotalItens.Text = quantidadeTotal.ToString();

                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDescricao.Text, quantidade, preco, subtotal);

                txtCodigo.Clear();
                txtDescricao.Clear();
                txtQuantidade.Clear();
                txtEstoque.Clear();
                txtValor.Clear();

                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Por favor digite um código válido, ou verifique se existe uma quantidade do prudoto desejado");
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region RmProdutoVenda
        private void btnRmProduto_Click(object sender, EventArgs e)
        {
            decimal subProduto = decimal.Parse(dgCarrinho.CurrentRow.Cells[4].Value.ToString());
            /*
             * A variável está selecionando o valor de subtotal da linha selecionada
             * Para conseguir manipular no evento btnRmProduto_Click
             */

            int indice = dgCarrinho.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();
            
            total -= subProduto;

            txtTotalValor.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }
        #endregion

        #region btnPagamentos_Click
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamentos pg = new frmPagamentos(obj,carrinho);
            pg.txtTotal.Text = txtTotalValor.Text; 
            pg.ShowDialog();
        }
        #endregion

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Produtos obj = new Produtos();
            ProdutosDAO objDAO = new ProdutosDAO();

            if (e.KeyChar == 13)
            {
                obj = objDAO.BuscarProdutoVenda(int.Parse(txtCodigo.Text));

                txtCodigo.Text = obj.Codigo.ToString();
                txtDescricao.Text = obj.Descricao;
                txtEstoque.Text = obj.Estoque.ToString();
                txtValor.Text = obj.Preco.ToString();
            }
        }
    }
}
