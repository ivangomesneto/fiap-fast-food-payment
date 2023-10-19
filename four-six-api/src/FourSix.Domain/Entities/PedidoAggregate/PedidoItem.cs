﻿namespace FourSix.Domain.Entities.PedidoAggregate
{
    public class PedidoItem
    {
        public PedidoItem() { }
        public PedidoItem(Guid pedidoId, Guid ItemPedidoId, decimal valorUnitario, int quantidade, string? observacao)
        {
            PedidoId = pedidoId;
            ItemPedidoId = ItemPedidoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            Observacao = observacao;
        }

        public Guid PedidoId { get; }
        public Guid ItemPedidoId { get; }
        public decimal ValorUnitario { get; }
        public int Quantidade { get; private set; }
        public string? Observacao { get; }
        public Produto ItemPedido { get; set; }


        public void AdicionarQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }
    }
}
