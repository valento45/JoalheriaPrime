using Aux_Joalheria;
using JOALHERIABLL;
using JOALHERIADAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOALHERIA.UI
{
    public partial class frmFaturamentoVendaSimples : frmDefault
    {
        private string Query;
        public frmFaturamentoVendaSimples(string query)
        {
            InitializeComponent();
            Query = query;
        }

        private void frmFaturamentoVendaSimples_Load(object sender, EventArgs e)
        {
            Gerar();
            this.reportViewerSimples.RefreshReport();
            this.reportViewerSimples.RefreshReport();
        }

        private void Gerar()
        {

            //try
            //{
            //    this.reportViewerSimples.Clear();
            //    this.reportViewerSimples.LocalReport.SetParameters(new ReportParameter("USUARIO", LoginBLL.User.Usuario));

            //    GetFillReport(Query).Fill(DataSetVenda, "VENDA");

            //    this.reportViewerSimples.Refresh();
            //}
            //catch (Exception ex)
            //{
            //    frmErro.Erro_Inesperado(ex, "");
            //}
            
        }
        private SqlDataAdapter GetFillReport(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query));
            da.SelectCommand.Connection = (SqlConnection)Acces.GetConnection();

            da.SelectCommand.Connection.Open();
            return da;
        }

    }
}
