using Estudos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> result = new List<Pessoa>();
            double total = 0;

            Console.WriteLine();
            Console.Write("Digite o número de impostos");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                Console.Write("People Fisic or People Juridic (f/j) ? \n");
                char pessoa = char.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string name = Console.ReadLine();
                Console.Write("Faturamente Anual: \n");
                double faturamento_anual = double.Parse(Console.ReadLine());
                if (pessoa == 'j')
                {
                    Console.Write("Digite a quantidade de funcionários: \n");
                    int funcionarios = int.Parse(Console.ReadLine());
                    result.Add(new PessoaJuridica(name, faturamento_anual, funcionarios));
                }
                if (pessoa == 'f')
                {
                    Console.Write("Digite o valor gasto com a saúde: \n");
                    double saude = double.Parse(Console.ReadLine());
                    result.Add(new PessoaFisica(name, faturamento_anual, saude));
                }
                i++;
            } while(i < n);
            foreach ( var x in result)                          
                total += x.Renda_Anual;


            Console.WriteLine();
            Console.Write("Pessoas: ");
            foreach( Pessoa pessoa in result)
            {
                Console.WriteLine(pessoa.Fisic());                
            }
            Console.WriteLine("Total de imposto arrecadado: " + total.ToString());
            Console.Read();
        }
    }
}
