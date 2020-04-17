namespace JOALHERIA
{
    partial class frmPesquisaP
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.lblSelecionados = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlNaoEncontrouRegistro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportRF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreçoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNaoEncontrouRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlItems);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(776, 426);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.lblSelecionados);
            this.pnlItems.Controls.Add(this.btnExcluir);
            this.pnlItems.Controls.Add(this.pictureBox1);
            this.pnlItems.Controls.Add(this.label11);
            this.pnlItems.Controls.Add(this.pnlNaoEncontrouRegistro);
            this.pnlItems.Controls.Add(this.btnExportRF);
            this.pnlItems.Controls.Add(this.btnImprimir);
            this.pnlItems.Controls.Add(this.btnEditar);
            this.pnlItems.Controls.Add(this.btnIncluir);
            this.pnlItems.Controls.Add(this.dgvProdutos);
            this.pnlItems.Controls.Add(this.label2);
            this.pnlItems.Controls.Add(this.cmbFiltros);
            this.pnlItems.Controls.Add(this.panel1);
            this.pnlItems.Controls.Add(this.btnPesquisar);
            this.pnlItems.Location = new System.Drawing.Point(3, 3);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(766, 416);
            this.pnlItems.TabIndex = 0;
            // 
            // lblSelecionados
            // 
            this.lblSelecionados.AutoSize = true;
            this.lblSelecionados.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelecionados.Location = new System.Drawing.Point(584, 125);
            this.lblSelecionados.Name = "lblSelecionados";
            this.lblSelecionados.Size = new System.Drawing.Size(122, 13);
            this.lblSelecionados.TabIndex = 26;
            this.lblSelecionados.Text = "Registros selecionados: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Location = new System.Drawing.Point(576, 371);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::JOALHERIA.Properties.Resources.imgCadProduto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(262, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 37);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(339, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Pesquisar Produtos";
            // 
            // pnlNaoEncontrouRegistro
            // 
            this.pnlNaoEncontrouRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNaoEncontrouRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNaoEncontrouRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNaoEncontrouRegistro.Controls.Add(this.label3);
            this.pnlNaoEncontrouRegistro.Location = new System.Drawing.Point(139, 210);
            this.pnlNaoEncontrouRegistro.Name = "pnlNaoEncontrouRegistro";
            this.pnlNaoEncontrouRegistro.Size = new System.Drawing.Size(512, 100);
            this.pnlNaoEncontrouRegistro.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(41, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "Não foram encontrados registros !";
            // 
            // btnExportRF
            // 
            this.btnExportRF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportRF.Location = new System.Drawing.Point(337, 371);
            this.btnExportRF.Name = "btnExportRF";
            this.btnExportRF.Size = new System.Drawing.Size(115, 23);
            this.btnExportRF.TabIndex = 10;
            this.btnExportRF.Text = "&Exportar para RF";
            this.btnExportRF.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.Location = new System.Drawing.Point(235, 371);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(144, 371);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluir.Location = new System.Drawing.Point(53, 371);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "In&cluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescricao,
            this.colCategoria,
            this.colQuantidade,
            this.colPreçoBruto,
            this.colPrecoVenda,
            this.colLucro,
            this.colObservacoes,
            this.colChkBox});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 141);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(758, 214);
            this.dgvProdutos.TabIndex = 6;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "ID Produto";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 83;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 77;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Estoque";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 71;
            // 
            // colPreçoBruto
            // 
            this.colPreçoBruto.HeaderText = "Preco Bruto";
            this.colPreçoBruto.Name = "colPreçoBruto";
            this.colPreçoBruto.ReadOnly = true;
            this.colPreçoBruto.Width = 88;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.HeaderText = "Preço Venda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.ReadOnly = true;
            this.colPrecoVenda.Width = 94;
            // 
            // colLucro
            // 
            this.colLucro.HeaderText = "Lucro";
            this.colLucro.Name = "colLucro";
            this.colLucro.ReadOnly = true;
            this.colLucro.Width = 59;
            // 
            // colObservacoes
            // 
            this.colObservacoes.HeaderText = "Observações";
            this.colObservacoes.Name = "colObservacoes";
            this.colObservacoes.ReadOnly = true;
            this.colObservacoes.Width = 95;
            // 
            // colChkBox
            // 
            this.colChkBox.HeaderText = "         ";
            this.colChkBox.Name = "colChkBox";
            this.colChkBox.Width = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Descrição"});
            this.cmbFiltros.Location = new System.Drawing.Point(530, 53);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltros.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 58);
            this.panel1.TabIndex = 3;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(50, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(399, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(53, 112);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPesquisaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisaP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar produtos";
            this.pnlFundo.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNaoEncontrouRegistro.ResumeLayout(false);
            this.pnlNaoEncontrouRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Button btnExportRF;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel pnlNaoEncontrouRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreçoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacoes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblSelecionados;
    }
}