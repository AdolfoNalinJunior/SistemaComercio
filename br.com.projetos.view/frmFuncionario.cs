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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        #region
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

        #region BotaoSalvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF= mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbEstado.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.CadastrarFuncionario(funcionario);

            dgListaFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region Load (tela)
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO objDao = new FuncionarioDAO();
            dgListaFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region EditarFuncionario
        private void dgListaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgListaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaFuncionario.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = dgListaFuncionario.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dgListaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgListaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgListaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgListaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivelAcesso.Text = dgListaFuncionario.CurrentRow.Cells[7].Value.ToString();
            mtbTelefone.Text = dgListaFuncionario.CurrentRow.Cells[8].Value.ToString();
            mtbCelular.Text = dgListaFuncionario.CurrentRow.Cells[9].Value.ToString();
            mtbCEP.Text = dgListaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgListaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgListaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgListaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgListaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgListaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = dgListaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionario.SelectedTab = tabCadastrarFuncionario;
        }
        #endregion

        #region BotaoExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.ExcluirFuncionario(obj);

            dgListaFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region BotaoEditarFuncionario
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = int.Parse(txtCodigo.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF = mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbEstado.Text;

            FuncionarioDAO objDao = new FuncionarioDAO(); 
            objDao.EditarFuncionario(funcionario);

            dgListaFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region botaoPesquiosar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            dgListaFuncionario.DataSource = dao.BuscarFuncionarioNome(nome);

            if (dgListaFuncionario.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                MessageBox.Show("Funcionário não encontrado! Certifique-se se o nome do Funcionário está cadastrado ou se está escrito corretamente!");
                dgListaFuncionario.DataSource = dao.ConsultarFuncionario();
            }
        }
        #endregion

        #region btnPesquisarCEP_Click
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

        #region txtNomeCunsulta_KeyPress
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNomeConsulta.Text + '%';

            FuncionarioDAO dao = new FuncionarioDAO();
            dgListaFuncionario.DataSource = dao.ListarFuncionariosNome(nome);

            if (dgListaFuncionario.Rows.Count == 0 || txtNomeConsulta.Text == String.Empty)
            {
                dgListaFuncionario.DataSource = dao.ConsultarFuncionario();
            }
        }
        #endregion
    }
}
