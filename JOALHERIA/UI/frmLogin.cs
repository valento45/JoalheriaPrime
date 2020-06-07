using JOALHERIABLL;
using JOALHERIADAL;
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
    public partial class frmLogin : Form
    {
        JOALHERIABLL.UsuarioBLL usuarioBLL = new JOALHERIABLL.UsuarioBLL();
        JOALHERIADAL.UsuarioDAL usuarioDAL = new JOALHERIADAL.UsuarioDAL();

        JOALHERIABLL.LoginBLL loginBLL = new JOALHERIABLL.LoginBLL();
        JOALHERIADAL.LoginDAL loginDAL = new JOALHERIADAL.LoginDAL();
        public static JOALHERIABLL.UsuarioBLL user;
        public static int codigo_login { get; set; }
        public static string usuariologado { get; set; }
        public static int idusuariologado { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblDataLogin.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string x = null;
            x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else
            {                
                usuarioBLL.Usuario = txtUsuario.Text;
                usuarioBLL.Senha = Acces.Encrypt(txtUsuario.Text, txtSenha.Text);
                LoginBLL.User = usuarioBLL = usuarioDAL.Logar(usuarioBLL);

                if (usuarioBLL.Idusuario <= 0)
                {
                    MessageBox.Show("Usuario ou senha inválidos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtUsuario.Select(0, txtUsuario.Text.Length);
                }

                else
                {
                    //conseguiu logar                   

                    Inserir_Login();

                    MessageBox.Show("Olá " + LoginBLL.User.Usuario + " , Seja bem Vindo!", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    //carregar
                    UI.frmCaixa caixa = new frmCaixa();
                    caixa.ShowDialog();
                }

            }
        }
               
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void redefinirSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void Inserir_Login()
        {
            loginBLL.Idcaixa = 1;
            loginBLL.Idusuario = LoginBLL.User.Idusuario;
            loginBLL.Usuario = LoginBLL.User.Usuario;
            loginBLL.Data_login = Convert.ToDateTime(lblDataLogin.Text);

            codigo_login = loginDAL.Cadastrar_Login(loginBLL);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnLogar.PerformClick();

            
        }
    }//
}//
