﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioProposto2.model
{
    class Acessorio
    {
        //Atributos
        public string nome { get; set; }
        public double preco { get; set; }

        public Carro carro { get; set; }

        //Construtor
        public Acessorio(string nome, double preco, Carro carro)
        {
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return nome + ", Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
