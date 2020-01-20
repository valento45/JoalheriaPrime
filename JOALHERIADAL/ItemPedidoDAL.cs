using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JOALHERIADAL
{
    public class ItemPedidoDAL
    {

        Conexao con = new Conexao();

        public void Cadastrar(JOALHERIABLL.ItemPedidoBLL itempedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.ITEMPEDIDO(IDVENDA, IDPRODUTO, PRECOUNITARIO, QUANTIDADEPEDIDO) VALUES (@IDVENDA, @IDPRODUTO, @PRECOUNITARIO, @QUANTIDADEPEDIDO)", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", itempedidoBLL.Idvenda);
            cmd.Parameters.AddWithValue("@IDPRODUTO", itempedidoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@PRECOUNITARIO", itempedidoBLL.Precounitario);
            cmd.Parameters.AddWithValue("@QUANTIDADEPEDIDO", itempedidoBLL.Quantidade);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }


        public void Alterar(JOALHERIABLL.ItemPedidoBLL itempedidoBLL)
        {

            SqlCommand cmd = new SqlCommand("UPDATE FROM JOALHERIA.ITEMPEDIDO SET IDVENDA = @IDVENDA, IDPRODUTO = @IDPRODUTO, PRECOUNITARIO = @PRECOUNITARIO, QUANTIDADE = @QUANTIDADE WHERE IDITEMPEDIDO = @IDITEMPEDIDO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDITEMPEDIDO", itempedidoBLL.Iditempedido);
            cmd.Parameters.AddWithValue("@IDVENDA", itempedidoBLL.Idvenda);
            cmd.Parameters.AddWithValue("@IDPRODUTO", itempedidoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@PRECOUNITARIO", itempedidoBLL.Precounitario);
            cmd.Parameters.AddWithValue("@QUANTIDADE", itempedidoBLL.Quantidade);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Excluir(JOALHERIABLL.ItemPedidoBLL itempedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.ITEMPEDIDO WHERE IDITEMPEDIDO = @IDITEMPEDIDO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDITEMPEDIDO", itempedidoBLL.Iditempedido);
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT I.IDITEMPEDIDO, I.IDVENDA, R.IDPRODUTO, R.DESCRICAO, I.PRECOUNITARIO, I.QUANTIDADEPEDIDO FROM JOALHERIA.ITEMPEDIDO AS I,JOALHERIA.PRODUTO AS R, JOALHERIA.VENDA AS V WHERE I.IDVENDA = V.IDVENDA", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }

        public DataTable ConsultarPorCodigoVenda(JOALHERIABLL.ItemPedidoBLL itempedido)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDITEMPEDIDO, DESCRICAO, PRECOUNITARIO, QUANTIDADEPEDIDO FROM JOALHERIA.ITEMPEDIDO JOIN JOALHERIA.PRODUTO ON JOALHERIA.ITEMPEDIDO.IDPRODUTO = JOALHERIA.PRODUTO.IDPRODUTO WHERE JOALHERIA.ITEMPEDIDO.IDVENDA = @IDVENDA", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@IDVENDA", itempedido.Idvenda);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}
