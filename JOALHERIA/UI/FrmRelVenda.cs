using JOALHERIABLL;
using JOALHERIADAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JOALHERIA.UI
{
    public partial class FrmRelVenda : Form
    {
        JOALHERIABLL.VendaBLL vendaBLL = new JOALHERIABLL.VendaBLL();
        JOALHERIADAL.VendaDAL vendaDAL = new JOALHERIADAL.VendaDAL();

        public int codVenda { get; set; }
        string Tipo { get; set; }
        public FrmRelVenda()
        {
            InitializeComponent();
        }

        //Metodo relatorio Normal
        private void RelatorioNormal()
        {
            reportViewerNormal.Clear();

            this.reportViewerNormal.LocalReport.SetParameters(new ReportParameter("Usuario", LoginBLL.User.Usuario.ToString()));
            this.reportViewerNormal.RefreshReport();

            vendaDAL.RelatorioVenda().Fill(DataSet1, "VENDA");

            this.reportViewerNormal.RefreshReport();
        }

        //metodo relatorio por codigo ( detalhado )
        private void RelatorioPorParametro(int codigo)
        {
            reportViewerParametros.Clear();
            //======================================================================
            vendaBLL.Idvenda = codigo;
            vendaBLL = vendaDAL.RetornarDados(vendaBLL);

            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("IDVENDA", vendaBLL.Idvenda.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("IDCLIENTE", vendaBLL.Idcliente.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("DATAVENDA", vendaBLL.Datavenda.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("USUARIO", vendaBLL.Usuario.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("PRECOTOTAL", vendaBLL.Precototal.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("FORMAPAGAMENTO", vendaBLL.Formapagamento.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("VALORPAGO", vendaBLL.Valorpago.ToString()));
            this.reportViewerParametros.LocalReport.SetParameters(new ReportParameter("TROCO", vendaBLL.Troco.ToString()));
            this.reportViewerParametros.RefreshReport();

            vendaDAL.RelatorioItensVenda(vendaBLL.Idvenda).Fill(DataSetVenda, "ITEMPEDIDO");
            this.reportViewerParametros.RefreshReport();
        }

        //metodo Gerar Relatorio Por Data 
        private void RelatorioPorData(string de, string ate)
        {
            reportViewerNormal.Clear();

            this.reportViewerNormal.LocalReport.SetParameters(new ReportParameter("Usuario", LoginBLL.User.Usuario.ToString()));
            this.reportViewerNormal.RefreshReport();

            vendaDAL.RelatorioPorData(de, ate).Fill(DataSet1, "VENDA");
            this.reportViewerNormal.RefreshReport();
        }

        private void FrmRelVenda_Load(object sender, EventArgs e)
        {
            ////codigo localizar caminho do software
            //string caminho = Environment.CurrentDirectory.ToString();
            //caminho = caminho.Substring(0, caminho.Length - 9);
            //caminho = caminho + @"UI\";    
            //ReportParameter reportParameter = new ReportParameter();

            //int result;
            //try
            //{
            //    if (Tipo == "normal")
            //        RelatorioNormal();

            //    if (Tipo == "pordata")
            //        RelatorioPorData(txtDe.Text, txtAte.Text);

            //    if (Tipo == "parametros")
            //    {
            //        int.TryParse(txtFiltro.Text, out result);
            //        RelatorioPorParametro(result);
            //    }

            //}catch(Exception ex)
            //{
            //    MessageBox.Show("" + ex.Message, "Erro ao gerar Relatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F10:
                    //btnSair.PerformClick();
                    this.Close();
                    break;

                case Keys.F2:
                    // txtCodVenda.Focus();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerItens_Click(object sender, EventArgs e)
        {
        }
        private void cmbGerarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo = cmbGerarPor.Text;
            FiltrarPor();
        }
        private void FiltrarPor()
        {
            if (Tipo == "Codigo")
            {
                reportViewerNormal.Clear();
                reportViewerNormal.Visible = pnlPorData.Visible = false;
                reportViewerParametros.Visible = pnlCodigo.Visible = true;
            }

            if (Tipo == "Normal")
            {
                reportViewerParametros.Clear();
                reportViewerParametros.Visible = pnlPorData.Visible = false;
                reportViewerNormal.Visible = pnlCodigo.Visible = true;
            }

            if (Tipo == "Data")
            {
                reportViewerParametros.Clear();
                reportViewerParametros.Visible = pnlCodigo.Visible = false;
                pnlPorData.Visible = reportViewerNormal.Visible = true;
            }
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                if (Tipo == "Normal")
                    RelatorioNormal();

                else if (Tipo == "Data")
                    RelatorioPorData(txtDe.Text, txtAte.Text);

                else if (Tipo == "Codigo")
                {
                    int.TryParse(txtFiltro.Text, out result);
                    if (result > 0)
                        RelatorioPorParametro(result);
                }
            }
            catch (Exception ex)
            {
                NetworkLog.Insert(ex, "frmRelVenda.cs");
                MessageBox.Show("" + ex.Message, "Erro ao gerar Relatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
