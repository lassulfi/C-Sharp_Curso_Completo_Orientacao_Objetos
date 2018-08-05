using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão cadastrados? ");
            int numFunc = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for(int i = 0; i < numFunc; i++)
            {
                Console.WriteLine("Dados do " + (i + 1) + "° funcionario");
                Console.Write("CPF: ");
                int cpf = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(cpf, nome, salario));
            }

            Console.Write("Informe o CPF do funcionário que receberá aumento: ");
            int cpfFunc = int.Parse(Console.ReadLine());

            int pos = funcionarios.FindIndex(func => func.cpf == cpfFunc);
            if (pos >= 0)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios[pos].aumentarSalario(aumento);
            } else
            {
                Console.WriteLine("CPF INEXISTENTE");
            }

            Console.WriteLine("Listagem atualizada de funcionários: ");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
