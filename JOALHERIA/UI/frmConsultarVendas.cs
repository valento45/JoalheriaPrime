using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOALHERIABLL;
using JOALHERIADAL;
namespace JOALHERIA.UI
{
    public partial class frmConsultarVendas : Form
    {
        JOALHERIABLL.VendaBLL vendaBLL = new JOALHERIABLL.VendaBLL();
        JOALHERIADAL.VendaDAL vendaDAL = new JOALHERIADAL.VendaDAL();

       public static int codigo_venda { get; set; }
        public frmConsultarVendas()
        {
            InitializeComponent();
        }

        private void frmConsultarVendas_Load(object sender, EventArgs e)
        {
            VerificarFiltros();
            ConsultarGrid();
        }
        public void ConsultarGrid()
        {
            dgvConsultarVendas.DataSource = vendaDAL.ConsultarTodos();
        }
        //metodo para inserir HotKeys (tecla de atalho)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    txtFiltro.Focus();
                    break;
                case Keys.F10:
                    btnSair.PerformClick();
                    break;
                case Keys.F5:
                    btnVerItens.PerformClick();
                    break;
                case Keys.F7:
                    btnRelatorio.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnVerItens_Click(object sender, EventArgs e)
        {
            if (dgvConsultarVendas.RowCount > 0)
            {
                frmVerItensDaVenda veritens = new frmVerItensDaVenda();
                veritens.CodVenda = Convert.ToInt16(dgvConsultarVendas.SelectedCells[0].Value);
                veritens.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //FrmRelVenda relVenda = new FrmRelVenda();
            //relVenda.ShowDialog();
            frmImprimirVenda imprimirVenda = new frmImprimirVenda("report");
            imprimirVenda.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgvConsultarVendas.RowCount > 0){
                codigo_venda = Convert.ToInt32(dgvConsultarVendas.SelectedCells[0].Value);

                frmImprimirVenda imprimirVenda = new frmImprimirVenda("xml");
                imprimirVenda.ShowDialog();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFiltros();
        }
        public void VerificarFiltros()
        {
            if (rdbCodigo.Checked)
            {
                pnlFiltro.Visible = true;
                pnlPeriodo.Visible = false;
            }
            if (rdbPeriodo.Checked)
            {
                pnlFiltro.Visible = false;
                pnlPeriodo.Visible = true;
            }
        }

        private void rdbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFiltros();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string data1 = txtDe.Text.ToString();
            string data2 = txtAte.Text.ToString();

            dgvConsultarVendas.DataSource = vendaDAL.ConsultarPorPeriodo(data1, data2);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length == 0)
            {
                ConsultarGrid();
            }
            else
            {
                vendaBLL.Idvenda = Convert.ToInt32(txtFiltro.Text);
                dgvConsultarVendas.DataSource = vendaDAL.ConsultarPorCodigoVenda(vendaBLL);

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                    e.Handled = true;
            }
        }
    }//
}//
