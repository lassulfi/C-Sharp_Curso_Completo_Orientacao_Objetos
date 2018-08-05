using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao04
{
    class Funcionario
    {
        public int cpf { get; set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionario(int cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentarSalario(double porcentagem)
        {
            salario *= (1 + porcentagem / 100);
        }

        public override string ToString()
        {
            return cpf + ", " + nome + ", " +salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
