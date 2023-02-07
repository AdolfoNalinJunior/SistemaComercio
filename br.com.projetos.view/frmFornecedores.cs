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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        #region Pesquisar CEP
        /// <summary>
        /// método que vai realziar a pesquisa do CEP, baseado no site viacep.com.br
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = mtbCEP.Text;
                string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml";
                DataSet dado = new DataSet();
                dado.ReadXml(xmlUrl);

                txtEndereco.Text = dado.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dado.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dado.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dado.Tables[0].Rows[0]["complemento"].ToString();
                cbEstado.Text = dado.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Endereço não encontrado. Por favor digite manualmente!");
            }
        }
        #endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        #region BotaoSalvar
        /// <summary>
        /// Evento do tipo CLICK que executa o método de salvar os Fornecedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = Convert.ToInt16(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.CadastrarFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region Load (tela)
        /// <summary>
        /// Evento load (tela), inicialização da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedoresDAO dao = new FornecedoresDAO();
            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion
    }
}
