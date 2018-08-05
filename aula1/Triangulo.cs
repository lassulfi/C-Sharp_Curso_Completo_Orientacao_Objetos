using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aula1
{
    class Triangulo
    {

        public double a, b, c;

        public double area()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
