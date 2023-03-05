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

        #region Objs
        Clientes obj = new Clientes();
        ClienteDAO objDAO = new ClienteDAO();
        #endregion

        #region mtbCPF_KeyPress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                obj = objDAO.BuscarClienteVendas(mtbCPF.Text);
                txtNomeCliente.Text = obj.Nome;
            }
        }
        #endregion
    }
}
