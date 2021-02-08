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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (BackupDAL.GerarBackup(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Backup gerado com successo em " + saveFileDialog1.FileName, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BackupDAL.RestaurarBackup(openFileDialog1.FileName);                
            }
        }
    }
}
