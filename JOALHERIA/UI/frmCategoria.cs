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
            alterar = true;

            categoriaBLL.Idcategoria = Convert.ToInt16(dgvConsultarCategoria.SelectedCells[0].Value);
            categoriaDAL.RetornarDados(categoriaBLL);
            txtCategoria.Text = categoriaBLL.Categoria;

            tabControl1.SelectedTab = tabPage1;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//
}
