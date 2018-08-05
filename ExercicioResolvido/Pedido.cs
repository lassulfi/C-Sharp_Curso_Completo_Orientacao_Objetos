using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioResolvido
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal()
        {
            double soma = 0.0;
            foreach(ItemPedido i in itens)
            {
                soma += i.subTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            String s = "Pedido: " + codigo 
                        + ", Data: " + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                        + "Itens: \n";
            foreach(ItemPedido i in itens)
            {
                s += i + "\n";
            }

            s += "Total do pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);

            return s;
        }
    }
}
