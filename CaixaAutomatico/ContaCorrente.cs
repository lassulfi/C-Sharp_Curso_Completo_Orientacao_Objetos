using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CaixaAutomatico
{
    class ContaCorrente
    {
        //Atributos
        public int numConta { get; private set; }
        public string nomeTitular { get; set; }
        public double saldo { get; private set; }

        //Construtor
        public ContaCorrente(int num, string nome)
        {
            this.numConta = num;
            this.nomeTitular = nome;
            this.saldo = 0;
        }

        //métodos
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            double taxa = 5.00;
            this.saldo -= (valor + taxa);
        }

        public override string ToString()
        {
            return "Conta " 
                    + numConta 
                    + ", Titular: "
                    + nomeTitular 
                    + ", Saldo: $ " + 
                    saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
