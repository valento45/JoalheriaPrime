using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JOALHERIABLL
{
    public class ServicoBLL
    {
        int idservico;
        string descricao;
        decimal valor_servico;

        public ServicoBLL(DataRow dr)
        {
            Idservico = Convert.ToInt32(dr["IDSERVICO"]);
            Descricao = dr["DESCRICAO"].ToString();
            Valor_servico = Convert.ToDecimal(dr["PRECO_UNITARIO"]);
        }

        public ServicoBLL()
        {

        }

        public int Idservico
        {
            get
            {
                return idservico;
            }

            set
            {
                idservico = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public decimal Valor_servico
        {
            get
            {
                return valor_servico;
            }

            set
            {
                valor_servico = value;
            }
        }
    }
}
