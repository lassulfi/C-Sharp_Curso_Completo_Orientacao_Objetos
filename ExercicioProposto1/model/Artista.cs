using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioProposto1.model
{
    class Artista : IComparable
    {
        //Atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        //Construtor
        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString()
        {
            return codigo
                    + ", " + nome
                    + ", Cachê: " + cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Artista a = (Artista)obj;

            return nome.CompareTo(a.nome);
        }
    }
}
