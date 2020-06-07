using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aux_Joalheria
{
    public partial class frmErro : Form
    {
        string FileName;
        Exception Excep;
        public frmErro(Exception ex)
        {
            InitializeComponent();
            Excep = ex;
            lblErro.Text = ex.Message;
            lblContato.Text = FuncoesAuxiliares.ContatoSuporte;
        }

        private void frmErro_Load(object sender, EventArgs e)
        {
            
        }

        public static void Erro_Inesperado(Exception ex)
        {
            frmErro erro = new frmErro(ex);
            erro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string erroText = "";
                //if (File.Exists(FileName))
                //    erroText = File.ReadAllText(FileName);
                //else if (File.Exists(FileName.Replace(".xml", "_c.xml")))
                //    erroText = File.ReadAllText(FileName.Replace(".xml", "_c.xml"));
                erroText = lblErro.Text;
                Clipboard.SetText(erroText);
                MessageBox.Show("Texto copiado para sua área de transferência", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            frmCredenciais cred = new frmCredenciais(Excep.Message);
            cred.ShowDialog();
            ////cria uma instancia de email
            //MailMessage mail = new MailMessage();
            ////origem e destino
            //mail.From = new MailAddress("iggor1935@hotmail.com");
            //mail.To.Add("iggor1888@hotmail.com");
            ////define conteudo
            //mail.Subject = "Titulo";
            //mail.Body = "Conteudo";

            ////envia de fato
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.Send(mail);

        }
    }
}
