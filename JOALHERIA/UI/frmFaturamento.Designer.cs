namespace JOALHERIA.UI
{
    partial class frmFaturamento
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
            this.lblTotalOS = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.colIdOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdClienteOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotalOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormaPgtoOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPgtoOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrocoOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormaPgto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTroco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkServicos = new System.Windows.Forms.CheckBox();
            this.chkVendas = new System.Windows.Forms.CheckBox();
            this.lblTotalOSeVenda = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.lblTotalOSeVenda);
            this.pnlFundo.Controls.Add(this.lblTotalOS);
            this.pnlFundo.Controls.Add(this.lblTotalVenda);
            this.pnlFundo.Controls.Add(this.dgvServicos);
            this.pnlFundo.Controls.Add(this.dgvVendas);
            this.pnlFundo.Controls.Add(this.panel1);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(764, 466);
            this.pnlFundo.TabIndex = 0;
            // 
            // lblTotalOS
            // 
            this.lblTotalOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOS.AutoSize = true;
            this.lblTotalOS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOS.Location = new System.Drawing.Point(536, 362);
            this.lblTotalOS.Name = "lblTotalOS";
            this.lblTotalOS.Size = new System.Drawing.Size(50, 18);
            this.lblTotalOS.TabIndex = 4;
            this.lblTotalOS.Text = "label4";
            this.lblTotalOS.Visible = false;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(536, 219);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(50, 18);
            this.lblTotalVenda.TabIndex = 3;
            this.lblTotalVenda.Text = "label4";
            this.lblTotalVenda.Visible = false;
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdOrdem,
            this.colIdClienteOS,
            this.colData,
            this.colDataEntrega,
            this.colDesconto,
            this.colValorTotalOS,
            this.colFormaPgtoOS,
            this.colValorPgtoOS,
            this.colTrocoOS});
            this.dgvServicos.Location = new System.Drawing.Point(3, 253);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(756, 106);
            this.dgvServicos.TabIndex = 2;
            this.dgvServicos.Visible = false;
            // 
            // colIdOrdem
            // 
            this.colIdOrdem.HeaderText = "Código OS";
            this.colIdOrdem.Name = "colIdOrdem";
            // 
            // colIdClienteOS
            // 
            this.colIdClienteOS.HeaderText = "Id Cliente";
            this.colIdClienteOS.Name = "colIdClienteOS";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.HeaderText = "Entrega";
            this.colDataEntrega.Name = "colDataEntrega";
            // 
            // colDesconto
            // 
            this.colDesconto.HeaderText = "Desconto";
            this.colDesconto.Name = "colDesconto";
            // 
            // colValorTotalOS
            // 
            this.colValorTotalOS.HeaderText = "Total";
            this.colValorTotalOS.Name = "colValorTotalOS";
            // 
            // colFormaPgtoOS
            // 
            this.colFormaPgtoOS.HeaderText = "Forma pgto";
            this.colFormaPgtoOS.Name = "colFormaPgtoOS";
            // 
            // colValorPgtoOS
            // 
            this.colValorPgtoOS.HeaderText = "Valor pago";
            this.colValorPgtoOS.Name = "colValorPgtoOS";
            // 
            // colTrocoOS
            // 
            this.colTrocoOS.HeaderText = "Troco";
            this.colTrocoOS.Name = "colTrocoOS";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colIdCliente,
            this.colDataVenda,
            this.colUsuario,
            this.colPrecoTotal,
            this.colFormaPgto,
            this.colValorPago,
            this.colTroco});
            this.dgvVendas.Location = new System.Drawing.Point(3, 110);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(756, 106);
            this.dgvVendas.TabIndex = 1;
            this.dgvVendas.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colIdCliente
            // 
            this.colIdCliente.HeaderText = "Id Cliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colDataVenda
            // 
            this.colDataVenda.HeaderText = "Data";
            this.colDataVenda.Name = "colDataVenda";
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colPrecoTotal
            // 
            this.colPrecoTotal.HeaderText = "Total";
            this.colPrecoTotal.Name = "colPrecoTotal";
            // 
            // colFormaPgto
            // 
            this.colFormaPgto.HeaderText = "Forma Pgto";
            this.colFormaPgto.Name = "colFormaPgto";
            // 
            // colValorPago
            // 
            this.colValorPago.HeaderText = "Valor Pago";
            this.colValorPago.Name = "colValorPago";
            // 
            // colTroco
            // 
            this.colTroco.HeaderText = "Troco";
            this.colTroco.Name = "colTroco";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlPeriodo);
            this.panel1.Controls.Add(this.btGerar);
            this.panel1.Controls.Add(this.cmbFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkServicos);
            this.panel1.Controls.Add(this.chkVendas);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 88);
            this.panel1.TabIndex = 0;
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.label3);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.label2);
            this.pnlPeriodo.Location = new System.Drawing.Point(356, 3);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(148, 68);
            this.pnlPeriodo.TabIndex = 5;
            this.pnlPeriodo.Visible = false;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(30, 39);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(92, 20);
            this.txtAte.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Até";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(30, 15);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(92, 20);
            this.txtDe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "De";
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(268, 48);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 4;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "Diário",
            "Mensal",
            "Anual",
            "Período"});
            this.cmbFiltrar.Location = new System.Drawing.Point(222, 21);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrar.TabIndex = 3;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por";
            // 
            // chkServicos
            // 
            this.chkServicos.AutoSize = true;
            this.chkServicos.Location = new System.Drawing.Point(28, 45);
            this.chkServicos.Name = "chkServicos";
            this.chkServicos.Size = new System.Drawing.Size(67, 17);
            this.chkServicos.TabIndex = 1;
            this.chkServicos.Text = "Serviços";
            this.chkServicos.UseVisualStyleBackColor = true;
            // 
            // chkVendas
            // 
            this.chkVendas.AutoSize = true;
            this.chkVendas.Location = new System.Drawing.Point(28, 22);
            this.chkVendas.Name = "chkVendas";
            this.chkVendas.Size = new System.Drawing.Size(62, 17);
            this.chkVendas.TabIndex = 0;
            this.chkVendas.Text = "Vendas";
            this.chkVendas.UseVisualStyleBackColor = true;
            // 
            // lblTotalOSeVenda
            // 
            this.lblTotalOSeVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalOSeVenda.AutoSize = true;
            this.lblTotalOSeVenda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOSeVenda.Location = new System.Drawing.Point(3, 423);
            this.lblTotalOSeVenda.Name = "lblTotalOSeVenda";
            this.lblTotalOSeVenda.Size = new System.Drawing.Size(145, 18);
            this.lblTotalOSeVenda.TabIndex = 5;
            this.lblTotalOSeVenda.Text = "Total OS e Vendas: ";
            // 
            // frmFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 490);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmFaturamento";
            this.Text = "Faturamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkServicos;
        private System.Windows.Forms.CheckBox chkVendas;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdClienteOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotalOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPgtoOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPgtoOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrocoOS;
        private System.Windows.Forms.Label lblTotalOS;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label lblTotalOSeVenda;
    }
}