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
    }//
}//
