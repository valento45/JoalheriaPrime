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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            txtDate.Enabled = false;
            txtUsuarioLogado.Text = frmLogin.usuariologado;

            
        }
        /* METODO PARA DEFINIR HOTKEYS (TECLAS DE ATALHO ) */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:
                    btnCliente.PerformClick();
                    break;
                case Keys.F6:
                    btnProdutos.PerformClick();
                    break;
                case Keys.F7:
                    btnOrdem.PerformClick();
                    break;
                case Keys.F8:
                    btnVenda.PerformClick();
                    break;
                case Keys.F10:
                    btnSair.PerformClick();
                    break;
                    
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy \n HH:mm:ss");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente Encerrar o sistema?","Atenção!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja encerrar o sistema?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frmcategoria = new frmCategoria();
            frmcategoria.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto();
            frmproduto.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVenda frmvenda = new frmVenda();
            frmvenda.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmvenda = new frmVenda();
            frmvenda.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void cateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdemServico ordem = new frmOrdemServico();
            ordem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrdemServico ordem = new frmOrdemServico();
            ordem.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deslogar  ?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVendas consultarvendas = new frmConsultarVendas();
            consultarvendas.ShowDialog();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda();
            venda.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void backupRestaureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.ShowDialog();
        }

        private void ordensDeServToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarOrdem ordem = new frmConsultarOrdem();
            ordem.ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelVenda RELVENDA = new FrmRelVenda();
            RELVENDA.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime dataVencimento = new DateTime(2022, DateTime.Today.Month, DateTime.Today.Day);
            DateTime dataAtual = DateTime.Today;

            Int32 diferença = dataVencimento.CompareTo(dataAtual);

            MessageBox.Show("Diferença de data antiga para data atual: " + diferença);
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrdemServico oo = new frmOrdemServico();
            oo.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }
    }
}
