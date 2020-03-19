using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using JOALHERIABLL;
namespace JOALHERIADAL
{
    public class ClienteDAL : Pessoa
    {
        #region  OLD

        //    Conexao con = new Conexao();

        //    public bool Cadastrar(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.CLIENTE (NOME, RG, CPF, DATA_NASCIMENTO, EMAIL, TELEFONE, ENDERECO, CIDADE, UF, TIPO_CLIENTE) VALUES (@NOME, @RG, @CPF, @DATA_NASCIMENTO, @EMAIL, @TELEFONE, @ENDERECO, @CIDADE, @UF, @TIPO_CLIENTE)", con.Conectar());
        //            cmd.Parameters.AddWithValue(@"NOME", clienteBLL.Nome);
        //            cmd.Parameters.AddWithValue(@"RG", clienteBLL.Rg);
        //            cmd.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf);
        //            cmd.Parameters.AddWithValue(@"DATA_NASCIMENTO", clienteBLL.Data_nascimento);
        //            cmd.Parameters.AddWithValue(@"EMAIL", clienteBLL.Email);
        //            cmd.Parameters.AddWithValue(@"TELEFONE", clienteBLL.Telefone);
        //            cmd.Parameters.AddWithValue(@"ENDERECO", clienteBLL.Endereco);
        //            cmd.Parameters.AddWithValue(@"CIDADE", clienteBLL.Cidade);
        //            cmd.Parameters.AddWithValue(@"UF", clienteBLL.Uf);
        //            cmd.Parameters.AddWithValue(@"TIPO_CLIENTE", clienteBLL.Tipo_cliente);

        //            cmd.ExecuteNonQuery();
        //            con.Desconectar();
        //            return true;                
        //        }
        //        catch
        //        {
        //            con.Desconectar();
        //            return false;
        //        }
        //    }


        //    public void Alterar(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.CLIENTE SET NOME = @NOME, RG = @RG, CPF = @CPF, DATA_NASCIMENTO = @DATA_NASCIMENTO, EMAIL = @EMAIL, TELEFONE = @TELEFONE, ENDERECO = @ENDERECO, CIDADE = @CIDADE, UF = @UF, TIPO_CLIENTE = @TIPO_CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
        //        cmd.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);
        //        cmd.Parameters.AddWithValue(@"NOME", clienteBLL.Nome);
        //        cmd.Parameters.AddWithValue(@"RG", clienteBLL.Rg);
        //        cmd.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf);
        //        cmd.Parameters.AddWithValue(@"DATA_NASCIMENTO", clienteBLL.Data_nascimento);
        //        cmd.Parameters.AddWithValue(@"EMAIL", clienteBLL.Email);
        //        cmd.Parameters.AddWithValue(@"TELEFONE", clienteBLL.Telefone);
        //        cmd.Parameters.AddWithValue(@"ENDERECO", clienteBLL.Endereco);
        //        cmd.Parameters.AddWithValue(@"CIDADE", clienteBLL.Cidade);
        //        cmd.Parameters.AddWithValue(@"UF", clienteBLL.Uf);
        //        cmd.Parameters.AddWithValue(@"TIPO_CLIENTE", clienteBLL.Tipo_cliente);

        //        cmd.ExecuteNonQuery();
        //        con.Desconectar();

        //    }


        //public void Excluir(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.CLIENTE WHERE IDCLIENTE =@IDCLIENTE",con.Conectar());
        //        cmd.Parameters.AddWithValue("IDCLIENTE", clienteBLL.Idcliente);

        //        cmd.ExecuteNonQuery();
        //        con.Desconectar();

        //    }

        //    //public List<JOALHERIABLL.ClienteBLL> ConsultarTodosLista()
        //    //{
        //        //try
        //        //{
        //        //    SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CLIENTE ORDER BY IDCLIENTE", con.Conectar());
        //        //    SqlDataReader dr = cmd.ExecuteReader();

        //        //    List<JOALHERIABLL.ClienteBLL> Result = new List<JOALHERIABLL.ClienteBLL>();

