using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

//Exercicio de fixacao 1
namespace CaixaAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura dos dados
            Console.Write("Digite o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string opcao = Console.ReadLine();

            //Instancia do objeto da conta corrente
            ContaCorrente c1 = new ContaCorrente(numConta, nomeTitular);

            //Tratamento da variavel opcao
            if (opcao == "s")
            {
                Console.Write("Digite o valor do deposito inicial: ");
                c1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Conta criada: ");
            Console.WriteLine(c1);

            Console.Write("Digite um valor para deposito: ");
            c1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(c1);

            Console.Write("Digite um valor para saque: ");
            c1.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
