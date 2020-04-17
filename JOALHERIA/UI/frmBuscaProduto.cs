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
    public partial class frmBuscaProduto : Form
    {
        JOALHERIABLL.ProdutoBLL produtoBLL = new JOALHERIABLL.ProdutoBLL();
        JOALHERIADAL.ProdutoDAL produtoDAL = new JOALHERIADAL.ProdutoDAL();

        public int idProduto {get; set;}

        public frmBuscaProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto( new ProdutoBLL());
            frmproduto.ShowDialog();


        }

        private void frmBuscaProduto_Load(object sender, EventArgs e)
        {
            dgvConsultarProduto.DataSource = JOALHERIADAL.ProdutoDAL.ListarProdutos().OrderBy(c => c.Descricao).ToList();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnAdicionar.PerformClick();
                    break;
                case Keys.F7:
                    btnAdicionar.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(dgvConsultarProduto.RowCount > 0)
            {
                idProduto = Convert.ToInt16(dgvConsultarProduto.SelectedCells[1].Value);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
