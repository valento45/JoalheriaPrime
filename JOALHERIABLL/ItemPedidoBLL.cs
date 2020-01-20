using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
