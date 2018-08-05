using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidadeEmEstoque);

            Produto p = new Produto(nome, preco);

            //Console.WriteLine("Você digitou: " + p.nome + ", " + p.preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + p.quantidadeEmEstoque);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram em estoque: ");
            int entrada = int.Parse(Console.ReadLine());
            //Atualizada a entrada
            p.realizarEntrada(entrada);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que sairam do estoque: ");
            int saida = int.Parse(Console.ReadLine());
            //Atualiza a saida
            p.realizarSaida(saida);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.ReadLine();
        }
    }
}
