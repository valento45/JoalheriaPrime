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
    public partial class frmVerItensDaVenda : Form
    {
        JOALHERIABLL.ItemPedidoBLL itemBLL = new JOALHERIABLL.ItemPedidoBLL();
        JOALHERIADAL.ItemPedidoDAL itemDAL = new JOALHERIADAL.ItemPedidoDAL();

        public int CodVenda
        {
            get;
            set;
        }


        public frmVerItensDaVenda(int codigo)
        {
            InitializeComponent();
            itemBLL.Idvenda = codigo;
        }

        private void frmVerItensDaVenda_Load(object sender, EventArgs e)
        {
            if(itemBLL.Idvenda > 0)
                dgvConsultarItens.DataSource = itemDAL.ConsultarPorCodigoVenda(itemBLL);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F10:
                    btnSair.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
