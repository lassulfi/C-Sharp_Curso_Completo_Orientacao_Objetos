using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace AulaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet;
            vet = new double[n];

            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma, media;
            soma = 0;
            for(int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            media = soma / n;

            Console.WriteLine("ALTURA MEDIA: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
