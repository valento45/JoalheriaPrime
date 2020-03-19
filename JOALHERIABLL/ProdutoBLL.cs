using System;
using System.Collections.Generic;
using System.Data;
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
        string imagem;

        public string Imagem
        {
            get
            {
                return imagem;
            }
            set
            {
                imagem = value;
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

        public ProdutoBLL(DataRow dr)
        {
            Idproduto = Convert.ToInt16(dr["IDPRODUTO"]);
            Idcategoria = Convert.ToInt16(dr["IDCATEGORIA"]);
            Descricao = Convert.ToString(dr["DESCRICAO"]);
            Quantidade = Convert.ToInt16(dr["QUANTIDADE"]);
            Precoimportado = Convert.ToDecimal(dr["PRECOIMPORTADO"]);
            Precovenda = Convert.ToDecimal(dr["PRECOVENDA"]);
            Lucro = Convert.ToDecimal(dr["LUCRO"]);
            Observacoes = Convert.ToString(dr["OBSERVACOES"]);
            Imagem = dr["IMAGEM"].ToString();
        }

        public ProdutoBLL()
        {

        }
    }
}
