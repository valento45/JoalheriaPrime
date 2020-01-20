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
    public partial class frmImprimirVenda : Form
    {
        JOALHERIABLL.VendaBLL vendaBLL = new JOALHERIABLL.VendaBLL();
        JOALHERIADAL.VendaDAL vendaDAL = new JOALHERIADAL.VendaDAL();
        public static string data1 { get; set; }
        public static string data2 { get; set; }
        public static string gerar_relatorio { get; set; }
        public static int codigo_venda { get; set; }

        public frmImprimirVenda()
        {
            InitializeComponent();
        }

        public frmImprimirVenda(string tipoImpressao)
        {
            InitializeComponent();

            if(tipoImpressao == "xml")
            {
                pnlReport.Visible = false;
                pnlXml.Visible = true;
                pnlXml.Focus();
            }

            if (tipoImpressao == "report")
            {
                pnlReport.Visible = true;
                pnlReport.Focus();
            }
        }

        private void frmImprimir_Load(object sender, EventArgs e)
        {

        }

        public void VerificarOpcoes()
        {
            if (rdbPorData.Checked)
            {
                lblDe.Visible = true;
                lblAte.Visible = true;
                mtxtData1.Visible = true;
                mtxtData2.Visible = true;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
            }

            if (rdbPorTipo.Checked)
            {
                lblDe.Visible = false;
                lblAte.Visible = false;
                mtxtData1.Visible = false;
                mtxtData2.Visible = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
                txtCodigo.Clear();
                mtxtData1.Clear();
                mtxtData2.Clear();
            }

            if (rdbParametros.Checked)
            {
                lblCodigo.Visible = true;
                txtCodigo.Visible = true;

                lblDe.Visible = false;
                lblAte.Visible = false;
                mtxtData1.Visible = false;
                mtxtData2.Visible = false;
                mtxtData1.Clear();
                mtxtData2.Clear();
            }

            if (rdbNormal.Checked)
            {
                lblDe.Visible = false;
                lblAte.Visible = false;
                mtxtData1.Visible = false;
                mtxtData2.Visible = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
                txtCodigo.Clear();
                mtxtData1.Clear();
                mtxtData2.Clear();
            }
        }

        private void rdbPorData_CheckedChanged(object sender, EventArgs e)
        {
            VerificarOpcoes();
        }

        private void rdbPorTipo_CheckedChanged(object sender, EventArgs e)
        {
            VerificarOpcoes();
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            VerificarOpcoes();
        }

        private void rdbParametros_CheckedChanged(object sender, EventArgs e)
        {
            VerificarOpcoes();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            gerar_relatorio = "";
            codigo_venda = 0;

            if (rdbPorData.Checked)
            {
                try
                {
                    data1 = mtxtData1.Text.ToString();
                    data2 = mtxtData2.Text.ToString();

                    gerar_relatorio = "pordata";

                    FrmRelVenda frmRelatorio = new FrmRelVenda();
                    frmRelatorio.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Digite a data corretamente !", "Cacth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbPorTipo.Checked)
            {
                gerar_relatorio = "portipo";
            }

            if (rdbNormal.Checked)
            {
                gerar_relatorio = "normal";               

                FrmRelVenda frmRelatorio = new FrmRelVenda();                
                frmRelatorio.ShowDialog();
                
            }

            if (rdbParametros.Checked)
            {
                try
                {
                    gerar_relatorio = "parametros";
                    codigo_venda = Convert.ToInt32(txtCodigo.Text.ToString());

                    FrmRelVenda frmRelatorio = new FrmRelVenda();
                    frmRelatorio.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Digite um id correto !", "Cacth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarXml_Click(object sender, EventArgs e)
        {
            string caminho;
            if (rdbTodos.Checked)
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    caminho = saveFileDialog1.FileName;
                    vendaDAL.ExportarXml(caminho);

                    MessageBox.Show("XML Gerado em: " + caminho, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            if (rdbSelecionado.Checked)
            {
                vendaBLL.Idvenda = frmConsultarVendas.codigo_venda;
                vendaDAL.RetornarDados(vendaBLL);

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    caminho = saveFileDialog1.FileName;
                    vendaDAL.Gerar_Xml_Selecionado(vendaBLL, caminho);

                    MessageBox.Show("XML Gerado em: " + caminho, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
