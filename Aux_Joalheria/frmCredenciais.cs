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
    public partial class frmCredenciais : Form
    {
        public frmCredenciais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEnviaEmail enviaemail = new frmEnviaEmail(txtEmail.Text.Trim(), txtSenha.Text.Trim());
            enviaemail.ShowDialog();
        }
    }
}
