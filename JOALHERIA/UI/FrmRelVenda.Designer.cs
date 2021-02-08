namespace JOALHERIA.UI
{
    partial class FrmRelVenda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ITEMPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVenda = new JOALHERIA.UI.DataSetVenda();
            this.VENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new JOALHERIA.UI.DataSet1();
            this.reportViewerParametros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewerNormal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPorData = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGerarPor = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPorData.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ITEMPEDIDOBindingSource
            // 
            this.ITEMPEDIDOBindingSource.DataMember = "ITEMPEDIDO";
            this.ITEMPEDIDOBindingSource.DataSource = this.DataSetVenda;
            // 
            // DataSetVenda
            // 
            this.DataSetVenda.DataSetName = "DataSetVenda";
            this.DataSetVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VENDABindingSource
            // 
            this.VENDABindingSource.DataMember = "VENDA";
            this.VENDABindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerParametros
            // 
            this.reportViewerParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetVendaa";
            reportDataSource1.Value = this.ITEMPEDIDOBindingSource;
            this.reportViewerParametros.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerParametros.LocalReport.ReportEmbeddedResource = "JOALHERIA.UI.ReportVenda.rdlc";
            this.reportViewerParametros.Location = new System.Drawing.Point(3, 140);
            this.reportViewerParametros.Name = "reportViewerParametros";
            this.reportViewerParametros.Size = new System.Drawing.Size(874, 156);
            this.reportViewerParametros.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewerNormal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.reportViewerParametros);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 301);
            this.panel1.TabIndex = 8;
            // 
            // reportViewerNormal
            // 
            this.reportViewerNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VENDABindingSource;
            this.reportViewerNormal.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerNormal.LocalReport.ReportEmbeddedResource = "JOALHERIA.UI.RelVendas.rdlc";
            this.reportViewerNormal.Location = new System.Drawing.Point(3, 140);
            this.reportViewerNormal.Name = "reportViewerNormal";
            this.reportViewerNormal.Size = new System.Drawing.Size(874, 156);
            this.reportViewerNormal.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pnlPorData);
            this.panel2.Controls.Add(this.pnlCodigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbGerarPor);
            this.panel2.Controls.Add(this.btnGerar);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 131);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Relatório de Vendas";
            // 
            // pnlPorData
            // 
            this.pnlPorData.Controls.Add(this.label4);
            this.pnlPorData.Controls.Add(this.label3);
            this.pnlPorData.Controls.Add(this.txtAte);
            this.pnlPorData.Controls.Add(this.txtDe);
            this.pnlPorData.Location = new System.Drawing.Point(5, 48);
            this.pnlPorData.Name = "pnlPorData";
            this.pnlPorData.Size = new System.Drawing.Size(400, 75);
            this.pnlPorData.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De";
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(233, 30);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 20);
            this.txtAte.TabIndex = 1;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(96, 30);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 0;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.txtFiltro);
            this.pnlCodigo.Controls.Add(this.label1);
            this.pnlCodigo.Location = new System.Drawing.Point(3, 51);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(400, 75);
            this.pnlCodigo.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(96, 27);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(294, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por";
            // 
            // cmbGerarPor
            // 
            this.cmbGerarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGerarPor.FormattingEnabled = true;
            this.cmbGerarPor.Items.AddRange(new object[] {
            "Codigo",
            "Data",
            "Normal"});
            this.cmbGerarPor.Location = new System.Drawing.Point(467, 73);
            this.cmbGerarPor.Name = "cmbGerarPor";
            this.cmbGerarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbGerarPor.TabIndex = 3;
            this.cmbGerarPor.SelectedIndexChanged += new System.EventHandler(this.cmbGerarPor_SelectedIndexChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Location = new System.Drawing.Point(513, 100);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // FrmRelVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 325);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRelVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPorData.ResumeLayout(false);
            this.pnlPorData.PerformLayout();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource VENDABindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource ITEMPEDIDOBindingSource;
        private DataSetVenda DataSetVenda;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerParametros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGerarPor;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel pnlPorData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNormal;
        private System.Windows.Forms.Label label5;
    }
}