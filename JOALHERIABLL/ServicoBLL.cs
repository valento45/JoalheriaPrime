using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class ServicoBLL
    {
        int idservico;
        string descricao;
        decimal valor_servico;

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
