﻿using CGenius.Models;

namespace CGenius.Repository.Interface
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(string cpfCliente);
        Task<Cliente> AddCliente(Cliente cliente);
        Task<Cliente> UpdateCliente(Cliente cliente);
        void DeleteCliente(string cpfCliente);
    }
}