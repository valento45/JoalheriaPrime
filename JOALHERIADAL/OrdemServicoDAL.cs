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
    public class OrdemServicoDAL
    {
        Conexao con = new Conexao();

        public int Cadastrar(JOALHERIABLL.OrdemServicoBLL ordemservicoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO JOALHERIA.ORDEMSERVICO (IDCLIENTE, DATAATUAL, DATAENTREGA, DESCONTO, VALOR_TOTAL, FORMA_PAGAMENTO, VALOR_PAGO, TROCO, IDUSUARIO) VALUES (@IDCLIENTE, @DATAATUAL, @DATAENTREGA, @DESCONTO, @VALOR_TOTAL, @FORMA_PAGAMENTO, @VALOR_PAGO, @TROCO, @IDUSUARIO);SELECT SCOPE_IDENTITY();", con.Conectar());
            cmd.Parameters.AddWithValue(@"IDCLIENTE", ordemservicoBLL.Idcliente);
            cmd.Parameters.AddWithValue(@"DATAATUAL", ordemservicoBLL.Dataatual);
            cmd.Parameters.AddWithValue(@"DATAENTREGA", ordemservicoBLL.Dataentrega);
            cmd.Parameters.AddWithValue(@"DESCONTO", ordemservicoBLL.Desconto);
            cmd.Parameters.AddWithValue(@"VALOR_TOTAL", ordemservicoBLL.Valor_total);
            cmd.Parameters.AddWithValue(@"FORMA_PAGAMENTO", ordemservicoBLL.Forma_pagamento);
            cmd.Parameters.AddWithValue(@"VALOR_PAGO", ordemservicoBLL.Valor_pago);
            cmd.Parameters.AddWithValue(@"TROCO", ordemservicoBLL.Troco);
            cmd.Parameters.AddWithValue(@"IDUSUARIO", ordemservicoBLL.Idusuario);

            int chave_gerada = 0;
            chave_gerada = Convert.ToInt16(cmd.ExecuteScalar());
            con.Desconectar();
            return chave_gerada;
        }

        public void Alterar(JOALHERIABLL.OrdemServicoBLL ordemservicoBLL)
        {
            SqlCommand cmd = new SqlCommand("UPDATE JOALHERIA.ORDEMSERVICO SET IDCLIENTE = @IDCLIENTE, DATAATUAL = @DATAATUAL, DATAENTREGA = @DATAENTREGA, DESCONTO = @DESCONTO, VALOR_TOTAL = @VALOR_TOTAL, FORMA_PAGAMENTO = @FORMA_PAGAMENTO, VALOR_PAGO = @VALOR_PAGO, TROCO = @TROCO, IDUSUARIO = @IDUSUARIO WHERE IDORDEM = @IDORDEM",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDORDEM", ordemservicoBLL.Idordem);
            cmd.Parameters.AddWithValue(@"IDCLIENTE", ordemservicoBLL.Idcliente);
            cmd.Parameters.AddWithValue(@"DATAATUAL", ordemservicoBLL.Dataatual);
            cmd.Parameters.AddWithValue(@"DATAENTREGA", ordemservicoBLL.Dataentrega);
            cmd.Parameters.AddWithValue(@"DESCONTO", ordemservicoBLL.Desconto);
            cmd.Parameters.AddWithValue(@"VALOR_TOTAL", ordemservicoBLL.Valor_total);
            cmd.Parameters.AddWithValue(@"FORMA_PAGAMENTO", ordemservicoBLL.Forma_pagamento);
            cmd.Parameters.AddWithValue(@"VALOR_PAGO", ordemservicoBLL.Valor_pago);
            cmd.Parameters.AddWithValue(@"TROCO", ordemservicoBLL.Troco);
            cmd.Parameters.AddWithValue(@"IDUSUARIO", ordemservicoBLL.Idusuario);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JOALHERIA.ORDEMSERVICO",con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        // FAZER EXCLUIR, RETORNARDADOS, CONSULTAR COM FILTROS, GERAR XML, E RELATORIOS E TUDO MAIS Q EU APRENDI

        public JOALHERIABLL.OrdemServicoBLL RetornarDados(JOALHERIABLL.OrdemServicoBLL ordemservicoBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.ORDEMSERVICO WHERE IDORDEM = @IDORDEM",con.Conectar());
            cmd.Parameters.AddWithValue(@"IDORDEM", ordemservicoBLL.Idordem);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ordemservicoBLL.Idordem = Convert.ToInt32(dr["IDORDEM"]);
                ordemservicoBLL.Idcliente = Convert.ToInt32(dr["IDCLIENTE"]);
                ordemservicoBLL.Dataatual = Convert.ToDateTime(dr["DATAATUAL"]);
                ordemservicoBLL.Dataentrega = Convert.ToDateTime(dr["DATAENTREGA"]);
                ordemservicoBLL.Desconto = Convert.ToDecimal(dr["DESCONTO"]);
                ordemservicoBLL.Valor_total = Convert.ToDecimal(dr["VALOR_TOTAL"]);
                ordemservicoBLL.Forma_pagamento = dr["FORMA_PAGAMENTO"].ToString();
                ordemservicoBLL.Valor_pago = Convert.ToDecimal(dr["VALOR_PAGO"]);
                ordemservicoBLL.Troco = Convert.ToDecimal(dr["TROCO"]);
                ordemservicoBLL.Idusuario = Convert.ToInt32(dr["IDUSUARIO"]);
            }
            dr.Close();
            con.Desconectar();
            return ordemservicoBLL;

        }
    }//
}//
