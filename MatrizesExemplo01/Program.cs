using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrizesExemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;

            int n = int.Parse(Console.ReadLine());

            mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("QUANTIDADE DE NÚMEROS NEGATIVOS: ");
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i , j] < 0)
                    {
                        sum++;
                    }
                }
            }
            Console.Write(sum);

            Console.ReadLine();
        }
    }
}
