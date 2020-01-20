using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace JOALHERIADAL
{
    public class ServicoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(JOALHERIABLL.ServicoBLL servicoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.SERVICO (DESCRICAO, PRECO_UNITARIO) VALUES (@DESCRICAO, @PRECO_UNITARIO)", con.Conectar());
            cmd.Parameters.AddWithValue(@"DESCRICAO", servicoBLL.Descricao);
            cmd.Parameters.AddWithValue(@"PRECO_UNITARIO", servicoBLL.Valor_servico);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(JOALHERIABLL.ServicoBLL servicoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.SERVICO SET DESCRICAO = @DESCRICAO, PRECO_UNITARIO = @PRECO_UNITARIO WHERE IDSERVICO = @IDSERVICO", con.Conectar());
            cmd.Parameters.AddWithValue(@"IDSERVICO", servicoBLL.Idservico);
            cmd.Parameters.AddWithValue(@"DESCRICAO", servicoBLL.Descricao);
            cmd.Parameters.AddWithValue(@"PRECO_UNITARIO", servicoBLL.Valor_servico);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public void Excluir(JOALHERIABLL.ServicoBLL servicoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.SERVICO WHERE IDSERVICO = @IDSERVICO",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDSERVICO", servicoBLL.Idservico);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        //METODO CONSULTAR COM LISTA
        public List<JOALHERIABLL.ServicoBLL> ConsultarTodosList()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.SERVICO",con.Conectar());
            List<JOALHERIABLL.ServicoBLL> Result = new List<JOALHERIABLL.ServicoBLL>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Result.Add(new JOALHERIABLL.ServicoBLL()
                {
                    Idservico = Convert.ToInt32(dr["IDSERVICO"]),
                    Descricao = dr["DESCRICAO"].ToString(),
                    Valor_servico = Convert.ToDecimal(dr["PRECO_UNITARIO"])
                }
                );
            }//fim while
            dr.Close();
            con.Desconectar();
            return Result;
        }

        public JOALHERIABLL.ServicoBLL RetornarDados(JOALHERIABLL.ServicoBLL servicoBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.SERVICO WHERE IDSERVICO = @IDSERVICO", con.Conectar());
            cmd.Parameters.AddWithValue(@"IDSERVICO", servicoBLL.Idservico);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                servicoBLL.Idservico = Convert.ToInt32(dr["IDSERVICO"]);
                servicoBLL.Descricao = dr["DESCRICAO"].ToString();
                servicoBLL.Valor_servico = Convert.ToDecimal(dr["PRECO_UNITARIO"]);
            }
            dr.Close();
            con.Desconectar();
            return servicoBLL;
        }

    }//
}//
