using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace JOALHERIADAL
{
    public class ItemServicoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(JOALHERIABLL.ItemServicoBLL itemservicoBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.ITEM_ORDEMSERVICO (IDORDEM, IDSERVICO, VALOR_SERVICO, QUANTIDADE_PEDIDO) VALUES (@IDORDEM, @IDSERVICO, @VALOR_SERVICO, @QUANTIDADE_PEDIDO)", con.Conectar());
                cmd.Parameters.AddWithValue(@"IDORDEM", itemservicoBLL.Idordem);
                cmd.Parameters.AddWithValue(@"IDSERVICO", itemservicoBLL.Idservico);
                cmd.Parameters.AddWithValue(@"VALOR_SERVICO", itemservicoBLL.Valor_servico);
                cmd.Parameters.AddWithValue(@"QUANTIDADE_PEDIDO", itemservicoBLL.Quantidade_pedido);

                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch
            {
                con.Desconectar();
            }
        }

        public void Alterar(JOALHERIABLL.ItemServicoBLL itemservicoBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.ITEM_ORDEMSERVICO SET IDORDEM = @IDORDEM, IDSERVICO = @IDSERVICO, VALOR_SERVICO = @VALOR_SERVICO, QUANTIDADE_PEDIDO = @QUANTIDADE_PEDIDO WHERE IDITEM = @IDITEM", con.Conectar());
                cmd.Parameters.AddWithValue(@"IDITEM", itemservicoBLL.Iditem);
                cmd.Parameters.AddWithValue(@"IDORDEM", itemservicoBLL.Idordem);
                cmd.Parameters.AddWithValue(@"IDSERVICO", itemservicoBLL.Idservico);
                cmd.Parameters.AddWithValue(@"VALOR_SERVICO", itemservicoBLL.Valor_servico);
                cmd.Parameters.AddWithValue(@"QUANTIDADE_PEDIDO", itemservicoBLL.Quantidade_pedido);

                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch
            {
                con.Desconectar();
            }
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.ITEM_ORDEMSERVICO",con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(JOALHERIABLL.ItemServicoBLL itemservicoBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.ITEM_ORDEMSERVICO WHERE IDITEM = @IDITEM", con.Conectar());
                cmd.Parameters.AddWithValue(@"IDITEM", itemservicoBLL.Iditem);

                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch
            {
                con.Desconectar();
            }
        }

        public DataTable ConsultarItens(JOALHERIABLL.ItemServicoBLL itemservicoBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("select iditem, idordem, descricao, valor_servico, quantidade_pedido from joalheria.ITEM_ORDEMSERVICO join joalheria.SERVICO on JOALHERIA.ITEM_ORDEMSERVICO.IDSERVICO = JOALHERIA.SERVICO.IDSERVICO where idordem = @idordem",con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"idordem", itemservicoBLL.Idordem);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

    }//
}//
