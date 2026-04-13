using Microsoft.EntityFrameworkCore;
using Supermercado.Application.Interfaces;
using Supermercado.Domain.Entities;
using Supermercado.Infrastructure.Data;

namespace Supermercado.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> GetAllAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
}