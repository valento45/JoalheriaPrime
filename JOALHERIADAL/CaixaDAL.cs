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
    public class CaixaDAL
    {
        Conexao con = new Conexao();

        public bool Registrar_Caixa(JOALHERIABLL.CaixaBLL caixaBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.CAIXA (IDENTIFICACAO_CAIXA, DESCRICAO, OBSERVACOES) VALUES (@IDENTIFICACAO_CAIXA, @DESCRICAO, @OBSERVACOES)", con.Conectar());
                cmd.Parameters.AddWithValue(@"IDENTIFICACAO_CAIXA", caixaBLL.Identificacao_caixa);
                cmd.Parameters.AddWithValue(@"DESCRICAO", caixaBLL.Descricao);
                cmd.Parameters.AddWithValue(@"OBSERVACOES", caixaBLL.Observacoes);

                cmd.ExecuteNonQuery();
                con.Desconectar();                    
                return true;
            }
            catch
            {
                con.Desconectar();
                return false;
            }            
        }

        public bool Alterar(JOALHERIABLL.CaixaBLL caixaBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.CAIXA SET IDENTIFICACAO_CAIXA = @IDENTIFICACAO_CAIXA, DESCRICAO = @DESCRICAO, OBSERVACOES = @OBSERVACOES WHERE IDCAIXA = @IDCAIXA",con.Conectar());
                cmd.Parameters.AddWithValue(@"IDCAIXA", caixaBLL.Idcaixa);
                cmd.Parameters.AddWithValue(@"IDENTIFICACAO_CAIXA", caixaBLL.Identificacao_caixa);
                cmd.Parameters.AddWithValue(@"DESCRICAO", caixaBLL.Descricao);
                cmd.Parameters.AddWithValue(@"OBSERVACOES", caixaBLL.Observacoes);

                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch
            {
                con.Desconectar();
                return false;
            }            
        }

        public List<JOALHERIABLL.CaixaBLL> ConsultarTodosLista()
        {
            try
            {
                List<JOALHERIABLL.CaixaBLL> Result = new List<JOALHERIABLL.CaixaBLL>();

                SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CAIXA ORDER BY ASC IDCAIXA", con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Result.Add(new JOALHERIABLL.CaixaBLL()
                    {
                        Idcaixa = Convert.ToInt32(dr["IDCAIXA"].ToString()),
                        Descricao = dr["DESCRICAO"].ToString(),
                        Identificacao_caixa = dr["IDENTIFICACAO_CAIXA"].ToString(),
                        Observacoes = dr["OBSERVACOES"].ToString()
                    });
                }

                con.Desconectar();
                return Result;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(" Erro SQL: " + ex.Message);
                con.Desconectar();
                return null;
            }
        }
    }//
}//
