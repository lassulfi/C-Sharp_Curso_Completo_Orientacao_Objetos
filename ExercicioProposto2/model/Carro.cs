using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioProposto2.model
{
    class Carro : IComparable
    {
        //Atributos
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }

        public Marca marca { get; set; }

        public List<Acessorio> acessorios;

        //Construtor
        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;

            acessorios = new List<Acessorio>();
        }

        //Métodos

        //Calcula o preco total de um veiculo
        public double precoTotal()
        {

            double precoAcessorios = 0.0;
            for(int i = 0; i < acessorios.Count; i++)
            {
                precoAcessorios += acessorios[i].preco;
            }

            return precoBasico + precoAcessorios;
        }

        public override string ToString()
        {
            String s = codigo
                        + ", " + modelo
                        + ", Ano: " + ano
                        + ", Preço basico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                        + ", Preço total: " + precoTotal().ToString("F2", CultureInfo.InvariantCulture);

            if(acessorios.Count > 0)
            {
                s += "\n Acessórios: ";

                for (int i = 0; i < acessorios.Count; i++)
                {
                    s += acessorios[i];
                }
            }

            
            return s;
        }

        public int CompareTo(object obj)
        {
            Carro c = (Carro)obj;

            int resultado = modelo.CompareTo(c.modelo);
            if(resultado != 0)
            {
                return resultado;
            } else
            {
                return -precoBasico.CompareTo(c.precoBasico);
            }

        }
    }
}
