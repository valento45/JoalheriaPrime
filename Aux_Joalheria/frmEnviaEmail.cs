using EnviaEmail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aux_Joalheria
{
    public partial class frmEnviaEmail : Form
    {
        protected string Email;
        protected string Senha;
        string remetente;
        string destinatario;
        string mensagem;
        string Erro;

        public frmEnviaEmail() { }

        public frmEnviaEmail(string email, string senha, string erro)
        {
            InitializeComponent();
            Email = email;
            Senha = senha;
            Erro = erro;
            txtMensagem.Text = Erro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remetente = txtDe.Text.Trim();
            destinatario = txtPara.Text.Trim();
            mensagem = txtMensagem.Text.Trim();
            string[] vetor = Erro.Split(',');

            if (MessageBox.Show("Deseja enviar email com LOG em anexo?", "Opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show(EnviarEmail.EnviaMensagemEmailComAnexo(destinatario, remetente, "Bug ou Erro", mensagem, Email, Senha, vetor[1]), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show(EnviarEmail.EnviaMensagemEmail(destinatario, remetente, "Bug ou Erro", mensagem, Email, Senha), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmEnviaEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
