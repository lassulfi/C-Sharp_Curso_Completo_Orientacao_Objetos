using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExercicioProposto1.model;

namespace ExercicioProposto1
{
    class Program
    {

        //Atributos
        public static List<Artista> artistas = new List<Artista>();

        public static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args)
        {
            //Cadastro de artistas
            artistas.Add(new Artista(101, "Scarllet Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));

            //Ordena a lista
            artistas.Sort();

            int opcao = 0;
            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarTela();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                } catch(Exception e)
                {
                    Console.WriteLine("Erro inesperado " + e.Message);
                }
                switch (opcao)
                {
                    case 1:
                        Tela.listarArtistas();
                        break;
                    case 2:
                        try
                        {
                            Tela.cadastrarArtista();
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Tela.cadastrarFilme();
                        } catch(ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Tela.exibirDadosFilme();
                        } catch(ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 5:
                        Tela.sairSistema();
                        break;
                    default:
                        Tela.opcaoInvalida();
                        break;
                }
                Console.ReadLine();
            }


        }
    }
}
