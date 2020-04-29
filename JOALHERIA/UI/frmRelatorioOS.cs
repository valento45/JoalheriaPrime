using JOALHERIADAL;
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
    public partial class frmRelatorioOS : Form
    {
        OrdemServicoDAL ordem_servicoDAL = new OrdemServicoDAL();
        public frmRelatorioOS()
        {
            InitializeComponent();
        }

        private void frmRelatorioOS_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                ordem_servicoDAL.RelatorioNormal().Fill(DataSetOS, "ORDEMSERVICO");
                this.reportViewer1.RefreshReport();
            }
            
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
                pnlPeriodo.Visible = false;

            if (cmbFiltro.SelectedIndex == 1)
            {
                pnlFiltro.Visible = false;
                pnlPeriodo.Visible = true;
            }
        }
    }
}
