﻿using JOALHERIABLL;
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
        public UsuarioBLL Usuario;
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(UsuarioBLL usuario)
        {
            InitializeComponent();
            Usuario = usuario;

            PermissaoModulos();
        }
        //
        // Resumo:
        //     Método verifica as permissões que o usuario possui.
        //     Limita os acessos

        private void PermissaoModulos()
        {
            if (Usuario.Permissoes != null)
            {
                //bool alteracao, inclusao, exclusao;
                //inclusao = Usuario.Permissoes.Contains("i") ? true : false;
                //alteracao = Usuario.Permissoes.Contains("p") ? true : false;
                //exclusao = Usuario.Permissoes.Contains("x") ? true : false;

                if (!Modulo.CanAcces(Modulos.Financeiro))
                    btnOrdem.Visible = btnVenda.Visible = financeiroToolStripMenuItem.Visible = false;

                if (!Modulo.CanAcces(Modulos.Estoque))
                    btnProdutos.Visible = estoqueToolStripMenuItem.Visible = false;

                if (!Modulo.CanAcces(Modulos.Cliente))
                    btnCliente.Visible = false;

                if (!Modulo.CanAcces(Modulos.Usuario))
                    usuáriosToolStripMenuItem.Visible = false;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            txtDate.Enabled = false;
            txtUsuarioLogado.Text = LoginBLL.User.Usuario;
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
            if (MessageBox.Show("Deseja realmente Encerrar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("Deseja encerrar o sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            frmProduto frmproduto = new frmProduto(new JOALHERIABLL.ProdutoBLL());
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
            frmProduto produto = new frmProduto(new JOALHERIABLL.ProdutoBLL());
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime dataVencimento = new DateTime(2022, DateTime.Today.Month, DateTime.Today.Day);
            DateTime dataAtual = DateTime.Today;

            Int32 diferença = dataVencimento.CompareTo(dataAtual);

            MessageBox.Show("Diferença de data antiga para data atual: " + diferença);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ordemDeServiçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOrdemServico ordem = new frmOrdemServico();
            ordem.ShowDialog();
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmServico frmservico = new frmServico();

            if (frmservico.Visible)
                frmservico.Focus();
            else
                frmservico.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (frmPesquisaP pesquisarP = new frmPesquisaP())
            {
                pesquisarP.ShowDialog();
            }

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmvenda = new frmVenda();
            frmvenda.ShowDialog();
        }

        private void pesquisasrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVendas consultavenda = new frmConsultarVendas();
            consultavenda.ShowDialog();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrdemServico ordem = new frmOrdemServico();
            ordem.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarOrdem consultaordem = new frmConsultarOrdem();
            consultaordem.ShowDialog();
        }

        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduto frm_produto = new frmProduto(new JOALHERIABLL.ProdutoBLL());
            frm_produto.ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisaP frm_pesquisaP = new frmPesquisaP())
            {
                frm_pesquisaP.ShowDialog();
            }
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmConfigurarU configUsuarios = new frmConfigurarU(new JOALHERIABLL.UsuarioBLL()))
            {
                configUsuarios.ShowDialog();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmRelVenda rel_venda = new FrmRelVenda())
            {
                rel_venda.ShowDialog();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioOS frmRelatorioOS = new frmRelatorioOS();
            frmRelatorioOS.ShowDialog();
        }

        private void contasCorrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmContaCorrente conta = new frmContaCorrente())
            {
                conta.ShowDialog();
            }
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmFaturamento faturamento = new frmFaturamento())
            {
                faturamento.ShowDialog();
            }
        }

        private void faturamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmGerarFat fat = new frmGerarFat())
            {
                fat.ShowDialog();
            }
        }
    }
}
