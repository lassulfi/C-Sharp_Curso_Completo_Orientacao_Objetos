using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFixacao02
{
    class Quarto
    {
        //Atributos
        string nome { get; set; }
        string email { get; set; }
        int numQuarto { get; set; }

        //Construtor
        public Quarto(string nome, string email, int quarto)
        {
            this.nome = nome;
            this.email = email;
            this.numQuarto = quarto;
        }

        public override string ToString()
        {
            string dados = numQuarto + ": " + nome + ", " + email;
            return dados;
        }
    }
}
