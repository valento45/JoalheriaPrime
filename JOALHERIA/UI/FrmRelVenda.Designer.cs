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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerParametros = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VENDABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JOALHERIA.UI.RelVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(885, 494);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 526);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerParametros);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerParametros
            // 
            this.reportViewerParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetVendaa";
            reportDataSource2.Value = this.ITEMPEDIDOBindingSource;
            this.reportViewerParametros.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerParametros.LocalReport.ReportEmbeddedResource = "JOALHERIA.UI.ReportVenda.rdlc";
            this.reportViewerParametros.Location = new System.Drawing.Point(3, 3);
            this.reportViewerParametros.Name = "reportViewerParametros";
            this.reportViewerParametros.Size = new System.Drawing.Size(885, 494);
            this.reportViewerParametros.TabIndex = 7;
            this.reportViewerParametros.Visible = false;
            // 
            // FrmRelVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRelVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITEMPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VENDABindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource ITEMPEDIDOBindingSource;
        private DataSetVenda DataSetVenda;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerParametros;
    }
}