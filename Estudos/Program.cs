using Estudos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Hotel.Entities.Exceptions;
using Estudos.Banco.Entities;
namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o tipo de sistema (Banco/Hotel/Empresa): ");
                string menu = Console.ReadLine();

                if (menu.ToLower() != "hotel" && menu.ToLower() != "empresa" && menu.ToLower() != "banco")
                    throw new DomainException("Digite um sistema disponível válido!");

                switch (menu.ToUpper())
                {
                    case "HOTEL":
                        Hotel();
                        break;
                    case "EMPRESA":
                        Empresa();
                        break;
                    case "BANCO":
                        Banco();
                        break;
                }
            }
            catch (DomainException e)
            {
                Console.Write("System Exception: " + e.Message);
                Console.Read();
            }
        }
        private static void Empresa()
        {
            List<Pessoa> result = new List<Pessoa>();
            double total = 0;
            try
            {
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
                } while (i < n);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error ! \n\r Divisão por zero !");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de caractere inválido !");
            }

            foreach (var x in result)
                total += x.Renda_Anual;

            Console.WriteLine();
            Console.Write("Pessoas: ");
            foreach (Pessoa pessoa in result)
            {
                Console.WriteLine(pessoa.Fisic());
            }
            Console.WriteLine("Total de imposto arrecadado: " + total.ToString());
            Console.Read();

        }
        private static void Banco()
        {
            bool retry = true;

            try
            {
                Account account;
                double moviment = 0;

                Console.Write("Account of number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder | Name: ");
                string name = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdraw = double.Parse(Console.ReadLine());

                account = new Account(number, name, balance, withdraw);
                do
                {
                    Console.Write("\nEnter the withdrawal or deposit operation (w/d)");
                    char operacao = char.Parse(Console.ReadLine());

                    if (operacao != 'w' && operacao != 'd')
                        throw new DomainException("Invalid Operation");

                    if (operacao.Equals('d'))
                    {
                        Console.Write("\nEnter the value for Deposit: ");
                        double value = double.Parse(Console.ReadLine());
                        moviment = value;
                        account.Deposit(value);
                    }
                    else
                    {
                        Console.Write("\nEnter the value for Withdraw: ");
                        double value = double.Parse(Console.ReadLine());
                        moviment = value;
                        account.Withdraw(value);
                    }

                    Console.WriteLine();
                    Console.Write("\nAccount: "
                        + account.Number
                        + "\nName: "
                        + account.Holder
                        + "\nBalance Actually: "
                        + account.Balance
                        + "\n"
                        + (operacao.Equals('d') ? $"Deposit Value: { moviment }" : $"Withdraw Value: { moviment }"));

                    Console.Write("Deseja realizar outra operação ? (s/n)");
                    char cont = char.Parse(Console.ReadLine());

                    retry = cont.Equals('s') ? true : false;
                } while (retry);
            }
            catch (DomainException e)
            {
                Console.Write("Domain Exception \n\r\n\r Detalhamento: " + e.Message + "\nA Operação foi finalizada!");
            }
            catch (FormatException e)
            {
                Console.Write("Format Exception \n\r\n\r Detalhamento: " + e.Message + "\nA Operação foi finalizada!");
            }
            catch (Exception e)
            {
                Console.Write("Exception \n\r\n\r Detalhamento: " + e.Message +"\nA Operação foi finalizada!");
            }
            Console.Read();

        }
        private static void Hotel()
        {
            try
            {
                int a;
                int b;

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}
