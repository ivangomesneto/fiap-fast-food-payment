﻿namespace FourSix.Controllers.Adapters.Clientes.ObtemCliente
{
    public interface IObtemClienteAdapter
    {
        Task Obter(string cpf);
    }
}
