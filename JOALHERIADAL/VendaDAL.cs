using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;//XML
using System.Xml.Linq;//
using System.Xml.Xsl;//
using System.Xml.XmlConfiguration;//
using System.Xml.Schema;//
using System.Windows.Forms;
using JOALHERIABLL;

namespace JOALHERIADAL
{
    public class VendaDAL
    {
        Conexao con = new Conexao();

        public int Cadastrar(JOALHERIABLL.VendaBLL vendaBLL)
        {
            int chave_gerada = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.VENDA (IDCLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO) VALUES (@IDCLIENTE, GETDATE(), @USUARIO, @PRECOTOTAL, @FORMAPAGAMENTO, @VALORPAGO, @TROCO); SELECT SCOPE_IDENTITY();");
                cmd.Parameters.AddWithValue("@IDCLIENTE", vendaBLL.Idcliente);
                cmd.Parameters.AddWithValue("@DATAVENDA", vendaBLL.Datavenda);
                cmd.Parameters.AddWithValue("@USUARIO", vendaBLL.Usuario);
                cmd.Parameters.AddWithValue("@PRECOTOTAL", vendaBLL.Precototal);
                cmd.Parameters.AddWithValue("@FORMAPAGAMENTO", vendaBLL.Formapagamento);
                cmd.Parameters.AddWithValue("@VALORPAGO", vendaBLL.Valorpago);
                cmd.Parameters.AddWithValue("@TROCO", vendaBLL.Troco);                
                chave_gerada = Acces.ExecuteScalar(cmd);
                              
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Ocorreu um erro: " + error, "Exception ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Desconectar();
            }
            return chave_gerada;
        }

        public void Alterar(JOALHERIABLL.VendaBLL vendaBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE FROM JOALHERIA.VENDA SET IDCLIENTE = @IDCLIENTE, DATAVENDA = @DATAVENDA, USUARIO = @USUARIO, PRECOTOTAL = @PRECOTOTAL, FORMAPAGAMENTO = @FORMAPAGAMENTO, VALORPAGO = @VALORPAGO, TROCO = @TROCO WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", vendaBLL.Idvenda);
            cmd.Parameters.AddWithValue("@IDCLIENTE", vendaBLL.Idcliente);
            cmd.Parameters.AddWithValue("@DATAVENDA", vendaBLL.Datavenda);
            cmd.Parameters.AddWithValue("@USUARIO", vendaBLL.Usuario);
            cmd.Parameters.AddWithValue("@PRECOTOTAL", vendaBLL.Precototal);
            cmd.Parameters.AddWithValue("@FORMAPAGAMENTO", vendaBLL.Formapagamento);
            cmd.Parameters.AddWithValue("@VALORPAGO", vendaBLL.Valorpago);
            cmd.Parameters.AddWithValue("@TROCO", vendaBLL.Troco);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Excluir(JOALHERIABLL.VendaBLL vendaBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.VENDA WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", vendaBLL.Idvenda);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public JOALHERIABLL.VendaBLL RetornarDados(JOALHERIABLL.VendaBLL vendaBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.VENDA WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", vendaBLL.Idvenda);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                vendaBLL.Idvenda = Convert.ToInt16(dr["IDVENDA"]);
                vendaBLL.Idcliente = Convert.ToInt16(dr["IDCLIENTE"]);
                vendaBLL.Datavenda = Convert.ToDateTime(dr["DATAVENDA"]);
                vendaBLL.Usuario = Convert.ToString(dr["USUARIO"]);
                vendaBLL.Precototal = Convert.ToDecimal(dr["PRECOTOTAL"]);
                vendaBLL.Formapagamento = Convert.ToString(dr["FORMAPAGAMENTO"]);
                vendaBLL.Valorpago = Convert.ToDecimal(dr["VALORPAGO"]);
                vendaBLL.Troco = Convert.ToDecimal(dr["TROCO"]);

            }

            dr.Close();
            con.Desconectar();
            return vendaBLL;
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDVENDA, NOME AS CLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO FROM JOALHERIA.CLIENTE JOIN JOALHERIA.VENDA ON JOALHERIA.CLIENTE.IDCLIENTE = JOALHERIA.VENDA.IDCLIENTE", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }  

        public SqlDataAdapter RelatorioVenda()
        {
            con.Desconectar();

            SqlDataAdapter da = new SqlDataAdapter("SELECT IDVENDA, IDCLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO,VALORPAGO,TROCO FROM JOALHERIA.VENDA ORDER BY IDVENDA ASC", con.Conectar());
            return da;
        }

