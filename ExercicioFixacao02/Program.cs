using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos alugueis serão registrados? ");
            int numAlugueis = int.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[10];

            for(int i = 0; i <numAlugueis; i++)
            {
                Console.WriteLine("Dados do " + (i + 1) + " aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                quartos[i] = new Quarto(nome, email, numero);
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < numAlugueis; i++)
            {
                Console.WriteLine(quartos[i]);
            }

            Console.ReadLine();
        }
    }
}
