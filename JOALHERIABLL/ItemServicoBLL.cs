using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class ItemServicoBLL
    {
        int iditem;
        int idordem;
        int idservico;
        decimal valor_servico;
        int quantidade_pedido;
        
        public int Iditem
        {
            get
            {
                return iditem;
            }

            set
            {
                iditem = value;
            }
        }

        public int Idordem
        {
            get
            {
                return idordem;
            }

            set
            {
                idordem = value;
            }
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

        public int Quantidade_pedido
        {
            get
            {
                return quantidade_pedido;
            }

            set
            {
                quantidade_pedido = value;
            }
        }


        public string descricao_produto { get; set; }

    }
}
