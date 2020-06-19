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
            if (chkPeriodo.Checked)
                pnlPeriodo.Visible = true;
            else
                pnlPeriodo.Visible = false;
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            DefinirFiltro();
        }
    }
}
