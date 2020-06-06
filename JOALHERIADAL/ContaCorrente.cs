using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JOALHERIADAL
{
    public class ContaCorrente
    {
        public int Idconta { get; set; }
        public string Banco { get; set; }
        public string Tipo_conta { get; set; }
        public string Agencia { get; set; }
        public string NrConta { get; set; }
        public string Operacao { get; set; }
        public string Favorecido { get; set; }

        public ContaCorrente() { }
        public ContaCorrente(DataRow dr)
        {
            Idconta = Convert.ToInt32(dr["IDCONTA"]);
            Banco = dr["BANCO"].ToString();
            Tipo_conta = dr["TIPO_CONTA"].ToString();
            Agencia = dr["AGENCIA"].ToString();
            NrConta = dr["NRCONTA"].ToString();
            Operacao = dr["OPERACAO"].ToString();
            Favorecido = dr["FAVORECIDO"].ToString();
        }

        public static void InsertConta(ContaCorrente conta)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO JOALHERIA.CONTA_CORRENTE (BANCO, TIPO_CONTA, AGENCIA, NRCONTA, OPERACAO, FAVORECIDO) VALUES ('{conta.Banco}','{conta.Tipo_conta}','{conta.Agencia}','{conta.NrConta}','{conta.Operacao}','{conta.Favorecido}')");
            Acces.ExecuteNonQuery(cmd);
        }

        public static void DeleteConta(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM JOALHERIA.CONTA_CORRENTE WHERE IDCONTA =" + id);
            Acces.ExecuteNonQuery(cmd);
        }

        public static void UpdateConta(ContaCorrente conta)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE JOALHERIA.CONTA_CORRENTE SET BANCO = '{conta.Banco}', TIPO_CONTA = '{conta.Tipo_conta}', AGENCIA = '{conta.Agencia}', NRCONTA = '{conta.NrConta}', OPERACAO = '{conta.Operacao}', FAVORECIDO = '{conta.Favorecido}' WHERE IDCONTA = '{conta.Idconta}';");
            Acces.ExecuteNonQuery(cmd);
        }

        public static List<ContaCorrente> GetAllContas()
        {
            List<ContaCorrente> result = new List<ContaCorrente>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CONTA_CORRENTE");
            foreach (DataRow conta in Acces.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new ContaCorrente(conta));
            return result;
        }
        
        public static ContaCorrente GetById(int id)
        {
            ContaCorrente result = new ContaCorrente();
            SqlCommand cmd = new SqlCommand("SELECT * FROM JOALHERIA.CONTA_CORRENTE WHERE IDCONTA = "+ id);
            DataTable dt = Acces.ExecuteReader(cmd).Tables[0];
            if (dt.Rows.Count > 0)
                result = new ContaCorrente(dt.Rows[0]);
            return result;
        }
    }
}
