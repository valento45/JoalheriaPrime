namespace JOALHERIA.UI
{
    partial class frmImprimirVenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rdbParametros = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.mtxtData2 = new System.Windows.Forms.MaskedTextBox();
            this.rdbPorTipo = new System.Windows.Forms.RadioButton();
            this.mtxtData1 = new System.Windows.Forms.MaskedTextBox();
            this.rdbPorData = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlXml = new System.Windows.Forms.Panel();
            this.btnGerarXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSelecionado = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlXml.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.rdbParametros);
            this.groupBox1.Controls.Add(this.rdbNormal);
            this.groupBox1.Controls.Add(this.lblAte);
            this.groupBox1.Controls.Add(this.lblDe);
            this.groupBox1.Controls.Add(this.mtxtData2);
            this.groupBox1.Controls.Add(this.rdbPorTipo);
            this.groupBox1.Controls.Add(this.mtxtData1);
            this.groupBox1.Controls.Add(this.rdbPorData);
            this.groupBox1.Location = new System.Drawing.Point(23, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar Relatório";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(121, 85);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(21, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "ID:";
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Visible = false;
            // 
            // rdbParametros
            // 
            this.rdbParametros.AutoSize = true;
            this.rdbParametros.Location = new System.Drawing.Point(7, 83);
            this.rdbParametros.Name = "rdbParametros";
            this.rdbParametros.Size = new System.Drawing.Size(110, 17);
            this.rdbParametros.TabIndex = 8;
            this.rdbParametros.Text = "Venda Específica";
            this.rdbParametros.UseVisualStyleBackColor = true;
            this.rdbParametros.CheckedChanged += new System.EventHandler(this.rdbParametros_CheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(7, 62);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 7;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(251, 22);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(26, 13);
            this.lblAte.TabIndex = 6;
            this.lblAte.Text = "Até:";
            this.lblAte.Visible = false;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(119, 22);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 5;
            this.lblDe.Text = "De:";
            this.lblDe.Visible = false;
            // 
            // mtxtData2
            // 
            this.mtxtData2.Location = new System.Drawing.Point(281, 17);
            this.mtxtData2.Mask = "00/00/0000";
            this.mtxtData2.Name = "mtxtData2";
            this.mtxtData2.Size = new System.Drawing.Size(100, 20);
            this.mtxtData2.TabIndex = 4;
            this.mtxtData2.Visible = false;
            // 
            // rdbPorTipo
            // 
            this.rdbPorTipo.AutoSize = true;
            this.rdbPorTipo.Location = new System.Drawing.Point(7, 41);
            this.rdbPorTipo.Name = "rdbPorTipo";
            this.rdbPorTipo.Size = new System.Drawing.Size(61, 17);
            this.rdbPorTipo.TabIndex = 1;
            this.rdbPorTipo.Text = "Por tipo";
            this.rdbPorTipo.UseVisualStyleBackColor = true;
            this.rdbPorTipo.CheckedChanged += new System.EventHandler(this.rdbPorTipo_CheckedChanged);
            // 
            // mtxtData1
            // 
            this.mtxtData1.Location = new System.Drawing.Point(145, 17);
            this.mtxtData1.Mask = "00/00/0000";
            this.mtxtData1.Name = "mtxtData1";
            this.mtxtData1.Size = new System.Drawing.Size(100, 20);
            this.mtxtData1.TabIndex = 3;
            this.mtxtData1.Visible = false;
            // 
            // rdbPorData
            // 
            this.rdbPorData.AutoSize = true;
            this.rdbPorData.Location = new System.Drawing.Point(7, 20);
            this.rdbPorData.Name = "rdbPorData";
            this.rdbPorData.Size = new System.Drawing.Size(65, 17);
            this.rdbPorData.TabIndex = 0;
            this.rdbPorData.Text = "Por data";
            this.rdbPorData.UseVisualStyleBackColor = true;
            this.rdbPorData.CheckedChanged += new System.EventHandler(this.rdbPorData_CheckedChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.Location = new System.Drawing.Point(376, 170);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(84, 24);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReport.Controls.Add(this.btnGerar);
            this.pnlReport.Controls.Add(this.groupBox1);
            this.pnlReport.Location = new System.Drawing.Point(12, 29);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(514, 217);
            this.pnlReport.TabIndex = 4;
            this.pnlReport.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::JOALHERIA.Properties.Resources.Cancelar11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(441, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlXml
            // 
            this.pnlXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlXml.Controls.Add(this.btnGerarXml);
            this.pnlXml.Controls.Add(this.groupBox2);
            this.pnlXml.Location = new System.Drawing.Point(12, 28);
            this.pnlXml.Name = "pnlXml";
            this.pnlXml.Size = new System.Drawing.Size(514, 227);
            this.pnlXml.TabIndex = 5;
            this.pnlXml.Visible = false;
            // 
            // btnGerarXml
            // 
            this.btnGerarXml.Location = new System.Drawing.Point(283, 151);
            this.btnGerarXml.Name = "btnGerarXml";
            this.btnGerarXml.Size = new System.Drawing.Size(75, 23);
            this.btnGerarXml.TabIndex = 1;
            this.btnGerarXml.Text = "Gerar";
            this.btnGerarXml.UseVisualStyleBackColor = true;
            this.btnGerarXml.Click += new System.EventHandler(this.btnGerarXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSelecionado);
            this.groupBox2.Controls.Add(this.rdbTodos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(158, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML";
            // 
            // rdbSelecionado
            // 
            this.rdbSelecionado.AutoSize = true;
            this.rdbSelecionado.Location = new System.Drawing.Point(49, 61);
            this.rdbSelecionado.Name = "rdbSelecionado";
            this.rdbSelecionado.Size = new System.Drawing.Size(130, 17);
            this.rdbSelecionado.TabIndex = 1;
            this.rdbSelecionado.TabStop = true;
            this.rdbSelecionado.Text = "Apenas o selecionado";
            this.rdbSelecionado.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(49, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(80, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Gerar todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.xml|*txt";
            // 
            // frmImprimirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(537, 257);
            this.Controls.Add(this.pnlXml);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImprimirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.frmImprimir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlXml.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rdbParametros;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.MaskedTextBox mtxtData2;
        private System.Windows.Forms.RadioButton rdbPorTipo;
        private System.Windows.Forms.MaskedTextBox mtxtData1;
        private System.Windows.Forms.RadioButton rdbPorData;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlXml;
        private System.Windows.Forms.Button btnGerarXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSelecionado;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}