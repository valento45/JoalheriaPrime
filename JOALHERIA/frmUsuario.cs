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
using System.Data;
using System.Data.SqlClient;

namespace JOALHERIA
{
    public partial class frmUsuario : Form
    {
        Conexao con = new Conexao();
        JOALHERIABLL.UsuarioBLL usuarioBLL = new JOALHERIABLL.UsuarioBLL();
        JOALHERIADAL.UsuarioDAL usuarioDAL = new JOALHERIADAL.UsuarioDAL();
        JOALHERIADAL.FuncoesAuxiliaresDAL funcoesAuxiliares = new FuncoesAuxiliaresDAL();
        bool alterar = false;
       

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {          
            
                if(alterar == false && ValidarCamposObrigatorios() == true)
                {
                    usuarioBLL.Nome = txtNome.Text.ToString();
                    usuarioBLL.Rg = txtRg.Text;
                    usuarioBLL.Cpf = txtCpf.Text;
                    usuarioBLL.Endereco = txtEndereco.Text;
                    usuarioBLL.Telefone = txtTelefone.Text;

                    if(cmbTipo.Text == "Administrador")
                    {
                        usuarioBLL.Tipo = true;
                    }
                    if(cmbTipo.Text == "Normal")
                    {
                        usuarioBLL.Tipo = false;
                    }
                    usuarioBLL.Usuario = txtUsuario.Text;
                    usuarioBLL.Senha = txtSenha.Text;

                    usuarioDAL.Cadastrar(usuarioBLL);
                    MessageBox.Show("Dados gravados com Sucesso!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimparCampos();
                    dgvConsultarUsuario.DataSource = usuarioDAL.ConsultarTodos();
                }

                if(alterar == true && ValidarCamposObrigatorios()==true)
                {
                    usuarioBLL.Nome = txtNome.Text;
                    usuarioBLL.Rg = txtRg.Text;
                    usuarioBLL.Cpf = txtCpf.Text;
                    usuarioBLL.Endereco = txtEndereco.Text;
                    usuarioBLL.Telefone = txtTelefone.Text;

                    if (cmbTipo.Text == "Administrador")
                    {
                        usuarioBLL.Tipo = true;
                    }
                    if (cmbTipo.Text == "Normal")
                    {
                        usuarioBLL.Tipo = false;
                    }
                    usuarioBLL.Usuario = txtUsuario.Text;
                    usuarioBLL.Senha = txtSenha.Text;

                    usuarioDAL.Atualizar(usuarioBLL);
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetarCampos();
                PopulaGrid();
                }               
        }
        public void PopulaGrid()
        {
            dgvConsultarUsuario.Rows.Add(usuarioDAL.ListarTodosUsuarios().ToArray());
            //foreach (var al in usuarioDAL.ListarTodosUsuarios())
            //{
            //    dgvConsultarUsuario.Rows.Add(al.Idusuario, al.Nome, al.Rg, al.Cpf, al.Endereco, al.Telefone, al.Tipo, al.Usuario, al.Senha);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaGrid();           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {            
            if(MessageBox.Show("Deseja realmente Excluir este Registro?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(dgvConsultarUsuario.RowCount > 0)
                {
                    try
                    {
                        usuarioBLL.Idusuario = Convert.ToInt16(dgvConsultarUsuario.SelectedCells[0].Value);
                        usuarioDAL.Excluir(usuarioBLL);

                        dgvConsultarUsuario.DataSource = usuarioDAL.ConsultarTodos();
                        return;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Impossível excluir o registro selecionado. \n " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione algum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {       
            try
            {
                usuarioBLL.Idusuario = Convert.ToInt16(dgvConsultarUsuario.SelectedCells[0].Value);
                usuarioDAL.RetornarDados(usuarioBLL);

                txtNome.Text = usuarioBLL.Nome;
                txtRg.Text = usuarioBLL.Rg;
                txtCpf.Text = usuarioBLL.Cpf;
                txtTelefone.Text = usuarioBLL.Telefone;
                cmbTipo.Text = Convert.ToString(usuarioBLL.Tipo);
                txtEndereco.Text = usuarioBLL.Endereco;
                txtUsuario.Text = usuarioBLL.Usuario;
                txtSenha.Text = usuarioBLL.Senha;

                alterar = true;

                if (alterar == true)
                {
                    label11.Text = "Alterar Usuário";
                }

                tabControl1.SelectedTab = tabPage1;                   
                            
            }
            catch
            {
                MessageBox.Show("Selecione algum registro!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                alterar = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetarCampos();         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public bool ValidarCamposObrigatorios()
        {
            if (txtNome.Text == "" || txtRg.Text == "" || txtCpf.Text == "" || txtEndereco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "" || cmbTipo.Text == "")
            {
                MessageBox.Show("preencha todos os campos Obrigatórios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                string cpf = txtCpf.Text.Replace(".", "").Replace("-", "");
                if (funcoesAuxiliares.ValidarCpf(cpf))
                    return true;

                else if (MessageBox.Show("Cpf inválido ! \nDeseja prosseguir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    return true;

                else
                    return false;
            }
        }
        public void LimparCampos()
        {
            txtNome.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            cmbTipo.Text = "";
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        public void ResetarCampos()
        {
            LimparCampos();

            alterar = false;
            if (alterar == false)
            {
                label11.Text = "Cadastrar Usuário";
            }
        }
    }//
}//
