using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class CaixaBLL
    {
        int idcaixa;
        string identificacao_caixa;
        string descricao;
        string observacoes;


        public int Idcaixa
        {
            get
            {
                return idcaixa;
            }

            set
            {
                idcaixa = value;
            }
        }

        public string Identificacao_caixa
        {
            get
            {
                return identificacao_caixa;
            }

            set
            {
                identificacao_caixa = value;
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

        public string Observacoes
        {
            get
            {
                return observacoes;
            }

            set
            {
                observacoes = value;
            }
        }
    }
}
