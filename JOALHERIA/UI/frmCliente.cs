﻿using System;
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
    public partial class frmCliente : Form
    {
        JOALHERIADAL.ClienteDAL clienteDAL = new JOALHERIADAL.ClienteDAL();
        JOALHERIADAL.FuncoesAuxiliaresDAL funcoesAuxiliares = new FuncoesAuxiliaresDAL();
        bool alterar = false;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            alterar = false;
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
        public void ConsultarGrid()
        {
            dgvConsultarCliente.Rows.Clear();
            foreach (ClienteDAL cliente in ClienteDAL.ListarClientes().OrderBy(c => c.Nome).ToList())
                dgvConsultarCliente.Rows.Add(cliente.Idpessoa, cliente.Nome, cliente.Tipo_documento, cliente.Documento, cliente.Cpf_cnpj, cliente.Data_nascimento, cliente.Email, cliente.Telefone, cliente.Endereco, cliente.Cidade, cliente.Uf, cliente.Complemento, cliente.Tipo_pessoa, cliente.Tipo_cliente, cliente.Data_registro);
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            ConsultarGrid();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dgvConsultarCliente.RowCount > 0)
                {
                    int idcliente = Convert.ToInt16(dgvConsultarCliente.SelectedCells[colIdCliente.Index].Value);
                    ClienteDAL.Delete_Client(idcliente);                    
                    ConsultarGrid();
                }
                else
                    MessageBox.Show("Selecione Algum registro!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvConsultarCliente.RowCount > 0 && alterar)
            {
                clienteDAL.Idpessoa = Convert.ToInt32(dgvConsultarCliente.SelectedCells[colIdCliente.Index].Value);
                clienteDAL = ClienteDAL.GetById(clienteDAL.Idpessoa);
                
                txtNome.Text = clienteDAL.Nome;
                txtRg.Text = clienteDAL.Documento;
                txtCpf.Text = clienteDAL.Cpf_cnpj;
                txtDataNascimento.Text = clienteDAL.Data_nascimento.ToString() == null ? "" : clienteDAL.Data_nascimento.ToString();
                txtEmail.Text = clienteDAL.Email;
                txtTelefone.Text = clienteDAL.Telefone;
                txtEndereco.Text = clienteDAL.Endereco;
                txtCidade.Text = clienteDAL.Cidade;
                cmbUf.Text = clienteDAL.Uf;
                cmbTipo.Text = clienteDAL.Tipo_cliente;

                lblTitulo.Text = "Atualizar Dados Cliente";
                alterar = true;
                tabControl1.SelectedTab = tabPage1;
            }
            else
                MessageBox.Show("Selecione Algum registro para alterar!", "Nenhum registro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            if (alterar == false && ValidarCamposObrigatorios() == true)
            {
                var clienteDAL = new JOALHERIADAL.ClienteDAL();

                clienteDAL.Nome = txtNome.Text;
                clienteDAL.Documento = txtRg.Text;
                clienteDAL.Cpf_cnpj = txtCpf.Text;
                clienteDAL.Data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clienteDAL.Email = txtEmail.Text;
                clienteDAL.Telefone = txtTelefone.Text;
                clienteDAL.Endereco = txtEndereco.Text;
                clienteDAL.Cidade = txtCidade.Text;
                clienteDAL.Uf = cmbUf.Text;
                clienteDAL.Tipo_cliente = cmbTipo.Text;
                ClienteDAL.Insert_Client(clienteDAL);

                MessageBox.Show("Cliente registrado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                ConsultarGrid();
            }
            if (alterar == true && ValidarCamposObrigatorios() == true && clienteDAL.Idpessoa > 0)
            {               
                clienteDAL.Nome = txtNome.Text;
                clienteDAL.Documento = txtRg.Text;
                clienteDAL.Cpf_cnpj = txtCpf.Text;
                clienteDAL.Data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clienteDAL.Email = txtEmail.Text;
                clienteDAL.Telefone = txtTelefone.Text;
                clienteDAL.Endereco = txtEndereco.Text;
                clienteDAL.Cidade = txtCidade.Text;
                clienteDAL.Uf = cmbUf.Text;
                clienteDAL.Tipo_cliente = cmbTipo.Text;
                ClienteDAL.Update_Client(clienteDAL);

                MessageBox.Show("Cliente Atualizado !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetarCampos();
                ConsultarGrid();
            }
        }
        public bool ValidarCamposObrigatorios()
        {
            if (txtNome.Text.Trim() == "" || txtCpf.Text.Trim() == "" || txtDataNascimento.Text.Trim() == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!", "Validar Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                string cpf = txtCpf.Text.Replace(".", "").Replace("-", "");
                if (funcoesAuxiliares.ValidarCpf(cpf))
                    return true;

                else if (MessageBox.Show("Cpf inválido, deseja prosseguir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    return true;

                else
                    return false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetarCampos()
        {
            clienteDAL = new ClienteDAL();
            txtCpf.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtCidade.Clear();
            txtDataNascimento.ResetText();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            cmbUf.Text = "";
            cmbTipo.Text = "";
            lblTitulo.Text = "Cadastrar Cliente";
            alterar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            #region OLD
            //if (txtFiltro.Text.Length > 0)
            //{
            //    if (rdbCodigo.Checked)
            //    {
            //        clienteDAL.Idcliente = Convert.ToInt32(txtFiltro.Text);
            //        dgvConsultarCliente.DataSource = clienteDAL.ConsultarPorCodigo(clienteDAL);

            //    }
            //    if (rdbNome.Checked)
            //    {
            //        clienteBLL.Nome = txtFiltro.Text;
            //        dgvConsultarCliente.DataSource = clienteDAL.ConsultarPorNome(clienteBLL);

            //    }
            //    if (rdbCpf.Checked)
            //    {
            //        clienteBLL.Cpf = txtFiltro.Text;
            //        dgvConsultarCliente.DataSource = clienteDAL.ConsultarPorCpf(clienteBLL);
            //    }
            //}
            //else
            //{
            //    dgvConsultarCliente.DataSource = clienteDAL.ConsultarTodos();
            //}
            #endregion
            string filtro = null;
            if (rdbNome.Checked)
            {
                filtro = txtFiltro.Text;
                dgvConsultarCliente.Rows.Clear();
                foreach (ClienteDAL cliente in ClienteDAL.ListarClientes().Where(c => c.Nome.ToLower().Contains(filtro.ToLower())).ToList())
                    dgvConsultarCliente.Rows.Add(cliente.Idpessoa, cliente.Nome, cliente.Tipo_documento, cliente.Documento, cliente.Cpf_cnpj, cliente.Data_nascimento, cliente.Email, cliente.Telefone, cliente.Endereco, cliente.Cidade, cliente.Uf, cliente.Complemento, cliente.Tipo_pessoa, cliente.Tipo_cliente, cliente.Data_registro);
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbCodigo.Checked)
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                {
                    e.Handled = true;
                    MessageBox.Show("Apenas Números são permitidos para filtrar por Código!", "Validar Filtro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                    
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }//fim 
}//fim
