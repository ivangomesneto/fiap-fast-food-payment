﻿using FourSix.Domain.Entities.PedidoAggregate;
using FourSix.UseCases.Interfaces;

namespace FourSix.UseCases.UseCases.Pedidos.ObtemPedidos
{
    public class ObtemPedidosUseCase
     : IObtemPedidosUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;

        public ObtemPedidosUseCase(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }

        public Task<ICollection<Pedido>> Execute() => ListarPedidos();

        private async Task<ICollection<Pedido>> ListarPedidos()
        {
            var pedidos = this._pedidoRepository.Listar(x => x.StatusId != EnumStatusPedido.Finalizado)
                .OrderBy(x => x.StatusId).OrderBy(x => x.DataPedido).ToList();

            return pedidos;
        }
    }
}
