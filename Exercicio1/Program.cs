using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancia do objeto
            Retangulo ret = new Retangulo();

            //Leitura dos dados
            Console.Write("Informe a largura do retangulo: ");
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a altura do retangulo: ");
            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Apresentacao dos resultados
            Console.WriteLine("AREA = " + ret.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            
        }
    }
}
