using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioProposto1.model
{
    class Filme
    {
        //Atributos
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }

        public List<Participacao> participacoes { get; set; }

        //Construtor
        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.participacoes = new List<Participacao>();
        }

        //Método custo total
        public double custoTotal()
        {
            double custo = 0.0;
            for(int i = 0; i < participacoes.Count; i++)
            {
                custo += participacoes[i].custo();
            }

            return custo;
        }

        public override string ToString()
        {
            String s = "Filme " + codigo
                    + ", Titulo: " + titulo
                    + ", Ano: " + ano + "\nParticipações: \n";
            foreach(Participacao p in participacoes)
            {
                s += p + "\n";
            }
            s += "Custo total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture); 
            return s;
        }
    }
}
