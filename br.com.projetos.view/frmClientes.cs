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

        #region Botão Salvar
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
            cliente.Bairro = txtBarro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbEstado.Text; 

            // 2 passo - Criar um objeto da classe ClienteDAO
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.CadastrarCliente(cliente);
        }
        #endregion
    }
}
