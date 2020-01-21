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
    public class ClienteDAL
    {
        Conexao con = new Conexao();

        public bool Cadastrar(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.CLIENTE (NOME, RG, CPF, DATA_NASCIMENTO, EMAIL, TELEFONE, ENDERECO, CIDADE, UF, TIPO_CLIENTE) VALUES (@NOME, @RG, @CPF, @DATA_NASCIMENTO, @EMAIL, @TELEFONE, @ENDERECO, @CIDADE, @UF, @TIPO_CLIENTE)", con.Conectar());
                cmd.Parameters.AddWithValue(@"NOME", clienteBLL.Nome);
                cmd.Parameters.AddWithValue(@"RG", clienteBLL.Rg);
                cmd.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf);
                cmd.Parameters.AddWithValue(@"DATA_NASCIMENTO", clienteBLL.Data_nascimento);
                cmd.Parameters.AddWithValue(@"EMAIL", clienteBLL.Email);
                cmd.Parameters.AddWithValue(@"TELEFONE", clienteBLL.Telefone);
                cmd.Parameters.AddWithValue(@"ENDERECO", clienteBLL.Endereco);
                cmd.Parameters.AddWithValue(@"CIDADE", clienteBLL.Cidade);
                cmd.Parameters.AddWithValue(@"UF", clienteBLL.Uf);
                cmd.Parameters.AddWithValue(@"TIPO_CLIENTE", clienteBLL.Tipo_cliente);

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


        public void Alterar(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.CLIENTE SET NOME = @NOME, RG = @RG, CPF = @CPF, DATA_NASCIMENTO = @DATA_NASCIMENTO, EMAIL = @EMAIL, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, CIDADE = @CIDADE, UF = @UF, TIPO_CLIENTE = @TIPO_CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);
            cmd.Parameters.AddWithValue(@"NOME", clienteBLL.Nome);
            cmd.Parameters.AddWithValue(@"RG", clienteBLL.Rg);
            cmd.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf);
            cmd.Parameters.AddWithValue(@"DATA_NASCIMENTO", clienteBLL.Data_nascimento);
            cmd.Parameters.AddWithValue(@"EMAIL", clienteBLL.Email);
            cmd.Parameters.AddWithValue(@"TELEFONE", clienteBLL.Telefone);
            cmd.Parameters.AddWithValue(@"ENDERECO", clienteBLL.Endereco);
            cmd.Parameters.AddWithValue(@"CIDADE", clienteBLL.Cidade);
            cmd.Parameters.AddWithValue(@"UF", clienteBLL.Uf);
            cmd.Parameters.AddWithValue(@"TIPO_CLIENTE", clienteBLL.Tipo_cliente);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }
    
    
    public void Excluir(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.CLIENTE WHERE IDCLIENTE =@IDCLIENTE",con.Conectar());
            cmd.Parameters.AddWithValue("IDCLIENTE", clienteBLL.Idcliente);

            cmd.ExecuteNonQuery();
            con.Desconectar();
                
        }

        //public List<JOALHERIABLL.ClienteBLL> ConsultarTodosLista()
        //{
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CLIENTE ORDER BY IDCLIENTE", con.Conectar());
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    List<JOALHERIABLL.ClienteBLL> Result = new List<JOALHERIABLL.ClienteBLL>();

            //    while (dr.Read())
            //    {
            //        Result.Add(new JOALHERIABLL.ClienteBLL()
            //        {
            //            Idcliente = Convert.ToInt32(dr["IDCLIENTE"]),
            //            Nome = dr["NOME"].ToString(),
            //            Rg = dr["RG"].ToString(),
            //            Cpf = dr["CPF"].ToString(),
            //            Data_nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]),
            //            Email = dr["EMAIL"].ToString(),
            //            Telefone = dr["TELEFONE"].ToString(),
            //            Endereco = dr["ENDERECO"].ToString(),
            //            Cidade = dr["CIDADE"].ToString(),
            //            Uf = dr["UF"].ToString(),
            //            Tipo_cliente = dr["TIPO_CLIENTE"].ToString()
            //        }
            //      );
            //    }; //FIM DO WHILE

            //    dr.Close();
            //    con.Desconectar();
            //    return Result;
            //}
            //catch
            //{
            //    con.Desconectar();
            //    return null;
            //}
       // }

        public JOALHERIABLL.ClienteBLL RetornarDados(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                clienteBLL.Idcliente = Convert.ToInt32(dr["IDCLIENTE"]);
                clienteBLL.Nome = dr["NOME"].ToString();
                clienteBLL.Rg = dr["RG"].ToString();
                clienteBLL.Cpf = dr["CPF"].ToString();
                clienteBLL.Data_nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]);
                clienteBLL.Email = dr["EMAIL"].ToString();
                clienteBLL.Telefone = dr["TELEFONE"].ToString();
                clienteBLL.Endereco = dr["ENDERECO"].ToString();
                clienteBLL.Cidade = dr["CIDADE"].ToString();
                clienteBLL.Uf = dr["UF"].ToString();
                clienteBLL.Tipo_cliente = dr["TIPO_CLIENTE"].ToString();
            }
            dr.Close();
            con.Desconectar();
            return clienteBLL;
        }
        //====================================== CONSULTAS =========================================================
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable ConsultarPorNome(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE NOME LIKE @NOME",con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"NOME", clienteBLL.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCpf(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE CPF LIKE @CPF", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCodigo(JOALHERIABLL.ClienteBLL clienteBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);
            DataTable DT = new DataTable();
            da.Fill(DT);
            con.Desconectar();
            return DT;
        }
        

    }//
}//
