using Microsoft.EntityFrameworkCore;
using Supermercado.Infrastructure.Data;
using Supermercado.Application.Interfaces;
using Supermercado.Infrastructure.Repositories;

namespace Supermercado.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
        
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseSqlite(connectionString);
        });
        
        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        
        app.MapControllers();
        
        app.MapGet("/clientes", async (IClienteRepository repo) =>
        {
            return await repo.GetAllAsync();
        });
        
        app.Run();
        
    }
}