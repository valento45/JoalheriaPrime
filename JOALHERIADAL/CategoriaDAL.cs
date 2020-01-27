using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace JOALHERIADAL
{
    public class CategoriaDAL
    {

        Conexao con = new Conexao();

        public void Cadastrar(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.CATEGORIA(CATEGORIA) VALUES (@CATEGORIA)", con.Conectar());
            cmd.Parameters.AddWithValue("@CATEGORIA", categoriaBLL.Categoria);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Excluir(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoriaBLL.Idcategoria);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }


        public void Alterar(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.CATEGORIA SET CATEGORIA = @CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoriaBLL.Idcategoria);
            cmd.Parameters.AddWithValue("@CATEGORIA", categoriaBLL.Categoria);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public JOALHERIABLL.CategoriaBLL RetornarDados(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CATEGORIA", con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                categoriaBLL.Idcategoria = Convert.ToInt16(dr["IDCATEGORIA"]);
                categoriaBLL.Categoria = Convert.ToString(dr["CATEGORIA"]);
            }
            dr.Close();
            con.Desconectar();
            return categoriaBLL;

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCATEGORIA, CATEGORIA FROM JOALHERIA.CATEGORIA", con.Conectar());
            DataTable dt = new DataTable();

            da.Fill(dt);

            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCategoria(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CATEGORIA WHERE CATEGORIA LIKE @CATEGORIA",con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"CATEGORIA", categoriaBLL.Categoria + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCodigo(JOALHERIABLL.CategoriaBLL categoriaBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA",con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"IDCATEGORIA", categoriaBLL.Idcategoria);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }



    }//
}//
