using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOALHERIA.Properties;
using JOALHERIABLL;
using JOALHERIADAL;

namespace JOALHERIA.UI
{
    public partial class frmVenda : Form
    {
        JOALHERIABLL.UsuarioBLL usuarioBLL = new JOALHERIABLL.UsuarioBLL();
        JOALHERIADAL.UsuarioDAL usuarioDAL = new JOALHERIADAL.UsuarioDAL();

        JOALHERIABLL.ClienteBLL clienteBLL = new JOALHERIABLL.ClienteBLL();
        JOALHERIADAL.ClienteDAL clienteDAL = new JOALHERIADAL.ClienteDAL();

        JOALHERIABLL.ProdutoBLL produtoBLL = new JOALHERIABLL.ProdutoBLL();
        JOALHERIADAL.ProdutoDAL produtoDAL = new JOALHERIADAL.ProdutoDAL();

        JOALHERIABLL.ItemPedidoBLL itempedidoBLL = new JOALHERIABLL.ItemPedidoBLL();
        JOALHERIADAL.ItemPedidoDAL itempedidoDAL = new JOALHERIADAL.ItemPedidoDAL();

        JOALHERIABLL.VendaBLL vendaBLL = new JOALHERIABLL.VendaBLL();
        JOALHERIADAL.VendaDAL vendaDAL = new JOALHERIADAL.VendaDAL();

        decimal total = 0;
        decimal troco = 0;
        decimal valorpago = 0;

        //bool alterar = false;

        public frmVenda()
        {
            InitializeComponent();
        }

