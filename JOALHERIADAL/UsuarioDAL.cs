using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JOALHERIABLL;
using System.Windows.Forms;

namespace JOALHERIADAL
{
    public class UsuarioDAL
    {
        Conexao con = new Conexao();
        JOALHERIABLL.UsuarioBLL usuarioBLL = new UsuarioBLL();

        //METODO CADASTRAR
        public void Cadastrar(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.USUARIO(NOME, RG, CPF, ENDERECO, TELEFONE, TIPO, USUARIO, SENHA) VALUES (@NOME, @RG, @CPF, @ENDERECO, @TELEFONE, @TIPO, @USUARIO, @SENHA)", con.Conectar());
                cmd.Parameters.AddWithValue("@NOME", usuarioBLL.Nome);
                cmd.Parameters.AddWithValue("@RG", usuarioBLL.Rg);
                cmd.Parameters.AddWithValue("@CPF", usuarioBLL.Cpf);
                cmd.Parameters.AddWithValue("@ENDERECO", usuarioBLL.Endereco);
                cmd.Parameters.AddWithValue("@TELEFONE", usuarioBLL.Telefone);
                cmd.Parameters.AddWithValue("@TIPO", usuarioBLL.Tipo);
                cmd.Parameters.AddWithValue("@USUARIO", usuarioBLL.Usuario);
                cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);

                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //METODO UPDATE
        public void Atualizar(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.USUARIO SET NOME = @NOME, RG = @RG, CPF = @CPF, ENDERECO = @ENDERECO, TIPO = @TIPO, USUARIO = @USUARIO, SENHA = @SENHA WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuarioBLL.Idusuario);
            cmd.Parameters.AddWithValue("@NOME", usuarioBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", usuarioBLL.Rg);
            cmd.Parameters.AddWithValue("@CPF", usuarioBLL.Cpf);
            cmd.Parameters.AddWithValue("ENDERECO", usuarioBLL.Endereco);
            cmd.Parameters.AddWithValue("@TELEFONE", usuarioBLL.Telefone);
            cmd.Parameters.AddWithValue("@TIPO", usuarioBLL.Tipo);
            cmd.Parameters.AddWithValue("@USUARIO", usuarioBLL.Usuario);
            cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        //METODO EXCLUIR
        public void Excluir(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {


            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.USUARIO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuarioBLL.Idusuario);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        //METODO CONSULTAR TODOS
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDUSUARIO, NOME, RG, CPF, ENDERECO, TELEFONE, TIPO, USUARIO, SENHA FROM JOALHERIA.USUARIO", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Desconectar();
            return dt;
        }

        //METODO RETORNARDADOS
        public JOALHERIABLL.UsuarioBLL RetornarDados(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.USUARIO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuarioBLL.Idusuario);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuarioBLL.Idusuario = Convert.ToInt16(dr["IDUSUARIO"]);
                usuarioBLL.Nome = Convert.ToString(dr["NOME"]);
                usuarioBLL.Rg = Convert.ToString(dr["RG"]);
                usuarioBLL.Cpf = Convert.ToString(dr["CPF"]);
                usuarioBLL.Endereco = Convert.ToString(dr["ENDERECO"]);
                usuarioBLL.Telefone = Convert.ToString(dr["TELEFONE"]);
                usuarioBLL.Tipo = Convert.ToBoolean(dr["TIPO"]);
                usuarioBLL.Usuario = Convert.ToString(dr["USUARIO"]);
                usuarioBLL.Senha = Convert.ToString(dr["SENHA"]);
            }

            dr.Close();
            con.Desconectar();
            return usuarioBLL;
        }

        //METODO LE DADOS PARA LOGIN
        public JOALHERIABLL.UsuarioBLL Logar(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM JOALHERIA.USUARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA", con.Conectar());
            cmd.Parameters.AddWithValue("@USUARIO", usuarioBLL.Usuario);
            cmd.Parameters.AddWithValue("@SENHA", usuarioBLL.Senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuarioBLL.Idusuario = Convert.ToInt16(dr["IDUSUARIO"]);
                usuarioBLL.Usuario = Convert.ToString(dr["USUARIO"]);
                usuarioBLL.Senha = Convert.ToString(dr["SENHA"]);
            }

            else
            {
                usuarioBLL.Idusuario = 0;
            }
            dr.Close();
            con.Desconectar();
            return usuarioBLL;
        }

        public DataTable ConsultarPorCodigo(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.USUARIO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"IDUSUARIO", usuarioBLL.Idusuario);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.USUARIO WHERE NOME LIKE @NOME", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"NOME", usuarioBLL.Nome + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorCpf(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.USUARIO WHERE CPF LIKE @CPF", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"CPF", usuarioBLL.Cpf + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorUsuario(JOALHERIABLL.UsuarioBLL usuarioBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.USUARIO WHERE USUARIO LIKE @USUARIO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"USUARIO", usuarioBLL.Usuario + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
        public List<UsuarioBLL> ListarTodosUsuarios()
        {
            List<UsuarioBLL> result = new List<UsuarioBLL>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.USUARIO", con.Conectar());

            foreach (DataRow row in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new UsuarioBLL(row));

            con.Desconectar();
            return result;
        }

        public static List<UsuarioBLL> ListarTodosUsuarios_()
        {
            List<UsuarioBLL> result = new List<UsuarioBLL>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.USUARIO");

            foreach (DataRow row in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new UsuarioBLL(row));

            return result;
        }

        public static UsuarioBLL GetById(int id)
        {
            UsuarioBLL result = new UsuarioBLL();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM JOALHERIA.USUARIO WHERE IDUSUARIO = {id} ;");
            DataTable dt = Acces.ExecuteReader(cmd).Tables[0];
            result = new UsuarioBLL(dt.Rows[0]);
            return result;
        }

        public void AtualizarPermissao(UsuarioBLL user, string update_permission)
        {

        }

        public enum Permissoes
        {
            Financeiro = 'U',
            Estoque = 'E',
            Inclusao = 'I',
            Edicao = 'D',
            Exclusao = 'X'
        }
    }//
}//
