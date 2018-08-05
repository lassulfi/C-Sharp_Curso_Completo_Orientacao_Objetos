using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Teste struct
            Ponto A;
            A.x = 10;
            A.y = 10;
            Console.WriteLine(A);
            */

            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p;
            //p = (X.a + X.b + X.c) / 2;
            double areaX = X.area();

            //p = (Y.a + Y.b + Y.c) / 2;
            double areaY = Y.area();

            Console.WriteLine("ÁREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            } else if(areaX < areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            } else
            {
                Console.WriteLine("TRIANGULOS DE AREAS IGUAIS");
            }

            Console.ReadLine();
        }
    }
}