        //        //    while (dr.Read())
        //        //    {
        //        //        Result.Add(new JOALHERIABLL.ClienteBLL()
        //        //        {
        //        //            Idcliente = Convert.ToInt32(dr["IDCLIENTE"]),
        //        //            Nome = dr["NOME"].ToString(),
        //        //            Rg = dr["RG"].ToString(),
        //        //            Cpf = dr["CPF"].ToString(),
        //        //            Data_nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]),
        //        //            Email = dr["EMAIL"].ToString(),
        //        //            Telefone = dr["TELEFONE"].ToString(),
        //        //            Endereco = dr["ENDERECO"].ToString(),
        //        //            Cidade = dr["CIDADE"].ToString(),
        //        //            Uf = dr["UF"].ToString(),
        //        //            Tipo_cliente = dr["TIPO_CLIENTE"].ToString()
        //        //        }
        //        //      );
        //        //    }; //FIM DO WHILE

        //        //    dr.Close();
        //        //    con.Desconectar();
        //        //    return Result;
        //        //}
        //        //catch
        //        //{
        //        //    con.Desconectar();
        //        //    return null;
        //        //}
        //   // }

        //    public JOALHERIABLL.ClienteBLL RetornarDados(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
        //        cmd.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            clienteBLL.Idcliente = Convert.ToInt32(dr["IDCLIENTE"]);
        //            clienteBLL.Nome = dr["NOME"].ToString();
        //            clienteBLL.Rg = dr["RG"].ToString();
        //            clienteBLL.Cpf = dr["CPF"].ToString();
        //            clienteBLL.Data_nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]);
        //            clienteBLL.Email = dr["EMAIL"].ToString();
        //            clienteBLL.Telefone = dr["TELEFONE"].ToString();
        //            clienteBLL.Endereco = dr["ENDERECO"].ToString();
        //            clienteBLL.Cidade = dr["CIDADE"].ToString();
        //            clienteBLL.Uf = dr["UF"].ToString();
        //            clienteBLL.Tipo_cliente = dr["TIPO_CLIENTE"].ToString();
        //        }
        //        dr.Close();
        //        con.Desconectar();
        //        return clienteBLL;
        //    }
        //    //====================================== CONSULTAS =========================================================
        //    public DataTable ConsultarTodos()
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE", con.Conectar());
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        return dt;
        //    }

        //    public DataTable ConsultarPorNome(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE NOME LIKE @NOME",con.Conectar());
        //        da.SelectCommand.Parameters.AddWithValue(@"NOME", clienteBLL.Nome + "%");
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        con.Desconectar();
        //        return dt;
        //    }

        //    public DataTable ConsultarPorCpf(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE CPF LIKE @CPF", con.Conectar());
        //        da.SelectCommand.Parameters.AddWithValue(@"CPF", clienteBLL.Cpf + "%");
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        con.Desconectar();
        //        return dt;
        //    }

        //    public DataTable ConsultarPorCodigo(JOALHERIABLL.ClienteBLL clienteBLL)
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.CLIENTE WHERE IDCLIENTE = @IDCLIENTE",con.Conectar());
        //        da.SelectCommand.Parameters.AddWithValue(@"IDCLIENTE", clienteBLL.Idcliente);
        //        DataTable DT = new DataTable();
        //        da.Fill(DT);
        //        con.Desconectar();
        //        return DT;
        //    }

        #endregion Antes

        public string Tipo_cliente { get; set; }
        public DateTime Data_registro { get; set; }

        public ClienteDAL()
        {
        }

