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

        //METODO CONSULTAR COM LISTA IGUAL O DOC    
        public List<JOALHERIABLL.ServicoBLL> ConsultarTodosList()
        {
            List<JOALHERIABLL.ServicoBLL> Result = new List<JOALHERIABLL.ServicoBLL>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.SERVICO",con.Conectar());

            foreach (DataRow row in ExecuteReader(cmd).Tables[0].Rows)
                Result.Add(new JOALHERIABLL.ServicoBLL(row));
            return Result;
            
        }

        //METODO EXECUTE READER LEITURA QUASE QUE UNIVERSAL
        public DataSet ExecuteReader(IDbCommand cmd)
        {
            DataSet ds = null;
            IDbDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
            ds = new DataSet();
            da.Fill(ds);

            return ds;
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
