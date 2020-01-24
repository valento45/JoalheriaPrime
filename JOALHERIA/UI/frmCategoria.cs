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
    public partial class frmCategoria : Form
    {
        JOALHERIABLL.CategoriaBLL categoriaBLL = new CategoriaBLL();
        JOALHERIADAL.CategoriaDAL categoriaDAL = new JOALHERIADAL.CategoriaDAL();
        
        bool alterar = false;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            alterar = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtCategoria.Text.Trim() == ""                       )
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if(alterar == false)
                {
                    categoriaBLL.Categoria = txtCategoria.Text;
                    categoriaDAL.Cadastrar(categoriaBLL);
                    MessageBox.Show("Registrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvConsultarCategoria.DataSource = categoriaDAL.ConsultarTodos();
                }

                else
                {
                    categoriaBLL.Categoria = txtCategoria.Text;
                    categoriaDAL.Alterar(categoriaBLL);
                    MessageBox.Show("Dados alterados com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alterar = false;
                    dgvConsultarCategoria.DataSource = categoriaDAL.ConsultarTodos();
                }
                txtCategoria.Clear();


            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            dgvConsultarCategoria.DataSource = categoriaDAL.ConsultarTodos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja alterar registro?","Atencao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(dgvConsultarCategoria.RowCount > 0)
                {
                    categoriaBLL.Idcategoria = Convert.ToInt16(dgvConsultarCategoria.SelectedCells[0].Value);
                    categoriaDAL.Excluir(categoriaBLL);
                 
                    dgvConsultarCategoria.DataSource = categoriaDAL.ConsultarTodos();

                }
                else
                {
                    MessageBox.Show("Selecione algum registro!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvConsultarCategoria.RowCount > 0)
            {

                categoriaBLL.Idcategoria = Convert.ToInt16(dgvConsultarCategoria.SelectedCells[0].Value);
                categoriaDAL.RetornarDados(categoriaBLL);
                txtCategoria.Text = categoriaBLL.Categoria;
                alterar = true;
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                MessageBox.Show("Selecione algum registro para alterar ", "Alterar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if(txtFiltro.Text.Length > 0)
            {
                if (rdbCodigo.Checked)
                {
                    if (!char.IsNumber(Convert.ToChar(txtFiltro.Text)))
                    {
                        MessageBox.Show("Digite apenas numero para consultar por Código!", "Consultar por código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFiltro.Clear();
                        
                        return;
                    }
                    categoriaBLL.Idcategoria = Convert.ToInt32(txtFiltro.Text);
                    categoriaDAL.ConsultarPorCodigo(categoriaBLL);
                }

                if (rdbCategoria.Checked)
                {
                    categoriaBLL.Categoria = txtFiltro.Text;
                    categoriaDAL.ConsultarPorCategoria(categoriaBLL);
                }
            }
            else
            {
                ConsultarTodosGrid();
            }
            
        }
        private void ConsultarTodosGrid()
        {
            dgvConsultarCategoria.DataSource = categoriaDAL.ConsultarTodos();
        }
    }//
}
