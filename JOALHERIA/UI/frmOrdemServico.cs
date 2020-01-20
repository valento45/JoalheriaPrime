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
    public partial class frmOrdemServico : Form
    {
        JOALHERIABLL.ServicoBLL servicoBLL = new ServicoBLL();
        JOALHERIADAL.ServicoDAL servicoDAL = new ServicoDAL();

        JOALHERIABLL.OrdemServicoBLL ordemservicoBLL = new JOALHERIABLL.OrdemServicoBLL();
        JOALHERIADAL.OrdemServicoDAL ordemservicoDAL = new JOALHERIADAL.OrdemServicoDAL();

        JOALHERIABLL.ItemServicoBLL itemservicoBLL = new ItemServicoBLL();
        JOALHERIADAL.ItemServicoDAL itemservicoDAL = new ItemServicoDAL();

        JOALHERIABLL.ClienteBLL clienteBLL = new JOALHERIABLL.ClienteBLL();
        JOALHERIADAL.ClienteDAL clienteDAL = new JOALHERIADAL.ClienteDAL();

        bool alterar = false;

        int id_cliente = 0;
        decimal total = 0;
        decimal troco = 0;
        decimal valor_pago = 0;
        int idusuario = 0;
        public frmOrdemServico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrdemServico_Load(object sender, EventArgs e)
        {         
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            if(frmLogin.usuariologado != "")
            {
                lblUsuario.Text = frmLogin.usuariologado;
                idusuario = frmLogin.idusuariologado;
            }            

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnSair.PerformClick();
                    break;

                case Keys.F2:
                    if (txtValorPago.Visible == true)
                        txtValorPago.Focus();
                    break;

                case Keys.F5:
                    btnSelecionarCliente.PerformClick();
                    break;

                case Keys.F6:
                    btnSelecionarProduto.PerformClick();
                    break;

                case Keys.F7:
                    btnAdicionar.PerformClick();
                    break;

                case Keys.F8:
                    btnRemover.PerformClick();
                    break;

                case Keys.F9:
                    btnSelecionarFormaPagamento.PerformClick();
                    break;

                case Keys.F10:
                    btnFinalizar.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormaPagamentoDinheiro()
        {
            lblValorPago.Visible = true;
            txtValorPago.Visible = true;

            lblTroco.Visible = true;
            txtTroco.Visible = true;
        }

        private void OcultarFormaPagamentoDinheiro()
        {
            if (cmbForma.SelectedIndex != 0)
            {
                lblValorPago.Visible = false;
                txtValorPago.Visible = false;

                lblTroco.Visible = false;
                txtTroco.Visible = false;
            }
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbForma.SelectedIndex == 0)
            {
                FormaPagamentoDinheiro();
                txtValorPago.Focus();
            }
            else
            {
                OcultarFormaPagamentoDinheiro();
            }
        }


        private void CalcularTotal()
        {
            total = 0;
            for ( int i =0; i < dgvItens.RowCount; i++)
            {
                total += Convert.ToDecimal(dgvItens[4,i].Value);
                txtTotal.Text = total.ToString("n");
            }
            if(dgvItens.RowCount <= 0)
            {
                total = 0;
                txtTotal.Text = total.ToString("n");
            }
                       
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            frmBuscaCliente cliente = new frmBuscaCliente();
            cliente.ShowDialog();

            if(cliente.idCliente != 0)
            {
                clienteBLL.Idcliente = cliente.idCliente;
                clienteDAL.RetornarDados(clienteBLL);

                txtCliente.Text = clienteBLL.Nome.ToString();
                id_cliente = clienteBLL.Idcliente;
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico(1, "selecionar");
            servico.ShowDialog();

            if(servico.codigo_servico != 0)
            {
                servicoBLL.Idservico = servico.codigo_servico;
                servicoDAL.RetornarDados(servicoBLL);

                txtServico.Text = servicoBLL.Descricao.ToString();
                txtPreco.Text = servicoBLL.Valor_servico.ToString();              
            }

            txtQuantidade.Focus();
            txtQuantidade.Select(0, txtQuantidade.Text.Length);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(servicoBLL.Idservico != 0)
            {
                decimal total = Convert.ToInt16(txtQuantidade.Text) * servicoBLL.Valor_servico;

                dgvItens.Rows.Add(servicoBLL.Idservico, servicoBLL.Descricao, txtQuantidade.Value, servicoBLL.Valor_servico.ToString("n"), total.ToString("n"));

               CalcularTotal();

               LimparAposAdicionarIten();
               return;
            }
            else
            {
                MessageBox.Show("Selecione algum produto para adicionar a lista!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparAposAdicionarIten()
        {
            //limpar
            txtValorPago.Clear();
            txtTroco.Text = "";
            servicoBLL.Idservico = 0;
            txtServico.Text = "";
            txtQuantidade.Value = 1;
            txtPreco.Text = "";
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0)
            {
                dgvItens.Rows.Remove(dgvItens.SelectedRows[0]);
                CalcularTotal();
            }
            LimparAposAdicionarIten();
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Enter) && e.KeyChar != 44)
            {
                e.Handled = true;
                MessageBox.Show("Este campo so aceita números !", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtValorPago.Text.Trim() != "")
            {
                CalcularTroco();
            }
        }

        private decimal CalcularTroco()
        {
            if (cmbForma.SelectedIndex == 0 && txtValorPago.Text.Trim()!="")
            {
                try
                {
                    valor_pago = Convert.ToDecimal(txtValorPago.Text);
                    if (valor_pago >= total)
                    {
                        troco = valor_pago - total;
                        txtTroco.Text = troco.ToString();
                    }
                    return troco;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
           

            if(txtTotal.Text.Trim() == "" || dgvItens.RowCount <= 0)
            {
                MessageBox.Show("Insira itens na venda para poder prosseguir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (valor_pago < total)
            {
                MessageBox.Show("Valor pago não pode ser menor que o total !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
           
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if(txtValorPago.Text.Trim() == "")
            {
                txtTroco.Text = "00,00";
            }          
        }
        public bool ValidarTudo()
        {
            if (txtCliente.Text != "" && dgvItens.RowCount > 0 && CalcularTroco() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(ValidarTudo() == true)
            {
                //cadastrando venda e atribuindo idvenda para item
                ordemservicoBLL.Idcliente = clienteBLL.Idcliente;                
                ordemservicoBLL.Dataatual = Convert.ToDateTime(txtData.Text);
                ordemservicoBLL.Dataentrega = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                ordemservicoBLL.Valor_total = total;
                ordemservicoBLL.Forma_pagamento = cmbForma.Text;
                ordemservicoBLL.Valor_pago = valor_pago;
                ordemservicoBLL.Troco = troco;
                ordemservicoBLL.Idusuario = frmLogin.idusuariologado;

                itemservicoBLL.Idordem = ordemservicoDAL.Cadastrar(ordemservicoBLL);

                //cadastrando itens agora
                for(int i =0; i < dgvItens.RowCount; i++)
                {
                    itemservicoBLL.Idservico = Convert.ToInt32(dgvItens[0, i].Value);
                    itemservicoBLL.Valor_servico = Convert.ToDecimal(dgvItens[3, i].Value);
                    itemservicoBLL.Quantidade_pedido = Convert.ToInt16(dgvItens[2,i].Value);

                    itemservicoDAL.Cadastrar(itemservicoBLL);
                }
                MessageBox.Show("Ordem de serviço registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarVenda();
                return;
            }
            if(ValidarTudo() == false)
            {
                MessageBox.Show("Verifique o Preenchimentos de todos os campos ", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        public void ResetarVenda()
        {
            clienteBLL.Idcliente = 0;
            servicoBLL.Idservico = 0;         
            LimparAposAdicionarIten();
            txtCliente.Text = "";
            txtServico.Text = "";
            txtTotal.Text = "00,00";
            total = 0;
            troco = 0;
            valor_pago = 0;

            dgvItens.Columns.Clear();
        }

        private void btnSelecionarFormaPagamento_Click(object sender, EventArgs e)
        {
            cmbForma.Focus();
        }
    }//
}//
