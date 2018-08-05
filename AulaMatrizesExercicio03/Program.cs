using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaMatrizesExercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensoes = Console.ReadLine().Split(' ');
            int m = int.Parse(dimensoes[0]);
            int n = int.Parse(dimensoes[1]);

            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            int numLinha = 0, numColuna = 0;
            bool encontrou = false;
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(x == matriz[i, j])
                    {
                        numLinha = i;
                        numColuna = j;
                        encontrou = true;
                        break;
                    }
                }
            }

            if (encontrou)
            {
                if(numColuna > 0)
                {
                    Console.WriteLine("ESQUERDA: " + matriz[numLinha, numColuna - 1]); 
                }
                if(numColuna < n - 1)
                {
                    Console.WriteLine("DIREITA: " + matriz[numLinha, numColuna + 1]);
                }
                if(numLinha > 0)
                {
                    Console.WriteLine("ACIMA: " + matriz[numLinha - 1, numColuna]);
                }
                if(numLinha < m - 1)
                {
                    Console.WriteLine("ABAIXO: " + matriz[numLinha + 1, numColuna]);
                }
            } else
            {
                Console.WriteLine("NUMERO NAO ENCONTRADO");
            }

            Console.ReadLine();

        }
    }
}
