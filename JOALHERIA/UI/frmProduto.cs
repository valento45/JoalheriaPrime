using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOALHERIADAL.Exceptions;

namespace JOALHERIA.UI
{
    public partial class frmProduto : Form
    {
        JOALHERIABLL.ProdutoBLL produtoBLL = new JOALHERIABLL.ProdutoBLL();
        JOALHERIADAL.ProdutoDAL produtoDAL = new JOALHERIADAL.ProdutoDAL();

        JOALHERIABLL.CategoriaBLL categoriaBLL = new JOALHERIABLL.CategoriaBLL();
        JOALHERIADAL.CategoriaDAL categoriaDAL = new JOALHERIADAL.CategoriaDAL();
        string caminho;
        bool alterar = false;

        public frmProduto()
        {
            InitializeComponent();
        }

        public frmProduto(bool pesquisar)
        {
            if (pesquisar)
                tabControl1.SelectedTab = tabPage2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            alterar = false;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEGORIA";

            ConsultarTodosGrid();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmcategoria = new frmCategoria();
            frmcategoria.ShowDialog();

            cmbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEGORIA";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgvConsultarProduto.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir este registro?", "atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtoBLL.Idproduto = Convert.ToInt16(dgvConsultarProduto.SelectedCells[0].Value);
                    produtoDAL.Excluir(produtoBLL);
                    ConsultarTodosGrid();
                }
            }
            else
                MessageBox.Show("Selecione algum registro!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PopularGridTodos()
        {
            dgvConsultarProduto.Rows.Clear();
            foreach (JOALHERIABLL.ProdutoBLL rs in JOALHERIADAL.ProdutoDAL.ListarProdutos().OrderBy(c => c.Descricao))
                dgvConsultarProduto.Rows.Add(rs.Idproduto, rs.Descricao, rs.Idcategoria, rs.Precoimportado, rs.Precovenda, rs.Lucro, rs.Quantidade, rs.Imagem, rs.Observacoes);

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Trim() == "" || cmbCategoria.Text == "" || txtPrecoImportado.Text.Trim() == "" || txtQuantidade.Text.Trim() == "")
                    throw new ExceptionProduct("Preencha todos os campos obrigatórios");
                else
                {
                    cmbCategoria.DisplayMember = "IDCATEGORIA";
                    cmbCategoria.ValueMember = "IDCATEGORIA";

                    produtoBLL.Idcategoria = Convert.ToInt16(cmbCategoria.Text);
                    produtoBLL.Descricao = txtDescricao.Text;
                    produtoBLL.Quantidade = Convert.ToInt16(txtQuantidade.Text);
                    produtoBLL.Precoimportado = Convert.ToDecimal(txtPrecoImportado.Text);
                    produtoBLL.Precovenda = Convert.ToDecimal(txtPrecoVenda.Text);
                    produtoBLL.Lucro = Convert.ToDecimal(txtLucro.Text);
                    produtoBLL.Observacoes = txtObservacoes.Text;
                    produtoBLL.Imagem = caminho?.ToString();

                    if (!alterar)
                        produtoDAL.Cadastrar(produtoBLL);


                    if (alterar)
                        produtoDAL.Alterar(produtoBLL);
                    MessageBox.Show(alterar ? "Produto Atualizado com sucesso!" : "Produto Incluido com sucesso!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarTodosGrid();
                    ResetarCampos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Line 97++, Class frmProduto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ResetarCampos()
        {
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEGORIA";
            cmbCategoria.Text = "";
            txtDescricao.Clear();
            txtLucro.Clear();
            txtPrecoImportado.Clear();
            txtPrecoVenda.Clear();
            txtObservacoes.Clear();
            txtLucro.Clear();
            txtQuantidade.Clear();
            alterar = false;
            label11.Text = "Cadastrar Produto";
            pctImagemProduto.Image = null;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvConsultarProduto.RowCount > 0)
            {
                label11.Text = "Alterar Produto";
                produtoBLL.Idproduto = Convert.ToInt16(dgvConsultarProduto.SelectedCells[0].Value);
                produtoDAL.GetById(produtoBLL);

                cmbCategoria.Text = Convert.ToString(produtoBLL.Idcategoria);
                txtDescricao.Text = produtoBLL.Descricao;
                txtQuantidade.Text = Convert.ToString(produtoBLL.Quantidade);
                txtPrecoImportado.Text = Convert.ToString(produtoBLL.Precoimportado);
                txtPrecoVenda.Text = Convert.ToString(produtoBLL.Precovenda);
                txtLucro.Text = Convert.ToString(produtoBLL.Lucro);
                txtObservacoes.Text = produtoBLL.Observacoes;
                caminho = produtoBLL.Imagem;
                if(caminho.Length > 0)
                    pctImagemProduto.Load(caminho);
                pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
                alterar = true;
                tabControl1.SelectedTab = tabPage1;
            }

            else
                MessageBox.Show("Selecione algum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 0)
            {
                if (rdbCodigo.Checked)
                {
                    int codigo = int.Parse(txtFiltro.Text);
                    dgvConsultarProduto.DataSource = JOALHERIADAL.ProdutoDAL.ListarProdutos().Where(p => p.Idproduto == codigo).ToList();
                }
                if (rdbDescricao.Checked)
                {
                    produtoBLL.Descricao = txtFiltro.Text;
                    dgvConsultarProduto.DataSource = produtoDAL.ConsultarPorDescricao(produtoBLL);
                }
            }
            else
            {
                ConsultarTodosGrid();
            }
        }

        public void ConsultarTodosGrid()
        {
            dgvConsultarProduto.Rows.Clear();
            foreach (JOALHERIABLL.ProdutoBLL produto in JOALHERIADAL.ProdutoDAL.ListarProdutos().OrderBy(c => c.Descricao))
                dgvConsultarProduto.Rows.Add(produto.Idproduto, produto.Descricao, produto.Idcategoria, produto.Quantidade, produto.Precovenda, produto.Observacoes);

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                    e.Handled = true;
            }
        }

        private void btnProcurarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog1.FileName;
                pctImagemProduto.Load(caminho);
                pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private decimal Lucro()
        {
            decimal lucro = 0;
            if (txtPrecoImportado.Text.Trim() == "" || txtPrecoVenda.Text.Trim() == "" || txtQuantidade.Text.Trim() == "")
                throw new ExceptionProduct("Verifique o preenchimento dos campos: \nPreço Bruto\nPreço venda\nQuantidade");
            try
            {
                decimal bruto_unitario = (Convert.ToDecimal(txtPrecoImportado.Text) / Convert.ToDecimal(txtQuantidade.Text));
                lucro = Convert.ToDecimal(txtPrecoVenda.Text) - bruto_unitario;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return lucro;
        }
        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            txtLucro.Text = Lucro().ToString();
        }
    }//
}//
