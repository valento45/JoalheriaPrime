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
    public partial class frmServico : Form
    {
        JOALHERIABLL.ServicoBLL servicoBLL = new JOALHERIABLL.ServicoBLL();
        JOALHERIADAL.ServicoDAL servicoDAL = new JOALHERIADAL.ServicoDAL();
        public int codigo_servico { get; set; }

        bool alterar = false;

        public frmServico()
        {
            InitializeComponent();
        }


        public frmServico(int aba, string modo)
        {
            InitializeComponent();

            tabControl1.SelectedIndex = aba;

            if(modo == "selecionar")
            {
                btnSelecionar.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(btnSelecionar.Visible == true)
            {
                switch (keyData)
                {
                    case Keys.Enter:
                        btnSelecionar.PerformClick();
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void ResetarCampos()
        {
            txtValor.Clear();
            txtDescricao.Clear();
            alterar = false;
            //txtDescricao.Focus();
            lblAcao.Text = "Cadastrar";
        }

        public void PrepararAlteracao()
        {
            alterar = true;
            lblAcao.Text = "Alterar";            
        }

        public bool ValidarCampos()
        {
            if(txtDescricao.Text.Trim() != "" && txtValor.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas valores númericos!","Validação de Campos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos()  && alterar == false)
            {
                servicoBLL.Descricao = txtDescricao.Text.ToString();
                servicoBLL.Valor_servico = Convert.ToDecimal(txtValor.Text);

                servicoDAL.Cadastrar(servicoBLL);
                MessageBox.Show("Serviço cadastrado no sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                PopularGrid();
                return;
            }
            if(ValidarCampos() && alterar == true)
            {
                servicoBLL.Descricao = txtDescricao.Text.ToString();
                servicoBLL.Valor_servico = Convert.ToDecimal(txtValor.Text);
                servicoDAL.Alterar(servicoBLL);

                MessageBox.Show("Serviço Atualizado no sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                PopularGrid();

                return;
            }
            if(!ValidarCampos())
            {
                MessageBox.Show("Preencha todos os campos!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PopularGrid()
        {
            dgvConsultarServico.DataSource = servicoDAL.ConsultarTodosList();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ResetarCampos();
            PopularGrid();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgvConsultarServico.RowCount > 0)
            {
                codigo_servico = Convert.ToInt32(dgvConsultarServico.SelectedCells[0].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione Algum registro para prosseguir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbtnAlterar_Click(object sender, EventArgs e)
        {
            if(dgvConsultarServico.RowCount > 0)
            {
                servicoBLL.Idservico = Convert.ToInt32(dgvConsultarServico.SelectedCells[0].Value);
                servicoDAL.RetornarDados(servicoBLL);

                txtDescricao.Text = servicoBLL.Descricao.ToString();
                txtValor.Text = servicoBLL.Valor_servico.ToString();

                PrepararAlteracao();

                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                MessageBox.Show("Selecione algum registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbtnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvConsultarServico.RowCount > 0)
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado ?", "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    servicoBLL.Idservico = Convert.ToInt32(dgvConsultarServico.SelectedCells[0].Value);
                    servicoDAL.Excluir(servicoBLL);
                    PopularGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
