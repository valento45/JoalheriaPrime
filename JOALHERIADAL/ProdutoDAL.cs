using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace JOALHERIADAL
{
    public class ProdutoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(JOALHERIABLL.ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.PRODUTO (IDCATEGORIA, DESCRICAO, QUANTIDADE, PRECOIMPORTADO, PRECOVENDA, LUCRO, OBSERVACOES) VALUES (@IDCATEGORIA, @DESCRICAO, @QUANTIDADE, @PRECOIMPORTADO, @PRECOVENDA, @LUCRO, @OBSERVACOES)", con.Conectar());

            cmd.Parameters.AddWithValue("@IDCATEGORIA", produtoBLL.Idcategoria);
            cmd.Parameters.AddWithValue("@DESCRICAO", produtoBLL.Descricao);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            cmd.Parameters.AddWithValue("@PRECOIMPORTADO", produtoBLL.Precoimportado);
            cmd.Parameters.AddWithValue("@PRECOVENDA", produtoBLL.Precovenda);
            cmd.Parameters.AddWithValue("@LUCRO", produtoBLL.Lucro);
            cmd.Parameters.AddWithValue("@OBSERVACOES", produtoBLL.Observacoes);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }


        public void Alterar(JOALHERIABLL.ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.PRODUTO SET IDCATEGORIA = @IDCATEGORIA, DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE, PRECOIMPORTADO = @PRECOIMPORTADO, PRECOVENDA = @PRECOVENDA, LUCRO = @LUCRO, OBSERVACOES = @OBSERVACOES WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produtoBLL.Idcategoria);
            cmd.Parameters.AddWithValue("@DESCRICAO", produtoBLL.Descricao);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            cmd.Parameters.AddWithValue("@PRECOIMPORTADO", produtoBLL.Precoimportado);
            cmd.Parameters.AddWithValue("@PRECOVENDA", produtoBLL.Precovenda);
            cmd.Parameters.AddWithValue("@LUCRO", produtoBLL.Lucro);
            cmd.Parameters.AddWithValue("@OBSERVACOES", produtoBLL.Observacoes);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Excluir(JOALHERIABLL.ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public JOALHERIABLL.ProdutoBLL RetornarDados(JOALHERIABLL.ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                produtoBLL.Idproduto = Convert.ToInt16(dr["IDPRODUTO"]);
                produtoBLL.Idcategoria = Convert.ToInt16(dr["IDCATEGORIA"]);
                produtoBLL.Descricao = Convert.ToString(dr["DESCRICAO"]);
                produtoBLL.Quantidade = Convert.ToInt16(dr["QUANTIDADE"]);
                produtoBLL.Precoimportado = Convert.ToDecimal(dr["PRECOIMPORTADO"]);
                produtoBLL.Precovenda = Convert.ToDecimal(dr["PRECOVENDA"]);
                produtoBLL.Lucro = Convert.ToDecimal(dr["LUCRO"]);
                produtoBLL.Observacoes = Convert.ToString(dr["OBSERVACOES"]);

            }

            dr.Close();
            con.Desconectar();
            return produtoBLL;
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO, IDCATEGORIA, DESCRICAO, QUANTIDADE, PRECOIMPORTADO, PRECOVENDA, LUCRO, OBSERVACOES FROM JOALHERIA.PRODUTO", con.Conectar());
            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
        //BAIXAR ESTOQUE
        public void BaixarEstoque(JOALHERIABLL.ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.PRODUTO SET QUANTIDADE = QUANTIDADE - @QUANTIDADE WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }
    }
}
