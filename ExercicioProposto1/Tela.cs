using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using ExercicioProposto1.model;

namespace ExercicioProposto1
{
    class Tela
    {

        public static void mostrarTela()
        {
            Console.WriteLine("Filmes de Hollywood");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Listar artistas ordenadamente: ");
            Console.WriteLine("2 - Cadastar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair do sistema");
            Console.WriteLine();
            Console.Write("opção: ");
        }

        public static void listarArtistas()
        {
            Console.WriteLine();
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for(int i = 0; i < Program.artistas.Count; i++)
            {
                Console.WriteLine(Program.artistas[i]);
            }
        }

        public static void cadastrarArtista()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Artista a = new Artista(codigo, nome, cache);
            Program.artistas.Add(a);
            Program.artistas.Sort();
        }

        public static void cadastrarFilme()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Filme f = new Filme(codigo, titulo, ano);

            Console.Write("Quantas participações tem o filme? ");
            int numPart = int.Parse(Console.ReadLine());
            for(int i = 0; i < numPart; i++)
            {
                Console.WriteLine("Digite os dados da " + (i + 1) + "ª participação: ");
                Console.Write("Artista (código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(a => a.codigo == codArtista);
                if(pos == -1)
                {
                    throw new ModelException("Artista não encontrado - cód: " + codArtista);
                }
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao p = new Participacao(desconto, Program.artistas[pos], f);
                f.participacoes.Add(p);
            }

            Program.filmes.Add(f);
        }

        public static void exibirDadosFilme()
        {
            Console.WriteLine();
            Console.Write("Digite o código do filme: ");
            int codigoFilme = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(f => f.codigo == codigoFilme);
            if(pos == -1)
            {
                throw new ModelException("Código do filme não encontrado: " + codigoFilme);
            }
            Console.WriteLine(Program.filmes[pos]);
        }

        public static void sairSistema()
        {
            Console.WriteLine("Saindo do sistema. Pressione ENTER para finalizar");
        }

        public static void opcaoInvalida()
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
