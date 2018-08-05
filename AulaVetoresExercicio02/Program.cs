using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace AulaVetoresExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vet;
            vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            double soma, media;
            soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].preco;
            }
            media = soma / n;

            Console.WriteLine("PRECO MEDIO: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
