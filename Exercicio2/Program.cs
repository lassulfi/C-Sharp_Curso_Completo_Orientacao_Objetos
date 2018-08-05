using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            f.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + f);

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.aumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + f);

            Console.ReadLine();
        }
    }
}
