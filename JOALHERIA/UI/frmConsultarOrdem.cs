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
    public partial class frmConsultarOrdem : Form
    {
        JOALHERIABLL.OrdemServicoBLL ordemservicoBLL = new JOALHERIABLL.OrdemServicoBLL();
        JOALHERIADAL.OrdemServicoDAL ordemservicoDAL = new JOALHERIADAL.OrdemServicoDAL();

        JOALHERIABLL.ItemServicoBLL itemservicoBLL = new JOALHERIABLL.ItemServicoBLL();
        JOALHERIADAL.ItemServicoDAL itemservicoDAL = new JOALHERIADAL.ItemServicoDAL();

        bool alterar = false;
        public static int codigo_ordem { get; set; }

        public frmConsultarOrdem()
        {
            InitializeComponent();
        }

        private void frmConsultarOrdem_Load(object sender, EventArgs e)
        {
            dgvConsultarOrdem.DataSource = ordemservicoDAL.ConsultarTodos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvConsultarOrdem.RowCount > 0)
            {
                alterar = true;
                codigo_ordem = Convert.ToInt16(dgvConsultarOrdem.SelectedCells[0].Value);
                frmOrdemServico ordem = new frmOrdemServico();
                ordem.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmRelOrdem relatorioOrdem = new frmRelOrdem();
            //codigo_ordem = Convert.ToInt32(dgvConsultarOrdem.SelectedCells[0].Value);
            //relatorioOrdem.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerItens_Click(object sender, EventArgs e)
        {
            if(btnVerItens.Text == "Voltar")
            {
                codigo_ordem = 0;
                ControlarVisibilidade();
                return;
            }

            if (btnVerItens.Text == "Ver Itens(F5)" && dgvConsultarOrdem.RowCount > 0)
            {
                codigo_ordem = Convert.ToInt32(dgvConsultarOrdem.SelectedCells[0].Value);
                itemservicoBLL.Idordem = codigo_ordem;

                ControlarVisibilidade();
                btnVerItens.Text = "Voltar";
                dgvConsultarOrdem.DataSource = itemservicoDAL.ConsultarItens(itemservicoBLL);
            }
        }
        public void ControlarVisibilidade()
        {
            if(codigo_ordem > 0)
            {
                pnlBotoes.Visible = false;
            }
            if(codigo_ordem == 0)
            {
                pnlBotoes.Visible = true;
                btnVerItens.Text = "Ver Itens(F5)";
                dgvConsultarOrdem.DataSource = ordemservicoDAL.ConsultarTodos();
            }
        }
    }
}
