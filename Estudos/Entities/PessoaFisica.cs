using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Entities
{
    public class PessoaFisica : Pessoa
    {
        public double Gastos_Saude { get; set; }

        public override double Imposto()
        {
            return (base.Renda_Anual * 0.25) - (Gastos_Saude * 0.50);
        }

        public double SubTotal()
        {
            double x = 0;
            x += Imposto();
            return x;
        }
        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double renda_anual, double gastos_Saude)
            : base(nome, renda_anual)
        {
            Gastos_Saude = gastos_Saude;
        }

        public override string Fisic()
        {
            return "\nNome: " + Nome.ToString()
                + "\n Renda:" + Renda_Anual.ToString()
                + "\n Gasto Saude: " + Gastos_Saude.ToString()
                + "\n Imposto :" + Imposto().ToString();
        }
    }
}
