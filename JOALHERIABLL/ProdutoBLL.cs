using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class ProdutoBLL
    {
        int idproduto;
        int idcategoria;
        string descricao;
        int quantidade;
        decimal precoimportado;
        decimal precovenda;
        decimal lucro;
        string observacoes;

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

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
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

        public decimal Precoimportado
        {
            get
            {
                return precoimportado;
            }

            set
            {
                precoimportado = value;
            }
        }

        public decimal Precovenda
        {
            get
            {
                return precovenda;
            }

            set
            {
                precovenda = value;
            }
        }

        public decimal Lucro
        {
            get
            {
                return lucro;
            }

            set
            {
                lucro = value;
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
