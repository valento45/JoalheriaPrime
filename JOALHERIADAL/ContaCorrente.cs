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
        public string Tipo_Conta { get; set; }
        public string Favorecido { get; set; }
        public string Agencia { get; set; }
        public string Operacao { get; set; }
        public string Conta { get; set; }

        public void Inserir_Conta()
        {
            try
            {
                string query = "INSERT INTO JOALHERIA.CONTA_BANK () VALUES ();";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue(@"tipo_conta", Tipo_Conta);
                cmd.Parameters.AddWithValue(@"favorecido", Favorecido);
                cmd.Parameters.AddWithValue(@"agencia", Agencia);
                cmd.Parameters.AddWithValue(@"operacao", Operacao);
                cmd.Parameters.AddWithValue(@"conta", Conta);
                Acces.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Linha 35, class ContaCorrente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
