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

        public frmEnviaEmail(string email, string senha)
        {
            InitializeComponent();
            Email = email;
            Senha = senha;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remetente = txtDe.Text.Trim();
            destinatario = txtPara.Text.Trim();
            mensagem = txtMensagem.Text.Trim();
            MessageBox.Show(EnviarEmail.EnviaMensagemEmail(destinatario, remetente, "Bug ou Erro", mensagem, Email, Senha), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
