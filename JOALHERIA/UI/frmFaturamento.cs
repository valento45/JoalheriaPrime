using Aux_Joalheria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient
    ;
using JOALHERIADAL;
using JOALHERIABLL;

namespace JOALHERIA.UI
{
    public partial class frmFaturamento : frmDefault
    {

        public frmFaturamento()
        {
            InitializeComponent();
        }


        private void GerarFaturamento()
        {
            if (ValidaCheckBox())
                if (ValidacaoCampos())
                {
                    try
                    {
                        string query = "";
                        SqlCommand cmd;
                        decimal subtotal = 0;
                        if (chkVendas.Checked)
                        {
                            List<VendaBLL> vendas = new List<VendaBLL>();
                            lblTotalVenda.Visible = dgvVendas.Visible = true;
                            query = "SELECT * FROM JOALHERIA.VENDA";
                            if (cmbFiltrar.SelectedIndex == 0)
                                query += " WHERE DATAVENDA >= '" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00' AND DATAVENDA <= '" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 1)
                                query += " WHERE DATAVENDA >= '01/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " 00:00:00' AND " + "DATAVENDA <= '" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 2)
                                query += " WHERE DATAVENDA >= '01/01/" + DateTime.Now.Year + " 00:00:00' AND DATAVENDA <= '31/12/" + DateTime.Now.Year + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 3)
                                query += $" WHERE DATAVENDA >= '{txtDe.Text} 00:00:00' AND DATAVENDA <= '{txtAte.Text} 23:59:59'";
                            cmd = new SqlCommand(query);

                            foreach (DataRow x in Acces.ExecuteReader(cmd).Tables[0].Rows)
                                vendas.Add(new VendaBLL(x));
                            dgvVendas.Rows.Clear();
                            if (vendas.Count > 0)
                                foreach (VendaBLL venda in vendas.OrderBy(x => x.Datavenda).ToList())
                                    dgvVendas.Rows.Add(venda.Idvenda, venda.Idcliente, venda.Datavenda, venda.Usuario, venda.Precototal, venda.Formapagamento, venda.Valorpago, venda.Troco);
                            decimal total = 0;
                            for (int i = 0; i < dgvVendas.RowCount; i++)
                            {
                                total += (decimal)dgvVendas.Rows[i].Cells[colPrecoTotal.Index].Value;
                            }
                            subtotal = total;
                            lblTotalVenda.Text = "Total: " + total.ToString();
                        }

                        if (chkServicos.Checked)
                        {
                            List<OrdemServicoBLL> vendas = new List<OrdemServicoBLL>();
                            lblTotalOS.Visible = dgvServicos.Visible = true;
                            query = "SELECT * FROM JOALHERIA.ORDEMSERVICO";
                            if (cmbFiltrar.SelectedIndex == 0)
                                query += " WHERE DATAATUAL >= '" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00' AND DATAATUAL <= '" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 1)
                                query += " WHERE DATAATUAL >= '01/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " 00:00:00' AND " + "DATAATUAL <= '" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 2)
                                query += " WHERE DATAATUAL >= '01/01/" + DateTime.Now.Year + " 00:00:00' AND DATAATUAL <= '31/12/" + DateTime.Now.Year + " 23:59:59'";

                            else if (cmbFiltrar.SelectedIndex == 3)
                                query += $" WHERE DATAATUAL >= {txtDe.Text} AND DATAATUAL <= {txtAte.Text}";
                            cmd = new SqlCommand(query);

                            foreach (DataRow x in Acces.ExecuteReader(cmd).Tables[0].Rows)
                                vendas.Add(new OrdemServicoBLL(x));
                            dgvServicos.Rows.Clear();
                            if (vendas.Count > 0)
                                foreach (OrdemServicoBLL venda in vendas.OrderBy(x => x.Dataatual).ToList())
                                    dgvServicos.Rows.Add(venda.Idordem, venda.Idcliente, venda.Dataatual, venda.Dataentrega, venda.Desconto, venda.Valor_total, venda.Forma_pagamento, venda.Valor_pago, venda.Troco);
                            decimal total = 0;
                            for (int i = 0; i < dgvServicos.RowCount; i++)
                            {
                                total += (decimal)dgvServicos.Rows[i].Cells[colValorTotalOS.Index].Value;
                            }
                            subtotal += total;
                            lblTotalOS.Text = "Total: " + total.ToString();
                        }

                        if (chkServicos.Checked && chkVendas.Checked)
                        {
                            lblTotalOSeVenda.Visible = true;
                            lblTotalOSeVenda.Text = "Total OS e Vendas: " + subtotal.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        NetworkLog.Insert(ex, "frmFaturamento.cs");
                        MessageBox.Show("Erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPeriodo.Visible = cmbFiltrar.SelectedIndex == 3;
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            ResetPanels();
            GerarFaturamento();
        }
        private void ResetPanels()
        {
            grpServices.Visible = chkServicos.Checked ? true : false;
            grpVendas.Visible = chkVendas.Checked ? true : false;
            lblTotalOSeVenda.Visible = chkVendas.Checked && chkServicos.Checked ? true : false;
        }

        private bool ValidacaoCampos()
        {
            bool retorno = false;
            if (cmbFiltrar.SelectedIndex != -1)
            {
                retorno = true;
                if (cmbFiltrar.SelectedIndex == 3)
                {
                    if (txtDe.Text.Replace("/", "").Length == 8 && txtAte.Text.Replace("/", "").Length == 8)
                        retorno = true;
                    else
                        retorno = false;
                }
            }
            else
                retorno = false;

            return retorno;
        }

        private bool ValidaCheckBox()
        {
            if (chkServicos.Checked || chkVendas.Checked)
                return true;
            else
                return false;
        }

        private void frmFaturamento_Shown(object sender, EventArgs e)
        {
            ResetPanels();
        }
    }
}
