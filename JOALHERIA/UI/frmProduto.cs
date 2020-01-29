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
                    if(MessageBox.Show("Deseja excluir este registro?","atencao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        produtoBLL.Idproduto = Convert.ToInt16(dgvConsultarProduto.SelectedCells[0].Value);
                        produtoDAL.Excluir(produtoBLL);
                    ConsultarTodosGrid();
                }

                }
                else
                {
                    MessageBox.Show("Selecione algum registro!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Trim() == "" || cmbCategoria.Text == "" || txtLucro.Text.Trim() == "" || txtPrecoImportado.Text == "" || txtQuantidade.Text =="")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                
                if(alterar == false)
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
                    produtoBLL.Imagem = caminho.ToString();                   

                    produtoDAL.Cadastrar(produtoBLL);
                    MessageBox.Show("Produto registrado com sucesso!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ConsultarTodosGrid();
                    ResetarCampos();
                }

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
                    produtoBLL.Imagem = caminho.ToString();

                    produtoDAL.Alterar(produtoBLL);
                    MessageBox.Show("Dados Alterados com sucesso!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarTodosGrid();
                    ResetarCampos();
                }                
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
                alterar = true;

                if (alterar == true)
                {
                    label11.Text = "Alterar Produto";
                    produtoBLL.Idproduto = Convert.ToInt16(dgvConsultarProduto.SelectedCells[0].Value);
                    produtoDAL.RetornarDados(produtoBLL);

                    cmbCategoria.Text = Convert.ToString(produtoBLL.Idcategoria);
                    txtDescricao.Text = produtoBLL.Descricao;
                    txtQuantidade.Text = Convert.ToString(produtoBLL.Quantidade);
                    txtPrecoImportado.Text = Convert.ToString(produtoBLL.Precoimportado);
                    txtPrecoVenda.Text = Convert.ToString(produtoBLL.Precovenda);
                    txtLucro.Text = Convert.ToString(produtoBLL.Lucro);
                    txtObservacoes.Text = produtoBLL.Observacoes;
                    caminho = produtoBLL.Imagem;
                    pctImagemProduto.Load(caminho);
                    pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;

                    tabControl1.SelectedTab = tabPage1;
                }
            }

            else
            {
                MessageBox.Show("Selecione algum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 0)
            {
                if (rdbCodigo.Checked)
                {                   
                        produtoBLL.Idproduto = Convert.ToInt32(txtFiltro.Text);
                        dgvConsultarProduto.DataSource = produtoDAL.ConsultarPorCodigo(produtoBLL);                 
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
            dgvConsultarProduto.DataSource = produtoDAL.ConsultarTodos();
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
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog1.FileName;
                pctImagemProduto.Load(caminho);
                pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }//
}//
