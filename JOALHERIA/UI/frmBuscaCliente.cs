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
    public partial class frmBuscaCliente : Form
    {
        JOALHERIABLL.ClienteBLL clienteBLL = new JOALHERIABLL.ClienteBLL();
        JOALHERIADAL.ClienteDAL clienteDAL = new JOALHERIADAL.ClienteDAL();

        public int idCliente { get; set; }

        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {
            //dgvConsultarCliente.DataSource = clienteDAL.ConsultarTodos();

            //dgvConsultarCliente.Focus();
        }

        //metodo para permitir teclas de Atalho HotKeys 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnSelecionar.PerformClick();
                    break;
                    
                case Keys.F7:
                    btnSelecionar.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            if (dgvConsultarCliente.RowCount > 0)
            {
                idCliente = Convert.ToInt16(dgvConsultarCliente.SelectedCells[0].Value);
                this.Close();

            }
            else
            {
                MessageBox.Show("Não há registros para selecionar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }
    }
}
