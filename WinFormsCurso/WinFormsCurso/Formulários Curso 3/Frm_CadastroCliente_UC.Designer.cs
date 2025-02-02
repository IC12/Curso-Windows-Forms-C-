﻿
namespace WinFormsCurso
{
    partial class Frm_CadastroCliente_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_Codigo = new System.Windows.Forms.GroupBox();
            this.Btn_Busca = new System.Windows.Forms.Button();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Mask_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Mask_CEP = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Grp_Outros = new System.Windows.Forms.GroupBox();
            this.Mask_RendaFamiliar = new System.Windows.Forms.MaskedTextBox();
            this.Mask_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LimparToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grp_DataGrid = new System.Windows.Forms.GroupBox();
            this.Dg_Clientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_Codigo.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_Outros.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            this.Grp_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(473, 60);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "label1";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(8, 21);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeCliente.TabIndex = 1;
            this.Lbl_NomeCliente.Text = "label1";
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(8, 100);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomePai.TabIndex = 2;
            this.Lbl_NomePai.Text = "label1";
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(8, 60);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeMae.TabIndex = 3;
            this.Lbl_NomeMae.Text = "label1";
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(6, 23);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CEP.TabIndex = 5;
            this.Lbl_CEP.Text = "label1";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(141, 23);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Logradouro.TabIndex = 6;
            this.Lbl_Logradouro.Text = "label1";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(5, 62);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Complemento.TabIndex = 7;
            this.Lbl_Complemento.Text = "label1";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(322, 62);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Bairro.TabIndex = 8;
            this.Lbl_Bairro.Text = "label1";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(322, 101);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Estado.TabIndex = 9;
            this.Lbl_Estado.Text = "label1";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(8, 20);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Telefone.TabIndex = 10;
            this.Lbl_Telefone.Text = "label1";
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(322, 20);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Profissao.TabIndex = 11;
            this.Lbl_Profissao.Text = "label1";
            // 
            // Lbl_RendaFamiliar
            // 
            this.Lbl_RendaFamiliar.AutoSize = true;
            this.Lbl_RendaFamiliar.Location = new System.Drawing.Point(192, 59);
            this.Lbl_RendaFamiliar.Name = "Lbl_RendaFamiliar";
            this.Lbl_RendaFamiliar.Size = new System.Drawing.Size(35, 13);
            this.Lbl_RendaFamiliar.TabIndex = 12;
            this.Lbl_RendaFamiliar.Text = "label1";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(8, 37);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(671, 20);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomePai.Location = new System.Drawing.Point(8, 116);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(459, 20);
            this.Txt_NomePai.TabIndex = 5;
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeMae.Location = new System.Drawing.Point(8, 76);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(459, 20);
            this.Txt_NomeMae.TabIndex = 3;
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logradouro.Location = new System.Drawing.Point(144, 39);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(535, 20);
            this.Txt_Logradouro.TabIndex = 11;
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(6, 78);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(313, 20);
            this.Txt_Complemento.TabIndex = 12;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(325, 78);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(354, 20);
            this.Txt_Bairro.TabIndex = 13;
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Profissao.Location = new System.Drawing.Point(325, 36);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(354, 20);
            this.Txt_Profissao.TabIndex = 17;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(6, 19);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(209, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_Codigo
            // 
            this.Grp_Codigo.Controls.Add(this.Btn_Busca);
            this.Grp_Codigo.Controls.Add(this.Txt_Codigo);
            this.Grp_Codigo.Location = new System.Drawing.Point(12, 45);
            this.Grp_Codigo.Name = "Grp_Codigo";
            this.Grp_Codigo.Size = new System.Drawing.Size(319, 53);
            this.Grp_Codigo.TabIndex = 28;
            this.Grp_Codigo.TabStop = false;
            this.Grp_Codigo.Text = "groupBox1";
            // 
            // Btn_Busca
            // 
            this.Btn_Busca.Location = new System.Drawing.Point(221, 17);
            this.Btn_Busca.Name = "Btn_Busca";
            this.Btn_Busca.Size = new System.Drawing.Size(92, 23);
            this.Btn_Busca.TabIndex = 2;
            this.Btn_Busca.Text = "button1";
            this.Btn_Busca.UseVisualStyleBackColor = true;
            this.Btn_Busca.Click += new System.EventHandler(this.Btn_Busca_Click);
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Mask_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Chk_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(12, 104);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(685, 184);
            this.Grp_DadosPessoais.TabIndex = 29;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "groupBox1";
            // 
            // Mask_CPF
            // 
            this.Mask_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mask_CPF.Location = new System.Drawing.Point(473, 76);
            this.Mask_CPF.Mask = "000,000,000-00";
            this.Mask_CPF.Name = "Mask_CPF";
            this.Mask_CPF.Size = new System.Drawing.Size(207, 20);
            this.Mask_CPF.TabIndex = 4;
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(9, 145);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(80, 17);
            this.Chk_TemPai.TabIndex = 6;
            this.Chk_TemPai.Text = "checkBox1";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Indefinido);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Location = new System.Drawing.Point(473, 102);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(206, 76);
            this.Grp_Genero.TabIndex = 18;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "Gênero";
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(80, 45);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Indefinido.TabIndex = 9;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton1";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(115, 19);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Feminino.TabIndex = 8;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton1";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(7, 19);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Masculino.TabIndex = 7;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton1";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Mask_CEP);
            this.Grp_Endereco.Controls.Add(this.Cmb_Estado);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Location = new System.Drawing.Point(12, 296);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(685, 150);
            this.Grp_Endereco.TabIndex = 18;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "groupBox1";
            // 
            // Mask_CEP
            // 
            this.Mask_CEP.Location = new System.Drawing.Point(6, 39);
            this.Mask_CEP.Mask = "00000-000";
            this.Mask_CEP.Name = "Mask_CEP";
            this.Mask_CEP.Size = new System.Drawing.Size(132, 20);
            this.Mask_CEP.TabIndex = 10;
            this.Mask_CEP.Leave += new System.EventHandler(this.Mask_CEP_Leave);
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(325, 117);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(354, 21);
            this.Cmb_Estado.TabIndex = 15;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(6, 117);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(313, 20);
            this.Txt_Cidade.TabIndex = 14;
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(5, 101);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Cidade.TabIndex = 23;
            this.Lbl_Cidade.Text = "label1";
            // 
            // Grp_Outros
            // 
            this.Grp_Outros.Controls.Add(this.Mask_RendaFamiliar);
            this.Grp_Outros.Controls.Add(this.Mask_Telefone);
            this.Grp_Outros.Controls.Add(this.Lbl_Profissao);
            this.Grp_Outros.Controls.Add(this.Lbl_Telefone);
            this.Grp_Outros.Controls.Add(this.Lbl_RendaFamiliar);
            this.Grp_Outros.Controls.Add(this.Txt_Profissao);
            this.Grp_Outros.Location = new System.Drawing.Point(12, 454);
            this.Grp_Outros.Name = "Grp_Outros";
            this.Grp_Outros.Size = new System.Drawing.Size(685, 111);
            this.Grp_Outros.TabIndex = 18;
            this.Grp_Outros.TabStop = false;
            this.Grp_Outros.Text = "groupBox1";
            // 
            // Mask_RendaFamiliar
            // 
            this.Mask_RendaFamiliar.Location = new System.Drawing.Point(190, 74);
            this.Mask_RendaFamiliar.Mask = "$ 000,000,000.00";
            this.Mask_RendaFamiliar.Name = "Mask_RendaFamiliar";
            this.Mask_RendaFamiliar.Size = new System.Drawing.Size(313, 20);
            this.Mask_RendaFamiliar.TabIndex = 18;
            // 
            // Mask_Telefone
            // 
            this.Mask_Telefone.Location = new System.Drawing.Point(6, 36);
            this.Mask_Telefone.Mask = "(00) 00000-0000";
            this.Mask_Telefone.Name = "Mask_Telefone";
            this.Mask_Telefone.Size = new System.Drawing.Size(313, 20);
            this.Mask_Telefone.TabIndex = 16;
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.ApagaToolStripButton,
            this.LimparToolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(1162, 25);
            this.Tls_Principal.TabIndex = 30;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // ApagaToolStripButton
            // 
            this.ApagaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagaToolStripButton.Image = global::WinFormsCurso.Properties.Resources.ExcluirBarra;
            this.ApagaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagaToolStripButton.Name = "ApagaToolStripButton";
            this.ApagaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagaToolStripButton.Text = "toolStripButton1";
            this.ApagaToolStripButton.Click += new System.EventHandler(this.ApagaToolStripButton_Click);
            // 
            // LimparToolStripButton
            // 
            this.LimparToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimparToolStripButton.Image = global::WinFormsCurso.Properties.Resources.LimparBarra;
            this.LimparToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimparToolStripButton.Name = "LimparToolStripButton";
            this.LimparToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LimparToolStripButton.Text = "toolStripButton1";
            this.LimparToolStripButton.Click += new System.EventHandler(this.LimparToolStripButton_Click);
            // 
            // Grp_DataGrid
            // 
            this.Grp_DataGrid.Controls.Add(this.Dg_Clientes);
            this.Grp_DataGrid.Location = new System.Drawing.Point(704, 104);
            this.Grp_DataGrid.Name = "Grp_DataGrid";
            this.Grp_DataGrid.Size = new System.Drawing.Size(451, 461);
            this.Grp_DataGrid.TabIndex = 31;
            this.Grp_DataGrid.TabStop = false;
            this.Grp_DataGrid.Text = "groupBox1";
            // 
            // Dg_Clientes
            // 
            this.Dg_Clientes.AllowUserToAddRows = false;
            this.Dg_Clientes.AllowUserToDeleteRows = false;
            this.Dg_Clientes.AllowUserToOrderColumns = true;
            this.Dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.Dg_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dg_Clientes.Location = new System.Drawing.Point(3, 16);
            this.Dg_Clientes.MultiSelect = false;
            this.Dg_Clientes.Name = "Dg_Clientes";
            this.Dg_Clientes.ReadOnly = true;
            this.Dg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Clientes.Size = new System.Drawing.Size(445, 442);
            this.Dg_Clientes.TabIndex = 0;
            this.Dg_Clientes.DoubleClick += new System.EventHandler(this.Dg_Clientes_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Código Cliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_DataGrid);
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Grp_Outros);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_Codigo);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(1162, 589);
            this.Grp_Codigo.ResumeLayout(false);
            this.Grp_Codigo.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_Outros.ResumeLayout(false);
            this.Grp_Outros.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.Grp_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.Label Lbl_RendaFamiliar;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox Grp_Codigo;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.GroupBox Grp_Outros;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.MaskedTextBox Mask_CPF;
        private System.Windows.Forms.MaskedTextBox Mask_CEP;
        private System.Windows.Forms.MaskedTextBox Mask_Telefone;
        private System.Windows.Forms.MaskedTextBox Mask_RendaFamiliar;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagaToolStripButton;
        private System.Windows.Forms.ToolStripButton LimparToolStripButton;
        private System.Windows.Forms.Button Btn_Busca;
        private System.Windows.Forms.GroupBox Grp_DataGrid;
        private System.Windows.Forms.DataGridView Dg_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}