        public ClienteDAL(DataRow dr)
        {
            Idpessoa = Convert.ToInt32(dr["idcliente"]);
            Nome = dr["NOME"].ToString();
            Tipo_documento = dr["tipo_documento"].ToString();
            Documento = dr["RG"].ToString();
            Cpf_cnpj = dr["CPF"].ToString();
            Data_nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]);
            Email = dr["EMAIL"].ToString();
            Telefone = dr["TELEFONE"].ToString();
            Endereco = dr["ENDERECO"].ToString();
            Cidade = dr["CIDADE"].ToString(); ;
            Uf = dr["UF"].ToString();
            Complemento = dr["complemento"].ToString();
            Tipo_pessoa = dr["tipo_pessoa"].ToString();
            Tipo_cliente = dr["TIPO_CLIENTE"].ToString();
            Data_registro = Convert.ToDateTime(dr["data_registro"]);
        }

        public bool Insert_Client( ClienteDAL clienteDAL)
        {
            bool sucesso = false;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into JOALHERIA.CLIENTE (nome, tipo_documento, rg, cpf, data_nascimento, email, telefone, endereco, cidade, uf, complemento, tipo_pessoa, tipo_cliente, data_registro) values (@nome, @tipo_documento, @rg, @cpf, @data_nascimento, @email, @telefone, @endereco, @cidade, @uf, @complemento, @tipo_pessoa, @tipo_cliente, @data_registro);");
                cmd.Parameters.AddWithValue(@"nome", Nome);
                cmd.Parameters.AddWithValue(@"tipo_documento", Tipo_documento);
                cmd.Parameters.AddWithValue(@"rg", Documento);
                cmd.Parameters.AddWithValue(@"cpf", Cpf_cnpj);
                cmd.Parameters.AddWithValue(@"data_nascimento", Data_nascimento);
                cmd.Parameters.AddWithValue(@"email", Email);
                cmd.Parameters.AddWithValue(@"telefone", Telefone);
                cmd.Parameters.AddWithValue(@"endereco", Endereco);
                cmd.Parameters.AddWithValue(@"cidade", Cidade);
                cmd.Parameters.AddWithValue(@"uf", Uf);
                cmd.Parameters.AddWithValue(@"complemento", Complemento);
                cmd.Parameters.AddWithValue(@"tipo_pessoa", Tipo_pessoa);
                cmd.Parameters.AddWithValue(@"tipo_cliente", Tipo_cliente);
                cmd.Parameters.AddWithValue(@"data_registro", Data_registro);

                Acces.ExecuteNonQuery(cmd);

                sucesso = true;
            }
            catch(Exception ex)
            {
                sucesso = false;
            }
            return sucesso;
        }


        public bool Update_Client(ClienteDAL clienteDAL)
        {
            bool sucesso = false;
            try
            {
                SqlCommand cmd = new SqlCommand("update JOALHERIA.CLIENTE set nome = @nome, tipo_documento = @tipo_documento, rg = @rg, cpf = @cpf, data_nascimento = @data_nascimento, email = @email, telefone = @telefone, endereco = @endereco, cidade = @cidade, uf = @uf, complemento = @complemento, tipo_pessoa = @tipo_pessoa, tipo_cliente = @tipo_cliente, data_registro = @data_registro where idcliente = @idcliente;");
                cmd.Parameters.AddWithValue(@"idcliente", Idpessoa);
                cmd.Parameters.AddWithValue(@"nome", Nome);
                cmd.Parameters.AddWithValue(@"tipo_documento", Tipo_documento);
                cmd.Parameters.AddWithValue(@"rg", Documento);
                cmd.Parameters.AddWithValue(@"cpf", Cpf_cnpj);
                cmd.Parameters.AddWithValue(@"data_nascimento", Data_nascimento);
                cmd.Parameters.AddWithValue(@"email", Email);
                cmd.Parameters.AddWithValue(@"telefone", Telefone);
                cmd.Parameters.AddWithValue(@"endereco", Endereco);
                cmd.Parameters.AddWithValue(@"cidade", Cidade);
                cmd.Parameters.AddWithValue(@"uf", Uf);
                cmd.Parameters.AddWithValue(@"complemento", Complemento);
                cmd.Parameters.AddWithValue(@"tipo_pessoa", Tipo_pessoa);
                cmd.Parameters.AddWithValue(@"tipo_cliente", Tipo_cliente);
                cmd.Parameters.AddWithValue(@"data_registro", Data_registro);

                Acces.ExecuteNonQuery(cmd);

                sucesso = true;
            }
            catch (Exception ex)
            {
                sucesso = false;
            }
            return sucesso;
        }

        public static List<Pessoa> ListarClientes()
        {
            List<Pessoa> result = new List<Pessoa>();

            SqlCommand cmd = new SqlCommand("select * from JOALHERIA.CLIENTE");
            foreach (DataRow cliente in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new ClienteDAL(cliente));
            return result;
        }

        public Pessoa GetById(int idcliente)
        {
            ClienteDAL result = new ClienteDAL();
            SqlCommand cmd = new SqlCommand("select * from JOALHERIA.CLIENTE where idcliente = '" + idcliente + "';");
            foreach (DataRow row in Acces.ExecuteReader(cmd).Tables[0].Rows)
               result =  new ClienteDAL(row);
            return result;            
        }

    }//
}//
