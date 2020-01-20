namespace JOALHERIA.UI
{
    partial class frmVenda
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNomes = new System.Windows.Forms.Panel();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.Label();
            this.btnSelecionarFormaPagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlNomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.pnlRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pnlNomes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 58);
            this.panel1.TabIndex = 0;
            // 
            // pnlNomes
            // 
            this.pnlNomes.Controls.Add(this.lblTituloUsuario);
            this.pnlNomes.Controls.Add(this.lblUsuario);
            this.pnlNomes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNomes.Location = new System.Drawing.Point(1000, 0);
            this.pnlNomes.Name = "pnlNomes";
            this.pnlNomes.Size = new System.Drawing.Size(140, 58);
            this.pnlNomes.TabIndex = 53;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTituloUsuario.Location = new System.Drawing.Point(10, 4);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(66, 16);
            this.lblTituloUsuario.TabIndex = 11;
            this.lblTituloUsuario.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblUsuario.Location = new System.Drawing.Point(9, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(120, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JOALHERIA.Properties.Resources.imgFinanceiro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitulo.Location = new System.Drawing.Point(96, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(351, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Frente de Caixa - PDV | System Joias";
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtData.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtData.Location = new System.Drawing.Point(19, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(272, 76);
            this.txtData.TabIndex = 74;
            this.txtData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(847, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 63);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "Sair (F1)";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.BackColor = System.Drawing.Color.Teal;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPreco.Location = new System.Drawing.Point(263, 229);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(217, 66);
            this.txtPreco.TabIndex = 61;
            this.txtPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 60;
            this.label2.Text = "Preço Unitário (R$):";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BackColor = System.Drawing.Color.Teal;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProduto.Location = new System.Drawing.Point(239, 137);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(900, 78);
            this.txtProduto.TabIndex = 62;
            this.txtProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.BackColor = System.Drawing.Color.Teal;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCliente.Location = new System.Drawing.Point(127, 82);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(1012, 41);
            this.txtCliente.TabIndex = 64;
            this.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cliente:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvItens.Location = new System.Drawing.Point(12, 314);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(631, 292);
            this.dgvItens.TabIndex = 66;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDPRODUTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DESCRIÇÃO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTIDADE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.Teal;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTotal.Location = new System.Drawing.Point(19, 751);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(456, 75);
            this.txtTotal.TabIndex = 72;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 71;
            this.label1.Text = "Qtd:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 32);
            this.label7.TabIndex = 70;
            this.label7.Text = "Tipo de Pagamento";
            // 
            // cmbForma
            // 
            this.cmbForma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbForma.BackColor = System.Drawing.Color.Teal;
            this.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForma.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.cmbForma.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cmbForma.Location = new System.Drawing.Point(397, 697);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(290, 41);
            this.cmbForma.TabIndex = 67;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 69;
            this.label6.Text = "Total Geral:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.Teal;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtQuantidade.Location = new System.Drawing.Point(564, 229);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(175, 41);
            this.txtQuantidade.TabIndex = 68;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRodape.BackColor = System.Drawing.Color.Teal;
            this.pnlRodape.Controls.Add(this.txtData);
            this.pnlRodape.Controls.Add(this.btnSair);
            this.pnlRodape.Controls.Add(this.btnFinalizar);
            this.pnlRodape.Location = new System.Drawing.Point(0, 832);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1144, 83);
            this.pnlRodape.TabIndex = 73;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFinalizar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(963, 8);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(176, 63);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar (F10)";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarCliente.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(936, 258);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(203, 63);
            this.btnSelecionarCliente.TabIndex = 0;
            this.btnSelecionarCliente.Text = "Buscar Cliente (F5)";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarProduto.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(936, 327);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(203, 63);
            this.btnSelecionarProduto.TabIndex = 1;
            this.btnSelecionarProduto.Text = "Buscar Produto (F6)";
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.Location = new System.Drawing.Point(936, 396);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(203, 63);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar (F7)";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.Teal;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.Black;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(936, 465);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(203, 55);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover (F8)";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // imgProduto
            // 
            this.imgProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgProduto.ErrorImage = null;
            this.imgProduto.Location = new System.Drawing.Point(649, 319);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(281, 287);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduto.TabIndex = 65;
            this.imgProduto.TabStop = false;
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 74;
            this.label3.Text = "Produto:";
            // 
            // lblValorPago
            // 
            this.lblValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(693, 702);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(160, 32);
            this.lblValorPago.TabIndex = 75;
            this.lblValorPago.Text = "Valor Pago";
            this.lblValorPago.Visible = false;
            // 
            // lblTroco
            // 
            this.lblTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(767, 762);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(86, 32);
            this.lblTroco.TabIndex = 77;
            this.lblTroco.Text = "Troco";
            this.lblTroco.Visible = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPago.BackColor = System.Drawing.Color.Teal;
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtValorPago.Location = new System.Drawing.Point(859, 693);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(280, 40);
            this.txtValorPago.TabIndex = 78;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago.Visible = false;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTroco.BackColor = System.Drawing.Color.Teal;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTroco.Location = new System.Drawing.Point(859, 753);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(280, 41);
            this.txtTroco.TabIndex = 80;
            this.txtTroco.Text = "00,00";
            this.txtTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTroco.Visible = false;
            // 
            // btnSelecionarFormaPagamento
            // 
            this.btnSelecionarFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarFormaPagamento.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarFormaPagamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarFormaPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionarFormaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarFormaPagamento.Location = new System.Drawing.Point(936, 526);
            this.btnSelecionarFormaPagamento.Name = "btnSelecionarFormaPagamento";
            this.btnSelecionarFormaPagamento.Size = new System.Drawing.Size(203, 55);
            this.btnSelecionarFormaPagamento.TabIndex = 81;
            this.btnSelecionarFormaPagamento.Text = "Pagamento (F9)";
            this.btnSelecionarFormaPagamento.UseVisualStyleBackColor = false;
            this.btnSelecionarFormaPagamento.Click += new System.EventHandler(this.btnSelecionarFormaPagamento_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1144, 920);
            this.Controls.Add(this.btnSelecionarFormaPagamento);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.btnSelecionarProduto);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNomes.ResumeLayout(false);
            this.pnlNomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlNomes;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtProduto;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label txtTroco;
        private System.Windows.Forms.Button btnSelecionarFormaPagamento;
    }
}