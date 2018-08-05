using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.nome = Console.ReadLine();
            a.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
