namespace JOALHERIA.UI
{
    partial class frmRelatorioOS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataSetOS = new JOALHERIA.UI.DataSetOS();
            this.OrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlReport.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReport
            // 
            this.pnlReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlReport.Controls.Add(this.reportViewer1);
            this.pnlReport.Location = new System.Drawing.Point(12, 110);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(835, 226);
            this.pnlReport.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.OrdemServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JOALHERIA.UI.RelatorioOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(835, 226);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.pnl);
            this.pnlFiltro.Controls.Add(this.cmbFiltro);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.btnGerar);
            this.pnlFiltro.Controls.Add(this.pnlPeriodo);
            this.pnlFiltro.Location = new System.Drawing.Point(12, 4);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(835, 106);
            this.pnlFiltro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ate";
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.label1);
            this.pnlPeriodo.Controls.Add(this.label2);
            this.pnlPeriodo.Location = new System.Drawing.Point(3, 35);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(315, 63);
            this.pnlPeriodo.TabIndex = 4;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(45, 19);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 3;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(180, 19);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 20);
            this.txtAte.TabIndex = 4;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(421, 77);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(125, 23);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisar por";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "OS",
            "Periodo"});
            this.cmbFiltro.Location = new System.Drawing.Point(421, 54);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 7;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtFiltro);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Location = new System.Drawing.Point(12, 35);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(315, 63);
            this.pnl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(54, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(252, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Relatório de OS";
            // 
            // DataSetOS
            // 
            this.DataSetOS.DataSetName = "DataSetOS";
            this.DataSetOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdemServicoBindingSource
            // 
            this.OrdemServicoBindingSource.DataMember = "OrdemServico";
            this.OrdemServicoBindingSource.DataSource = this.DataSetOS;
            // 
            // frmRelatorioOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(859, 348);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorioOS";
            this.Text = "Relatório de OS";
            this.Load += new System.EventHandler(this.frmRelatorioOS_Load);
            this.pnlReport.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource OrdemServicoBindingSource;
        private DataSetOS DataSetOS;
    }
}