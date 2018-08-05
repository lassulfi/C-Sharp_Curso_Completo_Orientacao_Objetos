using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioProposto1.model
{
    class Participacao
    {
        //Atributos
        public double desconto { get; set; }
        
        public Artista artista { get; set; }

        public Filme filme { get; set; }

        //Construtor
        public Participacao(double desconto, Artista artista, Filme filme)
        {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        //Método custo
        public double custo()
        {
            return artista.cache - desconto;
        }

        public override string ToString()
        {
            return artista.nome
                    + ", Cachê: " + artista.cache.ToString("F2", CultureInfo.InvariantCulture)
                    +", Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Custo: " + custo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
