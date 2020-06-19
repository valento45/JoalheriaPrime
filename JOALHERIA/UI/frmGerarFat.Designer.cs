namespace JOALHERIA.UI
{
    partial class frmGerarFat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkDiario = new System.Windows.Forms.RadioButton();
            this.chkMensal = new System.Windows.Forms.RadioButton();
            this.chkAnual = new System.Windows.Forms.RadioButton();
            this.chkPeriodo = new System.Windows.Forms.RadioButton();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 165);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnGerar);
            this.panel2.Controls.Add(this.pnlPeriodo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 157);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkPeriodo);
            this.panel3.Controls.Add(this.chkAnual);
            this.panel3.Controls.Add(this.chkMensal);
            this.panel3.Controls.Add(this.chkDiario);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 103);
            this.panel3.TabIndex = 0;
            // 
            // chkDiario
            // 
            this.chkDiario.AutoSize = true;
            this.chkDiario.Checked = true;
            this.chkDiario.Location = new System.Drawing.Point(3, 3);
            this.chkDiario.Name = "chkDiario";
            this.chkDiario.Size = new System.Drawing.Size(52, 17);
            this.chkDiario.TabIndex = 0;
            this.chkDiario.TabStop = true;
            this.chkDiario.Text = "Diário";
            this.chkDiario.UseVisualStyleBackColor = true;
            // 
            // chkMensal
            // 
            this.chkMensal.AutoSize = true;
            this.chkMensal.Location = new System.Drawing.Point(3, 26);
            this.chkMensal.Name = "chkMensal";
            this.chkMensal.Size = new System.Drawing.Size(59, 17);
            this.chkMensal.TabIndex = 1;
            this.chkMensal.TabStop = true;
            this.chkMensal.Text = "Mensal";
            this.chkMensal.UseVisualStyleBackColor = true;
            // 
            // chkAnual
            // 
            this.chkAnual.AutoSize = true;
            this.chkAnual.Location = new System.Drawing.Point(3, 49);
            this.chkAnual.Name = "chkAnual";
            this.chkAnual.Size = new System.Drawing.Size(52, 17);
            this.chkAnual.TabIndex = 2;
            this.chkAnual.TabStop = true;
            this.chkAnual.Text = "Anual";
            this.chkAnual.UseVisualStyleBackColor = true;
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(3, 72);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(63, 17);
            this.chkPeriodo.TabIndex = 3;
            this.chkPeriodo.TabStop = true;
            this.chkPeriodo.Text = "Período";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.label2);
            this.pnlPeriodo.Controls.Add(this.label1);
            this.pnlPeriodo.Location = new System.Drawing.Point(135, 6);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(265, 100);
            this.pnlPeriodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(31, 16);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(79, 20);
            this.txtDe.TabIndex = 2;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(31, 43);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(79, 20);
            this.txtAte.TabIndex = 3;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Location = new System.Drawing.Point(325, 131);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // frmGerarFat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 189);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGerarFat";
            this.Text = "Gerar faturamento";
            this.Load += new System.EventHandler(this.frmGerarFat_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton chkPeriodo;
        private System.Windows.Forms.RadioButton chkAnual;
        private System.Windows.Forms.RadioButton chkMensal;
        private System.Windows.Forms.RadioButton chkDiario;
        private System.Windows.Forms.Button btnGerar;
    }
}