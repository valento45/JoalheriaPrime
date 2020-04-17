using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JOALHERIABLL;

namespace JOALHERIADAL
{
    public class ProdutoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(ProdutoBLL produtoBLL)
        {
            string comand = "INSERT INTO JOALHERIA.PRODUTO (IDCATEGORIA, DESCRICAO, QUANTIDADE, PRECOIMPORTADO, PRECOVENDA, LUCRO, OBSERVACOES, IMAGEM) VALUES (@IDCATEGORIA, @DESCRICAO, @QUANTIDADE, @PRECOIMPORTADO, @PRECOVENDA, @LUCRO, @OBSERVACOES, @IMAGEM)";
            SqlCommand command = new SqlCommand(comand);

            command.Parameters.AddWithValue("@IDCATEGORIA", produtoBLL.Idcategoria);
            command.Parameters.AddWithValue("@DESCRICAO", produtoBLL.Descricao);
            command.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            command.Parameters.AddWithValue("@PRECOIMPORTADO", produtoBLL.Precoimportado);
            command.Parameters.AddWithValue("@PRECOVENDA", produtoBLL.Precovenda);
            command.Parameters.AddWithValue("@LUCRO", produtoBLL.Lucro);
            command.Parameters.AddWithValue("@OBSERVACOES", produtoBLL.Observacoes);
            command.Parameters.AddWithValue("@IMAGEM", produtoBLL.Imagem);

            Acces.ExecuteNonQuery(command);
        }

        public static List<ProdutoBLL> ListarProdutos()
        {
            List<JOALHERIABLL.ProdutoBLL> result = new List<JOALHERIABLL.ProdutoBLL>();
            string query = "SELECT * FROM JOALHERIA.PRODUTO";
            SqlCommand cmd = new SqlCommand(query);
            foreach (DataRow row in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new JOALHERIABLL.ProdutoBLL(row));

            if (result.Count > 0)
                return result;

            else
                return new List<JOALHERIABLL.ProdutoBLL>();
        }

        public static List<ProdutoBLL> ListarPorDescricao(string descricao)
        {
            List<JOALHERIABLL.ProdutoBLL> result = new List<JOALHERIABLL.ProdutoBLL>();

            string query = $"SELECT * FROM JOALHERIA.PRODUTO WHERE DESCRICAO LIKE '{descricao}%'";
            SqlCommand cmd = new SqlCommand(query);
            foreach (DataRow row in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new JOALHERIABLL.ProdutoBLL(row));            
            return result;
        }

        public void Alterar(ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.PRODUTO SET IDCATEGORIA = @IDCATEGORIA, DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE, PRECOIMPORTADO = @PRECOIMPORTADO, PRECOVENDA = @PRECOVENDA, LUCRO = @LUCRO, OBSERVACOES = @OBSERVACOES, IMAGEM = @IMAGEM WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produtoBLL.Idcategoria);
            cmd.Parameters.AddWithValue("@DESCRICAO", produtoBLL.Descricao);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            cmd.Parameters.AddWithValue("@PRECOIMPORTADO", produtoBLL.Precoimportado);
            cmd.Parameters.AddWithValue("@PRECOVENDA", produtoBLL.Precovenda);
            cmd.Parameters.AddWithValue("@LUCRO", produtoBLL.Lucro);
            cmd.Parameters.AddWithValue("@OBSERVACOES", produtoBLL.Observacoes);
            cmd.Parameters.AddWithValue("@IMAGEM", produtoBLL.Imagem);

            Acces.ExecuteNonQuery(cmd);
        }

        public void Excluir(ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = @IDPRODUTO");
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);

            Acces.ExecuteNonQuery(cmd);
        } 
        public static void ExcluirPorCodigo(int codigo)
        {
            SqlCommand cmd = new SqlCommand($"DELETE FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = {codigo}");
            Acces.ExecuteNonQuery(cmd);
        }

        public ProdutoBLL GetById(ProdutoBLL produtoBLL)
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
                produtoBLL.Imagem = dr["IMAGEM"].ToString();

            }

            dr.Close();
            con.Desconectar();
            return produtoBLL;

            //SqlCommand lCmd = new SqlCommand("SELECT * FROM JOALHERIA.PRODUTO WHERE IDPRODUTO =" + codigo + ";");
            //DataTable table = Acces.ExecuteReader(lCmd).Tables[0];
            //if (table.Rows.Count == 1)
            //    return new JOALHERIABLL.ProdutoBLL(table.Rows[0]);
            //else
            //    return new JOALHERIABLL.ProdutoBLL();

        }

        public static ProdutoBLL GetById(int id)
        {
            JOALHERIABLL.ProdutoBLL produto = new ProdutoBLL();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = '" + id + "';");
            DataTable result = Acces.ExecuteReader(cmd).Tables[0];
            produto = new ProdutoBLL(result.Rows[0]);
            //foreach (DataRow row in result.Rows)
            //    produto = new JOALHERIABLL.ProdutoBLL(row);
            return produto;
        }

        //BAIXAR ESTOQUE
        public void BaixarEstoque(ProdutoBLL produtoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.PRODUTO SET QUANTIDADE = QUANTIDADE - @QUANTIDADE WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produtoBLL.Idproduto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produtoBLL.Quantidade);
            Acces.ExecuteNonQuery(cmd);

        }
        //========================================== CONSULTAS ==================================================
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO, IDCATEGORIA, DESCRICAO, QUANTIDADE, PRECOIMPORTADO, PRECOVENDA, LUCRO, OBSERVACOES FROM JOALHERIA.PRODUTO", con.Conectar());
            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        //consultar por descricao
        public DataTable ConsultarPorDescricao(ProdutoBLL produtoBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.PRODUTO WHERE DESCRICAO LIKE @DESCRICAO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"DESCRICAO", produtoBLL.Descricao + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCodigo(ProdutoBLL produtoBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.PRODUTO WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"IDPRODUTO", produtoBLL.Idproduto);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        //METODO EM IMPLEMENTAÇÃO
        //public DataTable ConsultarPorCategoria(JOALHERIABLL.ProdutoBLL produtoBLL)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO, CATEGORIA FROM JOALHERIA.PRODUTO JOIN JOALHERIA.CATEGORIA ON JOALHERIA.PRODUTO.IDCATEGORIA = JOALHERIA.CATEGORIA.IDCATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA",con.Conectar());
        //}


    }//
}//
