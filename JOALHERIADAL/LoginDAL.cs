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
    public class LoginDAL
    {
        Conexao con = new Conexao();
        //METODO CADASTRAR
        public int Cadastrar_Login(JOALHERIABLL.LoginBLL loginBLL)
        {
          
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.LOGIN (IDCAIXA, IDUSUARIO, USUARIO, DATA_LOGIN, VALOR_CAIXA) VALUES (@IDCAIXA, @IDUSUARIO, @USUARIO, @DATA_LOGIN, @VALOR_CAIXA);SELECT SCOPE_IDENTITY();", con.Conectar());
                cmd.Parameters.AddWithValue(@"IDCAIXA", loginBLL.Idcaixa);
                cmd.Parameters.AddWithValue(@"IDUSUARIO", loginBLL.Idusuario);
                cmd.Parameters.AddWithValue(@"USUARIO", loginBLL.Usuario);
                cmd.Parameters.AddWithValue(@"DATA_LOGIN", loginBLL.Data_login);
                cmd.Parameters.AddWithValue(@"VALOR_CAIXA", loginBLL.Valor_caixa);
                int chave_gerada = 0;
                chave_gerada = Convert.ToInt32(cmd.ExecuteScalar());
                con.Desconectar();
                return chave_gerada;             
        }

        //METODO CONSULTAR POR LISTA
        public List<JOALHERIABLL.LoginBLL> ConsultarTodos()
        {
            try
            {
                List<JOALHERIABLL.LoginBLL> Result = new List<JOALHERIABLL.LoginBLL>();
                SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.LOGIN ", con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Result.Add(new JOALHERIABLL.LoginBLL()
                    {
                        Idcaixa = Convert.ToInt32(dr["IDCAIXA"]),
                        Idusuario = Convert.ToInt32(dr["IDUSUARIO"]),
                        Usuario = dr["USUARIO"].ToString(),
                        Data_login = Convert.ToDateTime(dr["DATA_LOGIN"]),
                        Valor_caixa = Convert.ToDecimal(dr["VALOR_CAIXA"])
                    }); ;
                }

                dr.Close();
                con.Desconectar();
                return Result;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(" LoginDAL Erro SQL: " + ex.Message);
                con.Desconectar();
                return null;
            }

        }

        public void Alterar(JOALHERIABLL.LoginBLL loginBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.LOGIN SET VALOR_CAIXA = @VALOR_CAIXA WHERE IDLOGIN = @IDLOGIN",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDLOGIN", loginBLL.Idlogin);
            cmd.Parameters.AddWithValue(@"VALOR_CAIXA", loginBLL.Valor_caixa);

            cmd.ExecuteNonQuery();
            con.Desconectar();
            
        }

    }
}
