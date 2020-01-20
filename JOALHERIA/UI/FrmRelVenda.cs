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

        public FrmRelVenda()
        {
            InitializeComponent();
        }

        private void FrmRelVenda_Load(object sender, EventArgs e)
        {
            ////codigo localizar caminho do software
            //string caminho = Environment.CurrentDirectory.ToString();
            //caminho = caminho.Substring(0, caminho.Length - 9);
            //caminho = caminho + @"UI\";    
            ReportParameter reportParameter = new ReportParameter();

            if (frmImprimirVenda.gerar_relatorio == "normal")
            {
                reportViewer1.Visible = true;
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Usuario", frmLogin.usuariologado.ToString()));
                vendaDAL.RelatorioVenda().Fill(DataSet1, "VENDA");

                this.reportViewer1.RefreshReport();
            }
            if(frmImprimirVenda.gerar_relatorio == "pordata")
            {
                reportViewer1.Visible = true;
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Usuario", frmLogin.usuariologado.ToString()));
                vendaDAL.RelatorioPorData(frmImprimirVenda.data1, frmImprimirVenda.data2).Fill(DataSet1, "VENDA");

                this.reportViewer1.RefreshReport();
            }
       
            //if (Form1.gerar_relatorio == "parametros")
            //{
            //    // -> codigo que deu certo
            //    //reportViewer1.LocalReport.ReportPath = caminho"; 

            //    // -> codigo para localizar caminho do software
            //    //string caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);             

            //    reportViewer1.LocalReport.ReportPath = caminho + "ReportParametrizado.rdlc";                
             

            //    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", clienteBLL.Nome.ToString()));
            //    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Rg", clienteBLL.Rg.ToString()));
            //    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cpf", clienteBLL.Cpf.ToString()));
            //    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Endereco", clienteBLL.Endereco.ToString()));
            //}

            if (frmImprimirVenda.gerar_relatorio == "parametros")
            {            
                reportViewerParametros.Visible = true;
                //======================================================================
                vendaBLL.Idvenda = frmImprimirVenda.codigo_venda;
                vendaDAL.RetornarDados(vendaBLL);

                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IDVENDA", vendaBLL.Idvenda.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("IDCLIENTE", vendaBLL.Idcliente.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DATAVENDA", vendaBLL.Datavenda.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("USUARIO", vendaBLL.Usuario.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PRECOTOTAL", vendaBLL.Precototal.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FORMAPAGAMENTO", vendaBLL.Formapagamento.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("VALORPAGO",vendaBLL.Valorpago.ToString()));
                this.reportViewerParametros.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TROCO",vendaBLL.Troco.ToString()));

                vendaDAL.RelatorioItensVenda(vendaBLL.Idvenda).Fill(DataSetVenda, "ITEMPEDIDO");

                this.reportViewerParametros.RefreshReport();
            }
            //this.reportViewer1.RefreshReport();
            
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
    }
}
