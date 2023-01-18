namespace ProjetosControle_De_Vendas.br.com.projetos.view
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloCadastroCliente = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastroClientes = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabConsultaClientes = new System.Windows.Forms.TabPage();
            this.btnEditarConsulta = new System.Windows.Forms.Button();
            this.btnExcluirConsulta = new System.Windows.Forms.Button();
            this.btnSalvarConsulta = new System.Windows.Forms.Button();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastroClientes.SuspendLayout();
            this.tabConsultaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblTituloCadastroCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloCadastroCliente
            // 
            this.lblTituloCadastroCliente.AutoSize = true;
            this.lblTituloCadastroCliente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloCadastroCliente.Location = new System.Drawing.Point(12, 34);
            this.lblTituloCadastroCliente.Name = "lblTituloCadastroCliente";
            this.lblTituloCadastroCliente.Size = new System.Drawing.Size(152, 19);
            this.lblTituloCadastroCliente.TabIndex = 0;
            this.lblTituloCadastroCliente.Text = "Cadastro de Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastroClientes);
            this.tabControl1.Controls.Add(this.tabConsultaClientes);
            this.tabControl1.Location = new System.Drawing.Point(0, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 340);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCadastroClientes
            // 
            this.tabCadastroClientes.Controls.Add(this.btnEditar);
            this.tabCadastroClientes.Controls.Add(this.btnExcluir);
            this.tabCadastroClientes.Controls.Add(this.btnSalvar);
            this.tabCadastroClientes.Controls.Add(this.btnNovo);
            this.tabCadastroClientes.Controls.Add(this.cbEstado);
            this.tabCadastroClientes.Controls.Add(this.mtbCEP);
            this.tabCadastroClientes.Controls.Add(this.mtbCelular);
            this.tabCadastroClientes.Controls.Add(this.mtbTelefone);
            this.tabCadastroClientes.Controls.Add(this.mtbCPF);
            this.tabCadastroClientes.Controls.Add(this.mtbRG);
            this.tabCadastroClientes.Controls.Add(this.txtCidade);
            this.tabCadastroClientes.Controls.Add(this.lblCidade);
            this.tabCadastroClientes.Controls.Add(this.lblEstado);
            this.tabCadastroClientes.Controls.Add(this.lblCEP);
            this.tabCadastroClientes.Controls.Add(this.txtBairro);
            this.tabCadastroClientes.Controls.Add(this.lblBairro);
            this.tabCadastroClientes.Controls.Add(this.txtComplemento);
            this.tabCadastroClientes.Controls.Add(this.lblComplemento);
            this.tabCadastroClientes.Controls.Add(this.txtNumero);
            this.tabCadastroClientes.Controls.Add(this.lblNumero);
            this.tabCadastroClientes.Controls.Add(this.txtEndereco);
            this.tabCadastroClientes.Controls.Add(this.lblEndereco);
            this.tabCadastroClientes.Controls.Add(this.lblCelular);
            this.tabCadastroClientes.Controls.Add(this.lblTelefone);
            this.tabCadastroClientes.Controls.Add(this.txtEmail);
            this.tabCadastroClientes.Controls.Add(this.lblEmail);
            this.tabCadastroClientes.Controls.Add(this.lblCPF);
            this.tabCadastroClientes.Controls.Add(this.lblRg);
            this.tabCadastroClientes.Controls.Add(this.txtNome);
            this.tabCadastroClientes.Controls.Add(this.lblNome);
            this.tabCadastroClientes.Controls.Add(this.txtCodigo);
            this.tabCadastroClientes.Controls.Add(this.lblCodigo);
            this.tabCadastroClientes.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroClientes.Name = "tabCadastroClientes";
            this.tabCadastroClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroClientes.Size = new System.Drawing.Size(791, 314);
            this.tabCadastroClientes.TabIndex = 0;
            this.tabCadastroClientes.Text = "Cadastro";
            this.tabCadastroClientes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(462, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(381, 236);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(300, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(219, 236);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "RR",
            "AP",
            "AM",
            "PA",
            "AC",
            "RO",
            "TO",
            "MA",
            "PI",
            "CE ",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MT",
            "DF",
            "GO",
            "MS",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS"});
            this.cbEstado.Location = new System.Drawing.Point(95, 166);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(176, 21);
            this.cbEstado.TabIndex = 33;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(678, 93);
            this.mtbCEP.Mask = "00000-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(65, 20);
            this.mtbCEP.TabIndex = 32;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(329, 57);
            this.mtbCelular.Mask = "(99) 9 000-00000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbCelular.TabIndex = 31;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(507, 57);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 30;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(678, 29);
            this.mtbCPF.Mask = "###.###.###-##";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(83, 20);
            this.mtbCPF.TabIndex = 29;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(552, 29);
            this.mtbRG.Mask = "##.###.###-##";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(78, 20);
            this.mtbRG.TabIndex = 28;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCidade.Location = new System.Drawing.Point(313, 168);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(255, 20);
            this.txtCidade.TabIndex = 27;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(273, 171);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 26;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(47, 171);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(641, 96);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 22;
            this.lblCEP.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBairro.Location = new System.Drawing.Point(607, 168);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(160, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(574, 171);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(118, 132);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(527, 20);
            this.txtComplemento.TabIndex = 19;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(45, 134);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento.TabIndex = 18;
            this.lblComplemento.Text = "Complemento: ";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNumero.Location = new System.Drawing.Point(712, 131);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(55, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(668, 133);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Número: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEndereco.Location = new System.Drawing.Point(95, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(534, 20);
            this.txtEndereco.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(43, 93);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(281, 60);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(448, 62);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(642, 32);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(519, 32);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome.Location = new System.Drawing.Point(175, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(139, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(42, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabConsultaClientes
            // 
            this.tabConsultaClientes.Controls.Add(this.btnEditarConsulta);
            this.tabConsultaClientes.Controls.Add(this.btnExcluirConsulta);
            this.tabConsultaClientes.Controls.Add(this.btnSalvarConsulta);
            this.tabConsultaClientes.Controls.Add(this.btnNovaConsulta);
            this.tabConsultaClientes.Controls.Add(this.lblTotalRegistros);
            this.tabConsultaClientes.Controls.Add(this.dgListaClientes);
            this.tabConsultaClientes.Controls.Add(this.btnPesquisa);
            this.tabConsultaClientes.Controls.Add(this.txtNomeConsulta);
            this.tabConsultaClientes.Controls.Add(this.lblNomeConsulta);
            this.tabConsultaClientes.Location = new System.Drawing.Point(4, 22);
            this.tabConsultaClientes.Name = "tabConsultaClientes";
            this.tabConsultaClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaClientes.Size = new System.Drawing.Size(791, 314);
            this.tabConsultaClientes.TabIndex = 1;
            this.tabConsultaClientes.Text = "Consulta";
            this.tabConsultaClientes.UseVisualStyleBackColor = true;
            // 
            // btnEditarConsulta
            // 
            this.btnEditarConsulta.Location = new System.Drawing.Point(446, 271);
            this.btnEditarConsulta.Name = "btnEditarConsulta";
            this.btnEditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarConsulta.TabIndex = 8;
            this.btnEditarConsulta.Text = "Editar";
            this.btnEditarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExcluirConsulta
            // 
            this.btnExcluirConsulta.Location = new System.Drawing.Point(365, 271);
            this.btnExcluirConsulta.Name = "btnExcluirConsulta";
            this.btnExcluirConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirConsulta.TabIndex = 7;
            this.btnExcluirConsulta.Text = "Excluir";
            this.btnExcluirConsulta.UseVisualStyleBackColor = true;
            // 
            // btnSalvarConsulta
            // 
            this.btnSalvarConsulta.Location = new System.Drawing.Point(284, 271);
            this.btnSalvarConsulta.Name = "btnSalvarConsulta";
            this.btnSalvarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarConsulta.TabIndex = 6;
            this.btnSalvarConsulta.Text = "Salvar";
            this.btnSalvarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(205, 271);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConsulta.TabIndex = 5;
            this.btnNovaConsulta.Text = "Novo";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(573, 31);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 4;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToAddRows = false;
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Location = new System.Drawing.Point(3, 47);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.ReadOnly = true;
            this.dgListaClientes.Size = new System.Drawing.Size(756, 217);
            this.dgListaClientes.TabIndex = 3;
            this.dgListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaClintes_CellClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(264, 21);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(60, 23);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(198, 20);
            this.txtNomeConsulta.TabIndex = 1;
            this.txtNomeConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeConsulta_KeyPress);
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Location = new System.Drawing.Point(18, 26);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(38, 13);
            this.lblNomeConsulta.TabIndex = 0;
            this.lblNomeConsulta.Text = "Nome:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCadastroClientes.ResumeLayout(false);
            this.tabCadastroClientes.PerformLayout();
            this.tabConsultaClientes.ResumeLayout(false);
            this.tabConsultaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloCadastroCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastroClientes;
        private System.Windows.Forms.TabPage tabConsultaClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.Button btnEditarConsulta;
        private System.Windows.Forms.Button btnExcluirConsulta;
        private System.Windows.Forms.Button btnSalvarConsulta;
        private System.Windows.Forms.Button btnNovaConsulta;
    }
}