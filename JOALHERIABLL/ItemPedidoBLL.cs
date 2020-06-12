using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace JOALHERIABLL
{
    public class ItemPedidoBLL
    {

        int iditempedido;
        int idvenda;
        int idproduto;
        decimal precounitario;
        int quantidade;
        decimal desconto;
        


        public ItemPedidoBLL()
        {

        }

        public ItemPedidoBLL(DataRow dr)
        {
            iditempedido = Convert.ToInt32(dr["IDITEMPEDIDO"]);
            idvenda = Convert.ToInt32(dr["IDVENDA"]);
            idproduto = Convert.ToInt32(dr["IDPRODUTO"]);
            precounitario = Convert.ToDecimal(dr["PRECOUNITARIO"]);
            quantidade = Convert.ToInt32(dr["QUANTIDADEPEDIDO"]);
            desconto = Convert.ToDecimal(dr["DESCONTO"]);
        }


        public int Iditempedido
        {
            get
            {
                return iditempedido;
            }

            set
            {
                iditempedido = value;
            }
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

        public int Idproduto
        {
            get
            {
                return idproduto;
            }

            set
            {
                idproduto = value;
            }
        }

        public decimal Precounitario
        {
            get
            {
                return precounitario;
            }

            set
            {
                precounitario = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
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

       
    }
}
