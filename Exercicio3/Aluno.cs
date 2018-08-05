using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio3
{
    class Aluno
    {

        public string nome;
        public double n1, n2, n3;

        public double notaFinal()
        {
            return n1 + n2 + n3;
        }

        public string status()
        {
            if(notaFinal() > 60)
            {
                return "\nAPROVADO";
            } else
            {
                double falta = 60 - notaFinal();
                return "\nREPROVADO \nFALTAM " 
                        + falta.ToString("F2", CultureInfo.InvariantCulture) 
                        + " PONTOS";
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL: " + notaFinal().ToString("F2", CultureInfo.InvariantCulture) + status();
        }

    }
}
