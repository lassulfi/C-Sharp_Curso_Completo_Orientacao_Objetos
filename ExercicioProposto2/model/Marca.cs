using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioProposto2.model
{
    class Marca
    {
        //Atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }

        public List<Carro> carros;

        //Construtor
        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;

            this.carros = new List<Carro>();
        }

        public override string ToString()
        {
            return codigo
                    + ", " + nome
                    + ", País: " + pais
                    + ", Número de carros: " + carros.Count;
        }
    }
}
