using System;
using System.Collections.Generic;
using System.Data;
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

        public VendaBLL() { }
        public VendaBLL(DataRow dr)
        {
            Idvenda = Convert.ToInt32(dr["IDVENDA"]);
            Idcliente = Convert.ToInt32(dr["IDCLIENTE"]);
            Datavenda = Convert.ToDateTime(dr["DATAVENDA"]);
            Usuario = dr["USUARIO"].ToString();
            Precototal = Convert.ToDecimal(dr["PRECOTOTAL"]);
            Formapagamento = dr["FORMAPAGAMENTO"].ToString();
            Valorpago = Convert.ToDecimal(dr["VALORPAGO"]);
            Troco = Convert.ToDecimal(dr["TROCO"]);
        }

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
