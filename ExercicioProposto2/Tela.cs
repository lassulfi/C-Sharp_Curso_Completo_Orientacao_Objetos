using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using ExercicioProposto2.model;

namespace ExercicioProposto2
{
    class Tela
    {

        //Métodos
        //Mostrar o menu principal
        public static void mostrarMenuPrincipal()
        {
            Console.WriteLine("Sistema de concessionária");
            Console.WriteLine();
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1 - Listar marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastrar carro");
            Console.WriteLine("5 - Cadastrar acessório");
            Console.WriteLine("6 - Monstrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
            Console.WriteLine();
        }

        public static void listarMarcas()
        {
            Console.WriteLine();
            Console.WriteLine("LISTAGEM DE MARCAS");
            for (int i = 0; i < Program.marcas.Count; i++)
            {
                Console.WriteLine(Program.marcas[i]);
            }
        }

        public static void listarCarros()
        {
            Console.WriteLine();
            Console.Write("Digite o código da marca: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(m => m.codigo == codigo);
            if(pos == -1)
            {
                throw new ModelException("Código de marca não encontrado: " + codigo);
            }
            Marca marca = Program.marcas[pos];
            Console.WriteLine("Carros da marca: " + marca.nome);
            List<Carro> c = marca.carros;
            c.Sort();
            for(int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i]);
            }
        }

        //Mostrar tela de cadastro de marcas
        public static void cadastrarMarca()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            Marca m = new Marca(codigo, nome, pais);

            Program.marcas.Add(m);
        }

        public static void cadastrarCarro()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());

            int pos = Program.marcas.FindIndex(m => m.codigo == codMarca);
            if(pos == -1)
            {
                throw new ModelException("Código da marca não encontrado: " + codMarca);
            }

            Console.Write("Código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Carro carro = new Carro(codCarro, modelo, ano, precoBasico, Program.marcas[pos]);
            Program.carros.Add(carro);
            Program.carros.Sort();

            Program.marcas[pos].carros.Add(carro);
            
        }

        //Mostrar tela de cadastro de acessórios
        public static void mostrarTelaCadastroAcessorios()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do acessório: ");
            Console.Write("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(c => c.codigo == codCarro);
            if(pos == -1)
            {
                throw new ModelException("Código do carro não encontrado " + codCarro);
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Acessorio acessorio = new Acessorio(descricao, preco, Program.carros[pos]);
            Program.carros[pos].acessorios.Add(acessorio);
        }

        public static void exibirDetalhesDeUmCarro()
        {
            Console.Write("Digite o código do carro: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(c => c.codigo == codigo);
            if(pos == -1)
            {
                throw new ModelException("Código de carro não encontrado: " + codigo);
            }
            Console.WriteLine(Program.carros[pos]);
        }

        //Mostrar tela de sair do sistema
        public static void mostrarTelaSairDoSistema()
        {
            Console.WriteLine();
            Console.WriteLine("Saindo do sistema. Pressione ENTER para finalizar");
        }

        //Mostrar tela de opcao invalida
        public static void mostrarTelaOpcaoInvalida()
        {
            Console.WriteLine("Opcao inválida");
        }
    }
}
