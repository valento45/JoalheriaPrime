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
using JOALHERIA;
using JOALHERIABLL;
using JOALHERIADAL;
namespace JOALHERIA.UI
{
    public partial class frmProduto : Form
    {
        ProdutoBLL produtoBLL;
        ProdutoDAL produtoDAL = new ProdutoDAL();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();

        string caminho;
        bool alterar = false;

        //public frmProduto()
        //{
        //    InitializeComponent();
        //}

        public frmProduto(ProdutoBLL produto)
        {
            InitializeComponent();
            produtoBLL = produto;

            alterar = produtoBLL.Idproduto > 0 ? true : false;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEGORIA";

            if (alterar)
                Prepara_Edicao();
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

        private void Prepara_Edicao()
        {
            try
            {
                label11.Text = "Alterar Produto";

                cmbCategoria.Text = Convert.ToString(produtoBLL.Idcategoria);
                txtDescricao.Text = produtoBLL.Descricao;
                txtQuantidade.Text = Convert.ToString(produtoBLL.Quantidade);
                txtPrecoImportado.Text = Convert.ToString(produtoBLL.Precoimportado);
                txtPrecoVenda.Text = Convert.ToString(produtoBLL.Precovenda);
                txtLucro.Text = Convert.ToString(produtoBLL.Lucro);
                txtObservacoes.Text = produtoBLL.Observacoes;
                caminho = produtoBLL.Imagem;
                if (caminho.Length > 0)
                {
                    pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
                    pctImagemProduto.Load(caminho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o registro: " + ex.Message, "1) Line 189, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private decimal Lucro()
        {
            decimal lucro_unitario = 0;
            try
            {
                if (txtPrecoImportado.Text.Trim() == "" || txtQuantidade.Text.Trim() == "")
                    throw new ExceptionProduct("Verifique o preenchimento dos campos: \nPreço Bruto\nPreço venda\nQuantidade");

                decimal bruto_total = Convert.ToDecimal(txtPrecoImportado.Text);
                int quantidade = Convert.ToInt16(txtQuantidade.Text);
                decimal bruto_unitario = bruto_total / quantidade;
                decimal preco_venda;
                decimal.TryParse(txtPrecoVenda.Text, out preco_venda);

                lucro_unitario = preco_venda - bruto_unitario;

            }
            catch (ExceptionProduct ex)
            {
                MessageBox.Show(ex.Message, "Line 170, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Line 170, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return lucro_unitario;
        }

        private void Salvar()
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

                if (alterar)
                    produtoDAL.Alterar(produtoBLL);

                else
                {
                    produtoDAL.Cadastrar(produtoBLL);
                    //ResetarCampos();
                }

                MessageBox.Show(alterar ? "Produto Atualizado com sucesso!" : "Produto Incluido com sucesso!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Line 145, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProcurarImagem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog1.FileName;
                pctImagemProduto.Load(caminho);
                pctImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLucro.Text = Lucro().ToString("F2");
            }
            catch (ExceptionProduct ex)
            {
                MessageBox.Show(ex.Message, "Line 170, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Line 170, frmProduto.cs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCategoria_Click_1(object sender, EventArgs e)
        {
            frmCategoria frmcategoria = new frmCategoria();
            frmcategoria.ShowDialog();

            cmbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEGORIA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && ((Keys)e.KeyChar != Keys.Delete && (Keys)e.KeyChar != Keys.Back && (Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita valores númericos !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                txtLucro.Text = Lucro().ToString("F2");
        }
    }//
}//

