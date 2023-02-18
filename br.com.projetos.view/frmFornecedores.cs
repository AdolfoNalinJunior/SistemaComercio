using Org.BouncyCastle.Crypto.Engines;
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

        #region tela Fornecedores
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

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

        #region Transferindo Valores da dgListarFornecedores para tabCadastrarFornecedores
        private void dgListaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgListaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaFornecedor.CurrentRow.Cells[1].Value.ToString();
            mtbCNPJ.Text = dgListaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgListaFornecedor.CurrentRow.Cells[3].Value.ToString();
            mtbTelefone.Text = dgListaFornecedor.CurrentRow.Cells[4].Value.ToString();
            mtbCelular.Text = dgListaFornecedor.CurrentRow.Cells[5].Value.ToString();
            mtbCEP.Text = dgListaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = dgListaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = dgListaFornecedor.CurrentRow.Cells[8].Value.ToString();  
            txtComplemento.Text = dgListaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = dgListaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = dgListaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbEstado.Text = dgListaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tabFornecedores.SelectedTab = tabCadastrarFonecedores;
        }
        #endregion

        #region btnEditar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbEstado.Text;

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.EditarFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region btnExcluirClick
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);

            FornecedoresDAO dao = new FornecedoresDAO();
            dao.ExcluirFornecedor(obj);

            dgListaFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region KeyPress event
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNomeConsulta.Text + '%';

            FornecedoresDAO obj = new FornecedoresDAO();
            dgListaFornecedor.DataSource = obj.ListarFornecedoresNome(nome);    
            
            if (dgListaFornecedor.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                dgListaFornecedor.DataSource = obj.ConsultarFornecedores();
            }
        }
        #endregion

        #region btnPesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            FornecedoresDAO obj = new FornecedoresDAO();
            dgListaFornecedor.DataSource = obj.BuscarFornecedores(nome);

            if (dgListaFornecedor.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                MessageBox.Show($"Fornecedor como nome {txtNomeConsulta.Text} não foi encontrado, porfavor verifique se o nome está correto ou se o forncedor existe no banco de dados");
                dgListaFornecedor.DataSource = obj.ConsultarFornecedores();
            }
        }
        #endregion
    }
}
