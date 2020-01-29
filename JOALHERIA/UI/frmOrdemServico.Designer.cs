namespace JOALHERIA.UI
{
    partial class frmOrdemServico
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNomes = new System.Windows.Forms.Panel();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgServico = new System.Windows.Forms.PictureBox();
            this.btnSelecionarFormaPagamento = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtServico = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNomes.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::JOALHERIA.Properties.Resources.Cancelar1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1212, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuperior.BackColor = System.Drawing.Color.Teal;
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.label5);
            this.pnlSuperior.Controls.Add(this.pnlNomes);
            this.pnlSuperior.Controls.Add(this.txtData);
            this.pnlSuperior.Controls.Add(this.button1);
            this.pnlSuperior.Location = new System.Drawing.Point(2, 4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1244, 62);
            this.pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JOALHERIA.Properties.Resources.Financeiro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(292, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(21, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 33);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ordem de Serviços";
            // 
            // pnlNomes
            // 
            this.pnlNomes.Controls.Add(this.lblTituloUsuario);
            this.pnlNomes.Controls.Add(this.lblUsuario);
            this.pnlNomes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNomes.Location = new System.Drawing.Point(1104, 0);
            this.pnlNomes.Name = "pnlNomes";
            this.pnlNomes.Size = new System.Drawing.Size(140, 62);
            this.pnlNomes.TabIndex = 54;
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
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtData.AutoSize = true;
            this.txtData.BackColor = System.Drawing.Color.Teal;
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Yellow;
            this.txtData.Location = new System.Drawing.Point(823, 13);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(86, 33);
            this.txtData.TabIndex = 2;
            this.txtData.Text = "Data ";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInferior.BackColor = System.Drawing.Color.Teal;
            this.pnlInferior.Controls.Add(this.btnSair);
            this.pnlInferior.Controls.Add(this.btnFinalizar);
            this.pnlInferior.Location = new System.Drawing.Point(2, 701);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1244, 85);
            this.pnlInferior.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(942, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 63);
            this.btnSair.TabIndex = 56;
            this.btnSair.Text = "Sair (F1)";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFinalizar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(1058, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(176, 63);
            this.btnFinalizar.TabIndex = 55;
            this.btnFinalizar.Text = "Finalizar (F10)";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTroco);
            this.panel1.Controls.Add(this.cmbForma);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtValorPago);
            this.panel1.Controls.Add(this.lblTroco);
            this.panel1.Controls.Add(this.lblValorPago);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.dgvItens);
            this.panel1.Controls.Add(this.imgServico);
            this.panel1.Controls.Add(this.btnSelecionarFormaPagamento);
            this.panel1.Controls.Add(this.btnSelecionarProduto);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnSelecionarCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtServico);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 623);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 96;
            this.label6.Text = "Total Geral:";
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTroco.BackColor = System.Drawing.Color.Teal;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTroco.Location = new System.Drawing.Point(951, 575);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(280, 41);
            this.txtTroco.TabIndex = 95;
            this.txtTroco.Text = "00,00";
            this.txtTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTroco.Visible = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPago.BackColor = System.Drawing.Color.Teal;
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtValorPago.Location = new System.Drawing.Point(951, 532);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(280, 40);
            this.txtValorPago.TabIndex = 94;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago.Visible = false;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // lblTroco
            // 
            this.lblTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.White;
            this.lblTroco.Location = new System.Drawing.Point(859, 584);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(86, 32);
            this.lblTroco.TabIndex = 93;
            this.lblTroco.Text = "Troco";
            this.lblTroco.Visible = false;
            // 
            // lblValorPago
            // 
            this.lblValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.ForeColor = System.Drawing.Color.White;
            this.lblValorPago.Location = new System.Drawing.Point(741, 536);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(208, 32);
            this.lblValorPago.TabIndex = 92;
            this.lblValorPago.Text = "Valor Pago(F2)";
            this.lblValorPago.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.Teal;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTotal.Location = new System.Drawing.Point(3, 543);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(456, 75);
            this.txtTotal.TabIndex = 91;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(467, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 32);
            this.label7.TabIndex = 90;
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
            this.cmbForma.Location = new System.Drawing.Point(470, 571);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(290, 41);
            this.cmbForma.TabIndex = 89;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvItens.Location = new System.Drawing.Point(17, 190);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(641, 292);
            this.dgvItens.TabIndex = 88;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDSERVICO";
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
            // imgServico
            // 
            this.imgServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgServico.ErrorImage = null;
            this.imgServico.Location = new System.Drawing.Point(664, 190);
            this.imgServico.Name = "imgServico";
            this.imgServico.Size = new System.Drawing.Size(281, 287);
            this.imgServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgServico.TabIndex = 87;
            this.imgServico.TabStop = false;
            // 
            // btnSelecionarFormaPagamento
            // 
            this.btnSelecionarFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarFormaPagamento.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarFormaPagamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarFormaPagamento.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSelecionarFormaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarFormaPagamento.Location = new System.Drawing.Point(1028, 422);
            this.btnSelecionarFormaPagamento.Name = "btnSelecionarFormaPagamento";
            this.btnSelecionarFormaPagamento.Size = new System.Drawing.Size(203, 55);
            this.btnSelecionarFormaPagamento.TabIndex = 86;
            this.btnSelecionarFormaPagamento.Text = "Pagamento (F9)";
            this.btnSelecionarFormaPagamento.UseVisualStyleBackColor = false;
            this.btnSelecionarFormaPagamento.Click += new System.EventHandler(this.btnSelecionarFormaPagamento_Click);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarProduto.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarProduto.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSelecionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(1028, 223);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(203, 63);
            this.btnSelecionarProduto.TabIndex = 83;
            this.btnSelecionarProduto.Text = "Buscar Serviço (F6)";
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.Teal;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(1028, 361);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(203, 55);
            this.btnRemover.TabIndex = 85;
            this.btnRemover.Text = "Remover (F8)";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.Location = new System.Drawing.Point(1028, 292);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(203, 63);
            this.btnAdicionar.TabIndex = 84;
            this.btnAdicionar.Text = "Adicionar (F7)";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarCliente.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSelecionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(1028, 154);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(203, 63);
            this.btnSelecionarCliente.TabIndex = 82;
            this.btnSelecionarCliente.Text = "Buscar Cliente (F5)";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 80;
            this.label3.Text = "Serviço:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(728, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 79;
            this.label1.Text = "Qtd:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.Teal;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(806, 134);
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
            this.txtQuantidade.TabIndex = 78;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtServico
            // 
            this.txtServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServico.BackColor = System.Drawing.Color.Teal;
            this.txtServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServico.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtServico.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtServico.Location = new System.Drawing.Point(233, 57);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(871, 67);
            this.txtServico.TabIndex = 77;
            this.txtServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.BackColor = System.Drawing.Color.Teal;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPreco.Location = new System.Drawing.Point(505, 134);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(217, 53);
            this.txtPreco.TabIndex = 76;
            this.txtPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "Preço Unitário (R$):";
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
            this.txtCliente.Location = new System.Drawing.Point(125, 8);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(979, 41);
            this.txtCliente.TabIndex = 66;
            this.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 65;
            this.label4.Text = "Cliente:";
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1248, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdemServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrdemServico_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNomes.ResumeLayout(false);
            this.pnlNomes.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label txtServico;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionarFormaPagamento;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.PictureBox imgServico;
        private System.Windows.Forms.Label txtTroco;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNomes;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}