using Aux_Joalheria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOALHERIA.UI
{
    public partial class frmGerarFat : frmDefault
    {
        public frmGerarFat()
        {
            InitializeComponent();
        }

        private void frmGerarFat_Load(object sender, EventArgs e)
        {

        }

        private void DefinirFiltro()
        {
            if (rdbPeriodo.Checked)
                pnlPeriodo.Visible = true;
            else
                pnlPeriodo.Visible = false;
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            DefinirFiltro();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarFaturamentoVenda();
        }

        private void GerarFaturamentoVenda()
        {
            string filtroFaturamento = "" , query = "";

            if (rdbDiario.Checked)
            {
                filtroFaturamento = "Diario";
                query = "SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA = '" + DateTime.Now.ToString("dd/MM/yyyy") + "' ORDER BY IDVENDA;";
            }
            else if (rdbMensal.Checked)
            {
                filtroFaturamento = "Mensal";
                query = "SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= '" + $"'01/{DateTime.Now.Month.ToString()}/{DateTime.Now.Year.ToString()}' AND DATAVENDA <= '{DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)}/{DateTime.Now.Month.ToString()}/{DateTime.Now.Year.ToString()}'" + " ORDER BY IDVENDA;";
            }
            else if (rdbAnual.Checked)
            {
                filtroFaturamento = "Anual";
                query = "SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= '" + $"'01/01/{DateTime.Now.Year.ToString()}' AND DATAVENDA <= '31/12/{DateTime.Now.Year.ToString()}'" + "' ORDER BY IDVENDA;";
            }
            else
            {
                filtroFaturamento = "Por periodo";
                if (!(txtDe.Text.Trim().Length == 10 || txtAte.Text.Trim().Length == 10))
                    throw new Exception("Ops! Preencha as datas corretamente! ");
                query = "SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= '" + txtDe.Text + "' AND DATAVENDA <= '" + txtAte.Text + "' ORDER BY IDVENDA;";
            }

            frmFaturamentoVendaSimples faturamentoSimples = new frmFaturamentoVendaSimples(query);
            faturamentoSimples.ShowDialog();
        }
    }
}
