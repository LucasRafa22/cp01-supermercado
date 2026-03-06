using Supermercado.Domain.Commom;

namespace Supermercado.Domain.Entities;

public class Venda : BaseEntity
{
    public Guid ClienteId { get; private set; }

    public DateTime DataVenda { get; private set; }

    public decimal ValorTotal { get; private set; }

    public Venda(Guid clienteId)
    {
        ClienteId = clienteId;
        DataVenda = DateTime.Now;
        ValorTotal = 0;
    }

    public void AtualizarValorTotal(decimal valor)
    {
        if (valor < 0)
            throw new Exception("Valor inválido.");

        ValorTotal = valor;
    }
}