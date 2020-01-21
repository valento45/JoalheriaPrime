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
    public partial class frmCliente : Form
    {
        JOALHERIABLL.ClienteBLL clienteBLL = new JOALHERIABLL.ClienteBLL();
        JOALHERIADAL.ClienteDAL clienteDAL = new JOALHERIADAL.ClienteDAL();

        bool alterar = false;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            alterar = false;
            this.Close();          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
        public void ConsultarGrid()
        {
            dgvConsultarCliente.DataSource = clienteDAL.ConsultarTodos();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            ConsultarGrid();

            txtNome.Focus();
               
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvConsultarCliente.RowCount > 0)
                {
                    clienteBLL.Idcliente = Convert.ToInt16(dgvConsultarCliente.SelectedCells[0].Value);
                    clienteDAL.Excluir(clienteBLL);

                    ConsultarGrid();

                }
                else
                {
                    MessageBox.Show("Selecione Algum registro!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(dgvConsultarCliente.RowCount > 0)
            {
                clienteBLL.Idcliente = Convert.ToInt32(dgvConsultarCliente.SelectedCells[0].Value);
                clienteDAL.RetornarDados(clienteBLL);

                txtNome.Text = clienteBLL.Nome;
                txtRg.Text = clienteBLL.Rg;
                txtCpf.Text = clienteBLL.Cpf;
                txtDataNascimento.Text = clienteBLL.Data_nascimento.ToString();
                txtEmail.Text = clienteBLL.Email;
                txtTelefone.Text = clienteBLL.Telefone;
                txtEndereco.Text = clienteBLL.Endereco;
                txtCidade.Text = clienteBLL.Cidade;
                cmbUf.Text = clienteBLL.Uf;
                cmbTipo.Text = clienteBLL.Tipo_cliente;

                lblTitulo.Text = "Atualizar Dados Cliente";
                alterar = true;
                tabControl1.SelectedTab = tabPage1;                             
            }
            else
            {
                MessageBox.Show("Selecione Algum registro ", "Tabela Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {       
            if( alterar == false && ValidarCamposObrigatorios() == true )
            {
                clienteBLL.Nome = txtNome.Text;
                clienteBLL.Rg = txtRg.Text;
                clienteBLL.Cpf = txtCpf.Text;
                clienteBLL.Data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clienteBLL.Email = txtEmail.Text;
                clienteBLL.Telefone = txtTelefone.Text;
                clienteBLL.Endereco = txtEndereco.Text;
                clienteBLL.Cidade = txtCidade.Text;
                clienteBLL.Uf = cmbUf.Text;
                clienteBLL.Tipo_cliente = cmbTipo.Text;

                clienteDAL.Cadastrar(clienteBLL);
                MessageBox.Show("Cliente registrado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                ConsultarGrid();

                return;              

            }

            if(ValidarCamposObrigatorios() == true && alterar == true)
            {
                clienteBLL.Nome = txtNome.Text;
                clienteBLL.Rg = txtRg.Text;
                clienteBLL.Cpf = txtCpf.Text;
                clienteBLL.Data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clienteBLL.Email = txtEmail.Text;
                clienteBLL.Telefone = txtTelefone.Text;
                clienteBLL.Endereco = txtEndereco.Text;
                clienteBLL.Cidade = txtCidade.Text;
                clienteBLL.Uf = cmbUf.Text;
                clienteBLL.Tipo_cliente = cmbTipo.Text;

                clienteDAL.Alterar(clienteBLL);
                MessageBox.Show("Cliente Atualizado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                ConsultarGrid();

                return;
            }

            if(ValidarCamposObrigatorios() == false)
            {
                MessageBox.Show("Preencha os campos obrigatórios!", "Validar Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool ValidarCamposObrigatorios()
        {
            if(txtNome.Text.Trim() == "" || txtCpf.Text.Trim() == "" || txtDataNascimento.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetarCampos()
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtCidade.Clear();
            txtDataNascimento.ResetText();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            cmbUf.Text = "";
            cmbTipo.Text = "";
            lblTitulo.Text = "Cadastrar Cliente";
            alterar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
           // ResetarCampos();
        }
    }//fim 
}//fim
