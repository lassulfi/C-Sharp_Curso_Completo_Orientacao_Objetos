﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExercicioResolvido
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        
        public Produto produto { get; set; }

        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto, Pedido pedido)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.produto = produto;
            this.pedido = pedido;
        }

        public double subTotal()
        {
            double desconto = produto.preco * porcentagemDesconto / 100;

            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.descricao
                    + ", Preço: " + produto.preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Qte: " + quantidade 
                    + ", Desconto: " + porcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture) + "% " 
                    + ", Subtotal: " + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
