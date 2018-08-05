﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioResolvido
{
    /*
     * Classe responsável por conter operacoes que interagem com o usuario
     * no modo console
     */
    class Tela
    {
        public static void mostrarMenu()
        {
            
            Console.WriteLine();

            Console.WriteLine("1 -  Listar produtos ordenadamente");
            Console.WriteLine("2 -  Cadastrar produto");
            Console.WriteLine("3 -  Cadastrar pedido");
            Console.WriteLine("4 -  Mostrar dados de um pedido");
            Console.WriteLine("5 -  Sair");
            Console.WriteLine();
            Console.Write("Selecione uma operação: ");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for(int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Cadastar o produto
            Program.produtos.Add(new Produto(codigo, descricao, preco));
            //Ordena a lista
            Program.produtos.Sort();
        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.WriteLine();
            Console.Write("Quantos itens tem o pedido: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os dados do " + (i + 1) + "° item: ");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if(pos == -1)
                {
                    throw new ModelException("Código de produto não encontrado " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qtde = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(qtde, porcent, Program.produtos[pos], p);
                p.itens.Add(ip);
            }
            Program.pedidos.Add(p);
        }

        public static void mostrarPedido()
        {
            Console.WriteLine();
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(p => p.codigo == codPedido);
            if(pos == -1)
            {
                throw new ModelException("Código de pedido não encontrado " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
        }
    }
}