        public void CalcularTroco()
        {
            bool validacao = false;
            valorpago = Convert.ToDecimal(txtValorPago.Text);

            if (txtTotal.Text.Trim() != "" && dgvItens.RowCount > 0)
                validacao = true;

            else
            {
                MessageBox.Show("Insira itens na venda para poder prosseguir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validacao && (valorpago >= total))
            {
                troco = valorpago - total;
                txtTroco.Text = troco.ToString();
            }
            else
                MessageBox.Show("Valor pago não pode ser menor que o total !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //-------------------------------------------criacao metodos de funcionamento do sistema
        //metodo calcular total
        public void CalcularTotal()
        {
            total = 0;
            for (int i = 0; i < dgvItens.RowCount; i++)
                total += Convert.ToDecimal(dgvItens[4, i].Value);

            txtTotal.Text = total.ToString("c");
        }
        //metodo para verificar quantidade disponivvel
        public bool VerificarQuantidadeDisponivel()
        {
            int qtd = 0;
            for (int i = 0; i < dgvItens.RowCount; i++)
                if (produtoBLL.Idproduto.ToString() == dgvItens[0, i].Value.ToString())
                    qtd += Convert.ToInt16(dgvItens[2, i].Value);

            qtd += Convert.ToInt16(txtQuantidade.Value);
            if (qtd > produtoBLL.Quantidade)
                return false;
            else
                return true;
        }



        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            frmBuscaCliente buscacliente = new frmBuscaCliente();
            buscacliente.ShowDialog();

            if (buscacliente.idCliente > 0)
            {
                clienteDAL = ClienteDAL.GetById(buscacliente.idCliente);
                txtCliente.Text = clienteDAL.Nome;
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            frmBuscaProduto frmBuscaProduto = new frmBuscaProduto();
            frmBuscaProduto.ShowDialog();

            if (frmBuscaProduto.idProduto > 0)
                try
                {
                    //produtoBLL.Idproduto = frmBuscaProduto.idProduto;
                    //produtoDAL.GetById(produtoBLL);
                    //txtProduto.Text = produtoBLL.Descricao;
                    //txtPreco.Text = Convert.ToString( produtoBLL.Precovenda);
                    //imgProduto.Load(produtoBLL.Imagem);
                    produtoBLL = ProdutoDAL.GetById(frmBuscaProduto.idProduto);
                    txtProduto.Text = produtoBLL.Descricao;
                    txtPreco.Text = Convert.ToString(produtoBLL.Precovenda);
                    if (produtoBLL.Imagem.Length > 0)
                        imgProduto.Load(produtoBLL.Imagem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu " + "\n\r\n\r\n\r" + ex.Message + "\n\r\n\r\n\r", "Exceção: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            txtQuantidade.Focus();
            txtQuantidade.Select(0, txtQuantidade.Text.Length);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //--------definindo TEclas de atalho HotKEy--------------------------------------------------------------------
        /*
         não pode ser alterado nome da funcao  */
        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            switch (e)
            {
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

                case Keys.F10:
                    btnFinalizar.PerformClick();
                    break;

                case Keys.F1:
                    btnSair.PerformClick();
                    break;

            }
            return base.ProcessCmdKey(ref msg, e);
        }


        private void frmVenda_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Convert.ToString(frmLogin.usuariologado);
            txtCliente.Focus();

            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (produtoBLL.Idproduto != 0)
            {
                if (VerificarQuantidadeDisponivel() == false)
                {
                    MessageBox.Show("Quantidade insuficiente no estoque!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal total = Convert.ToInt16(txtQuantidade.Value) * produtoBLL.Precovenda;

                dgvItens.Rows.Add(produtoBLL.Idproduto, produtoBLL.Descricao, txtQuantidade.Value, produtoBLL.Precovenda.ToString("n"), total.ToString("n"));
                //calcular total
                CalcularTotal();
                // CalcularTroco();

                //limpar
                limpar();

            }
            else
            {
                MessageBox.Show("Selecione algum produto", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpar()
        {
            //limpar
            txtValorPago.Clear();
            txtTroco.Text = "";
            produtoBLL.Idproduto = 0;
            txtProduto.Text = "";
            txtQuantidade.Value = 1;
            txtPreco.Text = "";
            imgProduto.Image = null;
        }
        private void timerHora_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy \t HH:mm:ss");

        }
        //metodo botao remover pedido da lista
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0)
            {
                dgvItens.Rows.Remove(dgvItens.CurrentRow);
                CalcularTotal();
                txtTotal.Text = "";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
                Salvar();

            else
                MessageBox.Show("Verifique o preenchimento dos campos!", "Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Salvar()
        {
            try
            {
                //cadastrando itens da venda
                vendaBLL.Usuario = LoginBLL.User.Usuario != "" ? LoginBLL.User.Usuario : "suporte";
                vendaBLL.Idcliente = clienteDAL.Idpessoa;
                vendaBLL.Precototal = total;
                vendaBLL.Formapagamento = cmbForma.Text;
                if (cmbForma.SelectedIndex == 0)
                {
                    vendaBLL.Valorpago = Convert.ToDecimal(txtValorPago.Text);
                    vendaBLL.Troco = Convert.ToDecimal(txtTroco.Text);
                }
                vendaBLL.Datavenda = Convert.ToDateTime(txtData.Text);
                itempedidoBLL.Idvenda = vendaDAL.Cadastrar(vendaBLL);

                //cadastrando itens da lista de item
                if (itempedidoBLL.Idvenda != -1)
                {
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        itempedidoBLL.Idproduto = Convert.ToInt16(dgvItens[0, i].Value);
                        itempedidoBLL.Quantidade = Convert.ToInt16(dgvItens[2, i].Value);
                        itempedidoBLL.Precounitario = Convert.ToDecimal(dgvItens[3, i].Value);
                        itempedidoDAL.Cadastrar(itempedidoBLL);

                        //baixar estoque ainda dentro do for
                        produtoBLL.Quantidade = itempedidoBLL.Quantidade;
                        produtoBLL.Idproduto = itempedidoBLL.Idproduto;
                        produtoDAL.BaixarEstoque(produtoBLL);
                    }
                    //mensagem de confirmação de dados salvos
                    MessageBox.Show("Venda registrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                    MessageBox.Show("Esta venda pode não ter sido efetuada com sucesso! \n\r\n\r\n\rPor favor, verifique se as informações foram salvas corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                NetworkLog.Insert(ex, "Method Salvar in frmVenda.cs");
                MessageBox.Show("Ops! \n\rOcorreu um erro: " + ex.Message + "\n\r" + (ex.InnerException != null ? ex.InnerException.Message : ""), "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LimparCampos()
        {
            //LIMPANDO OS CAMPOS
            produtoBLL.Idproduto = 0;
            clienteBLL.Idcliente = 0;
            txtProduto.Text = "";
            txtQuantidade.Value = 1;
            txtPreco.Text = "";
            txtTotal.Text = "";
            txtCliente.Text = "";
            dgvItens.Rows.Clear();
            txtValorPago.Clear();
            txtTroco.Text = "00,00";

            OcultarFormaPagamentoDinheiro();
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

        public void FormaPagamentoDinheiro()
        {
            lblValorPago.Visible = true;
            txtValorPago.Visible = true;

            lblTroco.Visible = true;
            txtTroco.Visible = true;
        }

        public void OcultarFormaPagamentoDinheiro()
        {
            if (cmbForma.SelectedIndex != 0)
            {
                lblValorPago.Visible = false;
                txtValorPago.Visible = false;

                lblTroco.Visible = false;
                txtTroco.Visible = false;
            }
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

        public bool VerificarCampos()
        {
            if ((txtCliente.Text.Trim() != "" && dgvItens.RowCount > 0) || (cmbForma.SelectedIndex == 0 && valorpago >= total))
                return true;

            else
                return false;
        }

        private void btnSelecionarFormaPagamento_Click(object sender, EventArgs e)
        {
            cmbForma.Focus();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmbForma.SelectedIndex == 0)
                {
                    txtValorPago.Focus();
                }
            }
        }


    }//
}//
