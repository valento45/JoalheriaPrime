using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class OrdemServicoBLL
    {
        int idordem;
        int idcliente;
        DateTime dataatual;
        DateTime dataentrega;
        decimal desconto;
        decimal valor_total;
        string forma_pagamento;
        decimal valor_pago;
        decimal troco;
        int idusuario;

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

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public DateTime Dataatual
        {
            get
            {
                return dataatual;
            }

            set
            {
                dataatual = value;
            }
        }

        public DateTime Dataentrega
        {
            get
            {
                return dataentrega;
            }

            set
            {
                dataentrega = value;
            }
        }

        public decimal Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
            }
        }

        public decimal Valor_total
        {
            get
            {
                return valor_total;
            }

            set
            {
                valor_total = value;
            }
        }

        public string Forma_pagamento
        {
            get
            {
                return forma_pagamento;
            }

            set
            {
                forma_pagamento = value;
            }
        }

        public decimal Valor_pago
        {
            get
            {
                return valor_pago;
            }

            set
            {
                valor_pago = value;
            }
        }

        public decimal Troco
        {
            get
            {
                return troco;
            }

            set
            {
                troco = value;
            }
        }

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }
    }
}