        public SqlDataAdapter RelatorioPorData(string data1, string data2)
        {
            con.Desconectar();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= " + "'" + data1 + " 00:00:01" + "'" + " AND DATAVENDA <= " + "'"+ data2 + " 23:59:59" + "'" + " ORDER BY IDVENDA", con.Conectar());

            return da;
        }

        public SqlDataAdapter RelatorioItensVenda(int id_venda)
        {
            con.Desconectar();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.ITEMPEDIDO WHERE IDVENDA = " +id_venda +";",con.Conectar());

            return da;
        }


        //METODO EXPORTAR TODOS OS REGISTROS DO BANCO
        public void ExportarXml(string caminho)
        {
            List<VendaBLL> result = new List<VendaBLL>();
            int i = 0;

            //criando xml
            XDocument xml = new XDocument(new XDeclaration("1.0","utf-8",null));
            //tag principal
            XElement root = new XElement("movimentoVendaTO");
            root.Add(new XElement("versaoLayoutVenda", "2.0"));

            XElement reg = new XElement("registroVenda");

            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.VENDA ORDER BY IDVENDA",con.Conectar());

            foreach (DataRow rows in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new VendaBLL(rows));

            foreach (VendaBLL venda in result)
            {
                reg.Add(new XElement("idvenda" + i, venda.Idvenda));
                reg.Add(new XElement("idcliente" + i, venda.Idcliente));
                reg.Add(new XElement("datavenda" + i, venda.Datavenda));
                reg.Add(new XElement("usuario" + i, venda.Usuario));
                reg.Add(new XElement("precototal" + i, venda.Precototal));
                reg.Add(new XElement("formapagamento" + i, venda.Formapagamento));
                reg.Add(new XElement("valorpago" + i, venda.Valorpago));
                reg.Add(new XElement("troco" + i, venda.Troco));
                i++;
            }
            root.Add(reg);
            xml.Add(root);
            xml.Save(caminho) ;
        }

        //METODO GERAR UM UNICO XML SELECIONADO
        public void Gerar_Xml_Selecionado(JOALHERIABLL.VendaBLL vendaBLL, string caminho)
        {
            try
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8",null));

                XElement root = new XElement("movimentoVendaTO");
                root.Add(new XElement("versaoLayout", "2.0"));

                XElement reg = new XElement("registroVenda");
                reg.Add(new XElement("idvenda", vendaBLL.Idvenda));
                reg.Add(new XElement("idcliente", vendaBLL.Idcliente));
                reg.Add(new XElement("datavenda", vendaBLL.Datavenda));
                reg.Add(new XElement("usuario", vendaBLL.Usuario));
                reg.Add(new XElement("precototal", vendaBLL.Precototal));
                reg.Add(new XElement("formapagamento", vendaBLL.Formapagamento));
                reg.Add(new XElement("valorpago", vendaBLL.Valorpago));
                reg.Add(new XElement("troco", vendaBLL.Troco));

                root.Add(reg);
                xml.Add(root);
                xml.Save(caminho);
            }
            catch(Exception e)
            {
                Console.WriteLine("Não foi possíve gerar XML: " + e);
            }
        }

        //CONSULTAR POR CODIGO DA VENNDA
        public DataTable ConsultarPorCodigoVenda(JOALHERIABLL.VendaBLL vendaBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDVENDA, NOME AS CLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO FROM JOALHERIA.CLIENTE JOIN JOALHERIA.VENDA ON JOALHERIA.CLIENTE.IDCLIENTE = JOALHERIA.VENDA.IDCLIENTE WHERE IDVENDA = @IDVENDA", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue(@"IDVENDA", vendaBLL.Idvenda);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        //CONSULTAR VENDA POR PERIODO
        public DataTable ConsultarPorPeriodo(string data1, string data2)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDVENDA, NOME AS CLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO FROM JOALHERIA.CLIENTE JOIN JOALHERIA.VENDA ON JOALHERIA.CLIENTE.IDCLIENTE = JOALHERIA.VENDA.IDCLIENTE WHERE DATAVENDA >= " + "'" + data1 + " 00:00:01" + "'" + " AND DATAVENDA <= " + "'" + data2 + " 23:59:59" + "'" + " ORDER BY IDVENDA", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }



    }//
}//
