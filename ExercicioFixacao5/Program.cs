using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFixacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Quantos alunos possui o curso A? ");
            int numAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < numAlunos; i++)
            {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso B? ");
            numAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < numAlunos; i++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso C? ");
            numAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < numAlunos; i++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> alunos = new HashSet<int>();
            alunos.UnionWith(cursoA);
            alunos.UnionWith(cursoB);
            alunos.UnionWith(cursoC);

            Console.WriteLine("Total de alunos: " + alunos.Count);

            Console.ReadLine();
        }
    }
}
