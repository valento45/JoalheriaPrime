using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int Quantidade_Funcionarios { get; set; }
        public override double Imposto()
        {
            if (Quantidade_Funcionarios > 10)
                return (Renda_Anual * 0.14);
            else
                return (Renda_Anual * 0.16);
        }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double renda_anual, int quantidade_func)
            : base(nome, renda_anual)
        {
            Quantidade_Funcionarios = quantidade_func;
        }


        public override string Fisic()
        {
            return "\nNome: " + Nome.ToString()
                + "\n Renda Anual: " + Renda_Anual.ToString()
                + "\n Nro Funcionarios: " + Quantidade_Funcionarios.ToString()
                + "\n Imposto: " + Imposto().ToString();
        }
    }
}

