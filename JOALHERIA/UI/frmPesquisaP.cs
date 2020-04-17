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

namespace JOALHERIA
{
    public partial class frmPesquisaP : Form
    {
        public frmPesquisaP()
        {
            InitializeComponent();
        }

        private void PopularGrid()
        {
            dgvProdutos.Rows.Clear();
            foreach (var x in ProdutoDAL.ListarProdutos().OrderBy(x => x.Descricao).ToList())
                dgvProdutos.Rows.Add(x.Idproduto, x.Descricao, x.Idcategoria, x.Quantidade, x.Precoimportado, x.Precovenda, x.Lucro, /*x.Imagem,*/ x.Observacoes);
        }

        #region METODO OCULTA PNL NAO ENCONTROU REGISTRO
        private void OcultaPnlNaoEncontroRegistro()
        {
            if (dgvProdutos.RowCount > 0)
                pnlNaoEncontrouRegistro.Visible = false;

            else
                pnlNaoEncontrouRegistro.Visible = true;
        }
        #endregion
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length == 0)
                PopularGrid();
            else
                Popular_Grid_Filtro_Descricao(txtFiltro.Text.Trim().ToString());

            OcultaPnlNaoEncontroRegistro();
        }
        private void Popular_Grid_Filtro_Descricao(string pesquisar)
        {
            dgvProdutos.Rows.Clear();
            foreach (var x in ProdutoDAL.ListarPorDescricao(pesquisar))
                dgvProdutos.Rows.Add(x.Idproduto, x.Descricao, x.Idcategoria, x.Quantidade, x.Precoimportado, x.Precovenda, x.Lucro, /*x.Imagem,*/ x.Observacoes);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            using (UI.frmProduto frm_produto = new UI.frmProduto(new ProdutoBLL()))
            {
                if (frm_produto.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                ProdutoBLL produto = ProdutoDAL.GetById(Convert.ToInt32(dgvProdutos.SelectedCells[colCodigo.Index].Value));
                using (UI.frmProduto frm_produto = new UI.frmProduto(produto))
                {
                    if (frm_produto.ShowDialog() == DialogResult.OK)
                    {
                        PopularGrid();
                    }
                }
            }
            else
                MessageBox.Show("Nenhum registro selecionado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (GridIsItem())
            {
                int id = Convert.ToInt32(dgvProdutos.SelectedCells[colCodigo.Index].Value);
                string descricao = dgvProdutos.SelectedCells[colDescricao.Index].Value.ToString();

                if (MessageBox.Show($"Deseja excluir o produto {descricao} ?", "ID Produto: " + id, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProdutoDAL.ExcluirPorCodigo(id);
                    PopularGrid();
                }
            }
            else
                MessageBox.Show("Nenhum registro selecionado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool GridIsItem()
        {
            if (dgvProdutos.RowCount > 0)
                return true;
            else
                return false;
        }
    }
}
