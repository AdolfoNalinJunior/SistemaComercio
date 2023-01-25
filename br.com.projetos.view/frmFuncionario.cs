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

        private void tabCadastroClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

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

            //dgListaFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion
    }
}
