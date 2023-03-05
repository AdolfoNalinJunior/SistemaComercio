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

        #region mtbCPF_KeyPress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clientes obj = new Clientes();
            ClienteDAO objDAO = new ClienteDAO();
            if (e.KeyChar == 13)
            {
                obj = objDAO.BuscarClienteVendas(mtbCPF.Text);
                txtNomeCliente.Text = obj.Nome;
            }
        }

        #endregion

        #region txtCodigo_KeyPress
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
        #endregion
    }
}
