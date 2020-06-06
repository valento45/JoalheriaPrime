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
    public partial class frmContaCorrente : Form
    {
        bool alterar = false;
        ContaCorrente conta;
        public frmContaCorrente()
        {
            InitializeComponent();
        }

        private void frmContaCorrente_Load(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        private bool ValidaCampos()
        {
            if (cmbBanco.Text.Length > 0)
                return true;
            else
                return false;
        }

        private void PopulaGrid()
        {
            dgvContasCorrente.Rows.Clear();
            foreach (ContaCorrente x in ContaCorrente.GetAllContas().OrderBy(y => y.Banco).ToList())
                dgvContasCorrente.Rows.Add(x.Idconta, x.Banco);
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            alterar = false;
            tabControl1.SelectedTab = tabPage2;
        }

        private void LimparCampos()
        {
            cmbBanco.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            txtAgencia.Clear();
            txtFavorecido.Clear();
            txtNmrConta.Clear();
            txtOperacao.Clear();
            alterar = false;
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    if (alterar)
                    {
                        conta.Banco = cmbBanco.Text;
                        conta.Tipo_conta = cmbTipo.Text;
                        conta.Agencia = txtAgencia.Text;
                        conta.NrConta = txtNmrConta.Text;
                        conta.Operacao = txtOperacao.Text;
                        conta.Favorecido = txtFavorecido.Text;
                        ContaCorrente.UpdateConta(conta);
                        MessageBox.Show("Conta atualizada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!alterar)
                    {
                        conta = new ContaCorrente();
                        conta.Banco = cmbBanco.Text;
                        conta.Tipo_conta = cmbTipo.Text;
                        conta.Agencia = txtAgencia.Text;
                        conta.NrConta = txtNmrConta.Text;
                        conta.Operacao = txtOperacao.Text;
                        conta.Favorecido = txtFavorecido.Text;
                        ContaCorrente.InsertConta(conta);
                        MessageBox.Show("Conta inserida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    NetworkLog.Insert(ex, "frmContaCorrente.cs");
                    MessageBox.Show("Erro ao salvar!\n\r\n\r\n\r" + ex.Message + "\n\r\n\r\n\r", "Ops!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conta = null;
                    LimparCampos();
                    PopulaGrid();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgvContasCorrente.RowCount > 0)
            {
                conta = ContaCorrente.GetById((int)dgvContasCorrente.SelectedCells[colId.Index].Value);
                cmbBanco.SelectedText = conta.Banco;
                cmbTipo.SelectedText = conta.Tipo_conta;
                txtAgencia.Text = conta.Agencia;
                txtNmrConta.Text = conta.NrConta;
                txtOperacao.Text = conta.Operacao;
                txtFavorecido.Text = conta.Favorecido;
                tabControl1.SelectedTab = tabPage2;
                alterar = true;
            }
        }
    }
}
