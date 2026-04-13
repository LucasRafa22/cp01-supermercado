using Supermercado.Domain.Entities;

namespace Supermercado.Application.Interfaces;

public interface IClienteRepository
{
    Task<List<Cliente>> GetAllAsync();
}