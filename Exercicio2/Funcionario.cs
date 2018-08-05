using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio2
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        } 

        public void aumentarSalario(double porcentagem)
        {
            double aumento = salarioBruto * porcentagem / 100;

            salarioBruto += aumento;
        }

        public override string ToString()
        {
            return nome + ", R$ " + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
