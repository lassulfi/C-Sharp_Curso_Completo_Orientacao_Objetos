using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExercicioProposto2.model;

namespace ExercicioProposto2
{
    class Program
    {

        public static List<Carro> carros = new List<Carro>();

        public static List<Marca> marcas = new List<Marca>();

        static void Main(string[] args)
        {

            //Cadastro de marcas
            marcas.Add(new Marca(1001, "Volkswagen", "Alemanha"));
            marcas.Add(new Marca(1002, "General Motors", "Estados Unidos"));

            //Cadastro de carros
            carros.Add(new Carro(101, "Fusca", 1980, 5000.00, marcas[0]));
            carros.Add(new Carro(102, "Golf", 2016, 60000.00, marcas[0]));
            carros.Add(new Carro(103, "Fox", 2017, 30000.00, marcas[0]));

            carros.Add(new Carro(104, "Cruze", 2016, 30000.00, marcas[1]));
            carros.Add(new Carro(105, "Cobalt", 2015, 25000.00, marcas[1]));
            carros.Add(new Carro(106, "Cobalt", 2017, 25000.00, marcas[1]));

            //Associacao dos carros as marcas
            marcas[0].carros.Add(carros[0]);
            marcas[0].carros.Add(carros[1]);
            marcas[0].carros.Add(carros[2]);

            marcas[1].carros.Add(carros[3]);
            marcas[1].carros.Add(carros[4]);
            marcas[1].carros.Add(carros[5]);

            //Ordenação da lista de carros
            carros.Sort();

            //Carrega o menu principal
            int opcao = 0;
            while(opcao != 7)
            {
                Console.Clear();
                Tela.mostrarMenuPrincipal();
                Console.Write("Opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Tela.listarMarcas();
                        break;
                    case 2:
                        try
                        {
                            Tela.listarCarros();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Tela.cadastrarMarca();
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Tela.cadastrarCarro();
                        } catch(ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            Tela.mostrarTelaCadastroAcessorios();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        
                        break;
                    case 6:
                        try
                        {
                            Tela.exibirDetalhesDeUmCarro();
                        } catch(ModelException e)
                        {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        } catch(Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 7:
                        Tela.mostrarTelaSairDoSistema();
                        break;
                    default:
                        Tela.mostrarTelaOpcaoInvalida();
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
