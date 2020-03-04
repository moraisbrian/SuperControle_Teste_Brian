namespace Teste_Brian
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConverterBanco = new System.Windows.Forms.Button();
            this.dtpAdicionarNasc = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtAdicionarCpf = new System.Windows.Forms.TextBox();
            this.txtAdicionarNome = new System.Windows.Forms.TextBox();
            this.lblAdicionarNasc = new System.Windows.Forms.Label();
            this.lblAdicionarCpf = new System.Windows.Forms.Label();
            this.lblAdicionarNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEditarEmailEnd = new System.Windows.Forms.TextBox();
            this.txtEditarNumTel1 = new System.Windows.Forms.TextBox();
            this.txtEditarDdd1 = new System.Windows.Forms.TextBox();
            this.cmbEditarEntidade = new System.Windows.Forms.ComboBox();
            this.txtEditarUf = new System.Windows.Forms.TextBox();
            this.txtEditarMunicipio = new System.Windows.Forms.TextBox();
            this.txtEditarCep = new System.Windows.Forms.TextBox();
            this.txtEditarBairro = new System.Windows.Forms.TextBox();
            this.txtEditarNumero = new System.Windows.Forms.TextBox();
            this.txtEditarLogradouro = new System.Windows.Forms.TextBox();
            this.txtEditarTipo = new System.Windows.Forms.TextBox();
            this.lblEditarEmailEnd = new System.Windows.Forms.Label();
            this.lblEditarEmail = new System.Windows.Forms.Label();
            this.lblEditarNumTel = new System.Windows.Forms.Label();
            this.lblEditarTelefone = new System.Windows.Forms.Label();
            this.lblEditarUf = new System.Windows.Forms.Label();
            this.lblEditarMunicipio = new System.Windows.Forms.Label();
            this.lblEditarCep = new System.Windows.Forms.Label();
            this.lblEditarBairro = new System.Windows.Forms.Label();
            this.lblEditarNumero = new System.Windows.Forms.Label();
            this.lblEditarLogradouro = new System.Windows.Forms.Label();
            this.lblEditarDdd1 = new System.Windows.Forms.Label();
            this.lblEditarTipo = new System.Windows.Forms.Label();
            this.lblEditarEndereco = new System.Windows.Forms.Label();
            this.lblEditarEntidade = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.btnConsultarPesquisar = new System.Windows.Forms.Button();
            this.txtConsultarPesquisar = new System.Windows.Forms.TextBox();
            this.txtEditarNumTel2 = new System.Windows.Forms.TextBox();
            this.txtEditarDdd2 = new System.Windows.Forms.TextBox();
            this.lblEditarNumTel2 = new System.Windows.Forms.Label();
            this.lblEditarDdd2 = new System.Windows.Forms.Label();
            this.txtEditarCel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 472);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConverterBanco);
            this.tabPage1.Controls.Add(this.dtpAdicionarNasc);
            this.tabPage1.Controls.Add(this.btnAdicionar);
            this.tabPage1.Controls.Add(this.txtAdicionarCpf);
            this.tabPage1.Controls.Add(this.txtAdicionarNome);
            this.tabPage1.Controls.Add(this.lblAdicionarNasc);
            this.tabPage1.Controls.Add(this.lblAdicionarCpf);
            this.tabPage1.Controls.Add(this.lblAdicionarNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConverterBanco
            // 
            this.btnConverterBanco.Location = new System.Drawing.Point(25, 182);
            this.btnConverterBanco.Name = "btnConverterBanco";
            this.btnConverterBanco.Size = new System.Drawing.Size(151, 58);
            this.btnConverterBanco.TabIndex = 8;
            this.btnConverterBanco.Text = "Converter Banco de Dados";
            this.btnConverterBanco.UseVisualStyleBackColor = true;
            this.btnConverterBanco.Click += new System.EventHandler(this.btnConverterBanco_Click);
            // 
            // dtpAdicionarNasc
            // 
            this.dtpAdicionarNasc.Location = new System.Drawing.Point(92, 98);
            this.dtpAdicionarNasc.Name = "dtpAdicionarNasc";
            this.dtpAdicionarNasc.Size = new System.Drawing.Size(256, 20);
            this.dtpAdicionarNasc.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(379, 95);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(130, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Inserir";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtAdicionarCpf
            // 
            this.txtAdicionarCpf.Location = new System.Drawing.Point(379, 32);
            this.txtAdicionarCpf.Name = "txtAdicionarCpf";
            this.txtAdicionarCpf.Size = new System.Drawing.Size(175, 20);
            this.txtAdicionarCpf.TabIndex = 4;
            // 
            // txtAdicionarNome
            // 
            this.txtAdicionarNome.Location = new System.Drawing.Point(66, 32);
            this.txtAdicionarNome.Name = "txtAdicionarNome";
            this.txtAdicionarNome.Size = new System.Drawing.Size(206, 20);
            this.txtAdicionarNome.TabIndex = 3;
            // 
            // lblAdicionarNasc
            // 
            this.lblAdicionarNasc.AutoSize = true;
            this.lblAdicionarNasc.Location = new System.Drawing.Point(22, 100);
            this.lblAdicionarNasc.Name = "lblAdicionarNasc";
            this.lblAdicionarNasc.Size = new System.Drawing.Size(64, 13);
            this.lblAdicionarNasc.TabIndex = 2;
            this.lblAdicionarNasc.Text = "Data Nasc.:";
            // 
            // lblAdicionarCpf
            // 
            this.lblAdicionarCpf.AutoSize = true;
            this.lblAdicionarCpf.Location = new System.Drawing.Point(311, 35);
            this.lblAdicionarCpf.Name = "lblAdicionarCpf";
            this.lblAdicionarCpf.Size = new System.Drawing.Size(62, 13);
            this.lblAdicionarCpf.TabIndex = 1;
            this.lblAdicionarCpf.Text = "CPF/CNPJ:";
            // 
            // lblAdicionarNome
            // 
            this.lblAdicionarNome.AutoSize = true;
            this.lblAdicionarNome.Location = new System.Drawing.Point(22, 35);
            this.lblAdicionarNome.Name = "lblAdicionarNome";
            this.lblAdicionarNome.Size = new System.Drawing.Size(38, 13);
            this.lblAdicionarNome.TabIndex = 0;
            this.lblAdicionarNome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEditarCel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEditarNumTel2);
            this.tabPage2.Controls.Add(this.txtEditarDdd2);
            this.tabPage2.Controls.Add(this.lblEditarNumTel2);
            this.tabPage2.Controls.Add(this.lblEditarDdd2);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.txtEditarEmailEnd);
            this.tabPage2.Controls.Add(this.txtEditarNumTel1);
            this.tabPage2.Controls.Add(this.txtEditarDdd1);
            this.tabPage2.Controls.Add(this.cmbEditarEntidade);
            this.tabPage2.Controls.Add(this.txtEditarUf);
            this.tabPage2.Controls.Add(this.txtEditarMunicipio);
            this.tabPage2.Controls.Add(this.txtEditarCep);
            this.tabPage2.Controls.Add(this.txtEditarBairro);
            this.tabPage2.Controls.Add(this.txtEditarNumero);
            this.tabPage2.Controls.Add(this.txtEditarLogradouro);
            this.tabPage2.Controls.Add(this.txtEditarTipo);
            this.tabPage2.Controls.Add(this.lblEditarEmailEnd);
            this.tabPage2.Controls.Add(this.lblEditarEmail);
            this.tabPage2.Controls.Add(this.lblEditarNumTel);
            this.tabPage2.Controls.Add(this.lblEditarTelefone);
            this.tabPage2.Controls.Add(this.lblEditarUf);
            this.tabPage2.Controls.Add(this.lblEditarMunicipio);
            this.tabPage2.Controls.Add(this.lblEditarCep);
            this.tabPage2.Controls.Add(this.lblEditarBairro);
            this.tabPage2.Controls.Add(this.lblEditarNumero);
            this.tabPage2.Controls.Add(this.lblEditarLogradouro);
            this.tabPage2.Controls.Add(this.lblEditarDdd1);
            this.tabPage2.Controls.Add(this.lblEditarTipo);
            this.tabPage2.Controls.Add(this.lblEditarEndereco);
            this.tabPage2.Controls.Add(this.lblEditarEntidade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(596, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 46);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Inserir";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditarEmailEnd
            // 
            this.txtEditarEmailEnd.Location = new System.Drawing.Point(76, 388);
            this.txtEditarEmailEnd.Name = "txtEditarEmailEnd";
            this.txtEditarEmailEnd.Size = new System.Drawing.Size(200, 20);
            this.txtEditarEmailEnd.TabIndex = 24;
            // 
            // txtEditarNumTel1
            // 
            this.txtEditarNumTel1.Location = new System.Drawing.Point(228, 225);
            this.txtEditarNumTel1.Name = "txtEditarNumTel1";
            this.txtEditarNumTel1.Size = new System.Drawing.Size(160, 20);
            this.txtEditarNumTel1.TabIndex = 23;
            // 
            // txtEditarDdd1
            // 
            this.txtEditarDdd1.Location = new System.Drawing.Point(67, 225);
            this.txtEditarDdd1.Name = "txtEditarDdd1";
            this.txtEditarDdd1.Size = new System.Drawing.Size(93, 20);
            this.txtEditarDdd1.TabIndex = 22;
            // 
            // cmbEditarEntidade
            // 
            this.cmbEditarEntidade.FormattingEnabled = true;
            this.cmbEditarEntidade.Location = new System.Drawing.Point(76, 27);
            this.cmbEditarEntidade.Name = "cmbEditarEntidade";
            this.cmbEditarEntidade.Size = new System.Drawing.Size(336, 21);
            this.cmbEditarEntidade.TabIndex = 21;
            this.cmbEditarEntidade.SelectedIndexChanged += new System.EventHandler(this.cmbEditarEntidade_SelectedIndexChanged);
            // 
            // txtEditarUf
            // 
            this.txtEditarUf.Location = new System.Drawing.Point(666, 145);
            this.txtEditarUf.Name = "txtEditarUf";
            this.txtEditarUf.Size = new System.Drawing.Size(56, 20);
            this.txtEditarUf.TabIndex = 20;
            // 
            // txtEditarMunicipio
            // 
            this.txtEditarMunicipio.Location = new System.Drawing.Point(500, 145);
            this.txtEditarMunicipio.Name = "txtEditarMunicipio";
            this.txtEditarMunicipio.Size = new System.Drawing.Size(130, 20);
            this.txtEditarMunicipio.TabIndex = 19;
            // 
            // txtEditarCep
            // 
            this.txtEditarCep.Location = new System.Drawing.Point(324, 145);
            this.txtEditarCep.Name = "txtEditarCep";
            this.txtEditarCep.Size = new System.Drawing.Size(107, 20);
            this.txtEditarCep.TabIndex = 18;
            // 
            // txtEditarBairro
            // 
            this.txtEditarBairro.Location = new System.Drawing.Point(61, 145);
            this.txtEditarBairro.Name = "txtEditarBairro";
            this.txtEditarBairro.Size = new System.Drawing.Size(219, 20);
            this.txtEditarBairro.TabIndex = 17;
            // 
            // txtEditarNumero
            // 
            this.txtEditarNumero.Location = new System.Drawing.Point(606, 96);
            this.txtEditarNumero.Name = "txtEditarNumero";
            this.txtEditarNumero.Size = new System.Drawing.Size(116, 20);
            this.txtEditarNumero.TabIndex = 16;
            // 
            // txtEditarLogradouro
            // 
            this.txtEditarLogradouro.Location = new System.Drawing.Point(290, 96);
            this.txtEditarLogradouro.Name = "txtEditarLogradouro";
            this.txtEditarLogradouro.Size = new System.Drawing.Size(257, 20);
            this.txtEditarLogradouro.TabIndex = 15;
            // 
            // txtEditarTipo
            // 
            this.txtEditarTipo.Location = new System.Drawing.Point(55, 96);
            this.txtEditarTipo.Name = "txtEditarTipo";
            this.txtEditarTipo.Size = new System.Drawing.Size(159, 20);
            this.txtEditarTipo.TabIndex = 14;
            // 
            // lblEditarEmailEnd
            // 
            this.lblEditarEmailEnd.AutoSize = true;
            this.lblEditarEmailEnd.Location = new System.Drawing.Point(14, 391);
            this.lblEditarEmailEnd.Name = "lblEditarEmailEnd";
            this.lblEditarEmailEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEditarEmailEnd.TabIndex = 13;
            this.lblEditarEmailEnd.Text = "Endereço:";
            // 
            // lblEditarEmail
            // 
            this.lblEditarEmail.AutoSize = true;
            this.lblEditarEmail.Location = new System.Drawing.Point(14, 368);
            this.lblEditarEmail.Name = "lblEditarEmail";
            this.lblEditarEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEditarEmail.TabIndex = 12;
            this.lblEditarEmail.Text = "Email:";
            // 
            // lblEditarNumTel
            // 
            this.lblEditarNumTel.AutoSize = true;
            this.lblEditarNumTel.Location = new System.Drawing.Point(166, 228);
            this.lblEditarNumTel.Name = "lblEditarNumTel";
            this.lblEditarNumTel.Size = new System.Drawing.Size(56, 13);
            this.lblEditarNumTel.TabIndex = 11;
            this.lblEditarNumTel.Text = "Número 1:";
            // 
            // lblEditarTelefone
            // 
            this.lblEditarTelefone.AutoSize = true;
            this.lblEditarTelefone.Location = new System.Drawing.Point(17, 198);
            this.lblEditarTelefone.Name = "lblEditarTelefone";
            this.lblEditarTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblEditarTelefone.TabIndex = 10;
            this.lblEditarTelefone.Text = "Telefone:";
            // 
            // lblEditarUf
            // 
            this.lblEditarUf.AutoSize = true;
            this.lblEditarUf.Location = new System.Drawing.Point(636, 148);
            this.lblEditarUf.Name = "lblEditarUf";
            this.lblEditarUf.Size = new System.Drawing.Size(24, 13);
            this.lblEditarUf.TabIndex = 9;
            this.lblEditarUf.Text = "UF:";
            // 
            // lblEditarMunicipio
            // 
            this.lblEditarMunicipio.AutoSize = true;
            this.lblEditarMunicipio.Location = new System.Drawing.Point(437, 148);
            this.lblEditarMunicipio.Name = "lblEditarMunicipio";
            this.lblEditarMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblEditarMunicipio.TabIndex = 8;
            this.lblEditarMunicipio.Text = "Município:";
            // 
            // lblEditarCep
            // 
            this.lblEditarCep.AutoSize = true;
            this.lblEditarCep.Location = new System.Drawing.Point(287, 148);
            this.lblEditarCep.Name = "lblEditarCep";
            this.lblEditarCep.Size = new System.Drawing.Size(31, 13);
            this.lblEditarCep.TabIndex = 7;
            this.lblEditarCep.Text = "CEP:";
            // 
            // lblEditarBairro
            // 
            this.lblEditarBairro.AutoSize = true;
            this.lblEditarBairro.Location = new System.Drawing.Point(18, 148);
            this.lblEditarBairro.Name = "lblEditarBairro";
            this.lblEditarBairro.Size = new System.Drawing.Size(37, 13);
            this.lblEditarBairro.TabIndex = 6;
            this.lblEditarBairro.Text = "Bairro:";
            // 
            // lblEditarNumero
            // 
            this.lblEditarNumero.AutoSize = true;
            this.lblEditarNumero.Location = new System.Drawing.Point(553, 99);
            this.lblEditarNumero.Name = "lblEditarNumero";
            this.lblEditarNumero.Size = new System.Drawing.Size(47, 13);
            this.lblEditarNumero.TabIndex = 5;
            this.lblEditarNumero.Text = "Número:";
            // 
            // lblEditarLogradouro
            // 
            this.lblEditarLogradouro.AutoSize = true;
            this.lblEditarLogradouro.Location = new System.Drawing.Point(220, 99);
            this.lblEditarLogradouro.Name = "lblEditarLogradouro";
            this.lblEditarLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblEditarLogradouro.TabIndex = 4;
            this.lblEditarLogradouro.Text = "Logradouro:";
            // 
            // lblEditarDdd1
            // 
            this.lblEditarDdd1.AutoSize = true;
            this.lblEditarDdd1.Location = new System.Drawing.Point(17, 228);
            this.lblEditarDdd1.Name = "lblEditarDdd1";
            this.lblEditarDdd1.Size = new System.Drawing.Size(43, 13);
            this.lblEditarDdd1.TabIndex = 3;
            this.lblEditarDdd1.Text = "DDD 1:";
            // 
            // lblEditarTipo
            // 
            this.lblEditarTipo.AutoSize = true;
            this.lblEditarTipo.Location = new System.Drawing.Point(18, 99);
            this.lblEditarTipo.Name = "lblEditarTipo";
            this.lblEditarTipo.Size = new System.Drawing.Size(31, 13);
            this.lblEditarTipo.TabIndex = 2;
            this.lblEditarTipo.Text = "Tipo:";
            // 
            // lblEditarEndereco
            // 
            this.lblEditarEndereco.AutoSize = true;
            this.lblEditarEndereco.Location = new System.Drawing.Point(18, 70);
            this.lblEditarEndereco.Name = "lblEditarEndereco";
            this.lblEditarEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEditarEndereco.TabIndex = 1;
            this.lblEditarEndereco.Text = "Endereço:";
            // 
            // lblEditarEntidade
            // 
            this.lblEditarEntidade.AutoSize = true;
            this.lblEditarEntidade.Location = new System.Drawing.Point(18, 30);
            this.lblEditarEntidade.Name = "lblEditarEntidade";
            this.lblEditarEntidade.Size = new System.Drawing.Size(52, 13);
            this.lblEditarEntidade.TabIndex = 0;
            this.lblEditarEntidade.Text = "Entidade:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvConsultar);
            this.tabPage3.Controls.Add(this.btnConsultarPesquisar);
            this.tabPage3.Controls.Add(this.txtConsultarPesquisar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.AllowUserToAddRows = false;
            this.dgvConsultar.AllowUserToDeleteRows = false;
            this.dgvConsultar.AllowUserToResizeRows = false;
            this.dgvConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Location = new System.Drawing.Point(3, 56);
            this.dgvConsultar.MultiSelect = false;
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.RowHeadersVisible = false;
            this.dgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultar.Size = new System.Drawing.Size(748, 294);
            this.dgvConsultar.TabIndex = 2;
            // 
            // btnConsultarPesquisar
            // 
            this.btnConsultarPesquisar.Location = new System.Drawing.Point(358, 15);
            this.btnConsultarPesquisar.Name = "btnConsultarPesquisar";
            this.btnConsultarPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultarPesquisar.TabIndex = 1;
            this.btnConsultarPesquisar.Text = "Pesquisar";
            this.btnConsultarPesquisar.UseVisualStyleBackColor = true;
            this.btnConsultarPesquisar.Click += new System.EventHandler(this.btnConsultarPesquisar_Click);
            // 
            // txtConsultarPesquisar
            // 
            this.txtConsultarPesquisar.Location = new System.Drawing.Point(19, 17);
            this.txtConsultarPesquisar.Name = "txtConsultarPesquisar";
            this.txtConsultarPesquisar.Size = new System.Drawing.Size(314, 20);
            this.txtConsultarPesquisar.TabIndex = 0;
            // 
            // txtEditarNumTel2
            // 
            this.txtEditarNumTel2.Location = new System.Drawing.Point(228, 268);
            this.txtEditarNumTel2.Name = "txtEditarNumTel2";
            this.txtEditarNumTel2.Size = new System.Drawing.Size(160, 20);
            this.txtEditarNumTel2.TabIndex = 29;
            // 
            // txtEditarDdd2
            // 
            this.txtEditarDdd2.Location = new System.Drawing.Point(67, 268);
            this.txtEditarDdd2.Name = "txtEditarDdd2";
            this.txtEditarDdd2.Size = new System.Drawing.Size(93, 20);
            this.txtEditarDdd2.TabIndex = 28;
            // 
            // lblEditarNumTel2
            // 
            this.lblEditarNumTel2.AutoSize = true;
            this.lblEditarNumTel2.Location = new System.Drawing.Point(166, 271);
            this.lblEditarNumTel2.Name = "lblEditarNumTel2";
            this.lblEditarNumTel2.Size = new System.Drawing.Size(56, 13);
            this.lblEditarNumTel2.TabIndex = 27;
            this.lblEditarNumTel2.Text = "Número 2:";
            // 
            // lblEditarDdd2
            // 
            this.lblEditarDdd2.AutoSize = true;
            this.lblEditarDdd2.Location = new System.Drawing.Point(17, 271);
            this.lblEditarDdd2.Name = "lblEditarDdd2";
            this.lblEditarDdd2.Size = new System.Drawing.Size(43, 13);
            this.lblEditarDdd2.TabIndex = 26;
            this.lblEditarDdd2.Text = "DDD 2:";
            // 
            // txtEditarCel
            // 
            this.txtEditarCel.Location = new System.Drawing.Point(67, 311);
            this.txtEditarCel.Name = "txtEditarCel";
            this.txtEditarCel.Size = new System.Drawing.Size(160, 20);
            this.txtEditarCel.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 472);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(781, 511);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtAdicionarCpf;
        private System.Windows.Forms.TextBox txtAdicionarNome;
        private System.Windows.Forms.Label lblAdicionarNasc;
        private System.Windows.Forms.Label lblAdicionarCpf;
        private System.Windows.Forms.Label lblAdicionarNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEditarEmailEnd;
        private System.Windows.Forms.TextBox txtEditarNumTel1;
        private System.Windows.Forms.TextBox txtEditarDdd1;
        private System.Windows.Forms.ComboBox cmbEditarEntidade;
        private System.Windows.Forms.TextBox txtEditarUf;
        private System.Windows.Forms.TextBox txtEditarMunicipio;
        private System.Windows.Forms.TextBox txtEditarCep;
        private System.Windows.Forms.TextBox txtEditarBairro;
        private System.Windows.Forms.TextBox txtEditarNumero;
        private System.Windows.Forms.TextBox txtEditarLogradouro;
        private System.Windows.Forms.TextBox txtEditarTipo;
        private System.Windows.Forms.Label lblEditarEmailEnd;
        private System.Windows.Forms.Label lblEditarEmail;
        private System.Windows.Forms.Label lblEditarNumTel;
        private System.Windows.Forms.Label lblEditarTelefone;
        private System.Windows.Forms.Label lblEditarUf;
        private System.Windows.Forms.Label lblEditarMunicipio;
        private System.Windows.Forms.Label lblEditarCep;
        private System.Windows.Forms.Label lblEditarBairro;
        private System.Windows.Forms.Label lblEditarNumero;
        private System.Windows.Forms.Label lblEditarLogradouro;
        private System.Windows.Forms.Label lblEditarDdd1;
        private System.Windows.Forms.Label lblEditarTipo;
        private System.Windows.Forms.Label lblEditarEndereco;
        private System.Windows.Forms.Label lblEditarEntidade;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnConsultarPesquisar;
        private System.Windows.Forms.TextBox txtConsultarPesquisar;
        private System.Windows.Forms.DateTimePicker dtpAdicionarNasc;
        private System.Windows.Forms.Button btnConverterBanco;
        private System.Windows.Forms.TextBox txtEditarCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditarNumTel2;
        private System.Windows.Forms.TextBox txtEditarDdd2;
        private System.Windows.Forms.Label lblEditarNumTel2;
        private System.Windows.Forms.Label lblEditarDdd2;
    }
}

