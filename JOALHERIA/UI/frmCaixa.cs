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
    public partial class frmCaixa : Form
    {
        JOALHERIABLL.LoginBLL loginBLL = new LoginBLL();
        JOALHERIADAL.LoginDAL loginDAL = new LoginDAL();
        
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {           
            label5.Text = frmLogin.usuariologado;
            tslblUsuario.Text = frmLogin.usuariologado;         

            txtValor.Focus();
           
        }

        private void timeHora_Tick(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var l = new frmLogin();
            l.Visible = true;
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //frmUsuario user = new frmUsuario();
            //user.Visible = true;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo para prosseguir !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else            
                try
                {
                    loginBLL.Idlogin = frmLogin.codigo_login;
                    loginBLL.Valor_caixa = Convert.ToDecimal(txtValor.Text);
                    loginDAL.Alterar(loginBLL);

                    frmMenu menu = new frmMenu(LoginBLL.User);
                    this.Close();
                    menu.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível prosseguir: \n\r\n\r\n\r\n" + ex.Message, "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                button1.PerformClick();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
