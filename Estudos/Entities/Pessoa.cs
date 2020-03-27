using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public double Renda_Anual { get; set; }

        public abstract double Imposto();

        public Pessoa() { }

        protected Pessoa(string nome, double renda_Anual)
        {
            Nome = nome;
            Renda_Anual = renda_Anual;
        }

        public virtual string Fisic()
        {
            return "\nNome: " + Nome.ToString()
                + "\n Renda: " + Renda_Anual.ToString()                
                + "\n Imposto" + Imposto().ToString();
        }
    }
}
