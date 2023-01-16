using ProjetosControle_De_Vendas.br.com.projetos.dao;
using ProjetosControle_De_Vendas.br.com.projetos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosControle_De_Vendas.br.com.projetos.view
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        #region BotãoSalvar
        /// <summary>
        /// Primeira etapa de salvamento  de clientes -- botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro so objeto modelo de cliente
            Clientes cliente = new Clientes();

            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbEstado.Text; 

            // 2 passo - Criar um objeto da classe ClienteDAO
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.CadastrarCliente(cliente);

            dgListaClientes.DataSource = clienteDao.ConsultarClientes();
        }
        #endregion

        #region LoadClientes
        /// <summary>
        /// Inicialização do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgListaClientes.DataSource = dao.ConsultarClientes();
        }
        #endregion

        #region EditarClientes
        /// <summary>
        /// Evento de CellClick, levar os membros do obj para a area de cadastramento de cliente, para eles serem 
        /// modicados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgListaClintes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDAO objDao = new ClienteDAO();
            // 1 passo - Pegar os dados da linha selecionada
            txtCodigo.Text = dgListaClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgListaClientes.CurrentRow.Cells[1].Value.ToString();
            mtbRG.Text = dgListaClientes.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dgListaClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgListaClientes.CurrentRow.Cells[4].Value.ToString();
            mtbTelefone.Text = dgListaClientes.CurrentRow.Cells[5].Value.ToString();
            mtbCelular.Text = dgListaClientes.CurrentRow.Cells[6].Value.ToString();
            mtbCEP.Text = dgListaClientes.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgListaClientes.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgListaClientes.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgListaClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgListaClientes.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgListaClientes.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgListaClientes.CurrentRow.Cells[13].Value.ToString();

            // 2 passo - Alterar para gui Dados pessoais
            tabControl1.SelectedTab = tabCadastroClientes;
            dgListaClientes.DataSource = objDao.ConsultarClientes();
        }
        #endregion

        #region BotaoExcluir
        /// <summary>
        /// Evento btnExcluir_Click Exclusão do obj 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // botão de excluir 
            Clientes obj = new Clientes();

            // Passando o valor do Codigo para o codigo do cliente
            obj.Codigo = int.Parse(txtCodigo.Text);

            // Realizando a Exclusãos do cliente
            ClienteDAO objDao = new ClienteDAO();
            objDao.ExcluirClientes(obj);

            // Atualizar após a deleção
            dgListaClientes.DataSource = objDao.ConsultarClientes();
        }
        #endregion

        #region BotãoEditar
        /// <summary>
        /// Evendo btnEditar_Click: Ao clicar no botão será autorizado a edição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro so objeto modelo de cliente
            Clientes cliente = new Clientes();

            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbEstado.Text;
            cliente.Codigo = int.Parse(txtCodigo.Text);

            // 2 passo - Criar um objeto da classe ClienteDAO para auterar os dados do cliente
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.EditarCliente(cliente);

            dgListaClientes.DataSource = clienteDao.ConsultarClientes();
        }
        #endregion
    }
}
