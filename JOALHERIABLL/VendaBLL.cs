using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class VendaBLL
    {
        int idvenda;
        int idcliente;
        DateTime datavenda;
        String usuario;
        decimal precototal;
        string formapagamento;
        decimal valorpago;
        decimal troco;

        public int Idvenda
        {
            get
            {
                return idvenda;
            }

            set
            {
                idvenda = value;
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

        public DateTime Datavenda
        {
            get
            {
                return datavenda;
            }

            set
            {
                datavenda = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public decimal Precototal
        {
            get
            {
                return precototal;
            }

            set
            {
                precototal = value;
            }
        }

        public string Formapagamento
        {
            get
            {
                return formapagamento;
            }

            set
            {
                formapagamento = value;
            }
        }

        public decimal Valorpago
        {
            get
            {
                return valorpago;
            }

            set
            {
                valorpago = value;
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
    }
}
