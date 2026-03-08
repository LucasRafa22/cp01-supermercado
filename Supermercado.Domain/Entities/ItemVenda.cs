using Supermercado.Domain.Commom;

namespace Supermercado.Domain.Entities;

public class ItemVenda : BaseEntity
{
    public Guid VendaId { get; private set; }

    public Guid ProdutoId { get; private set; }

    public int Quantidade { get; private set; }

    public decimal PrecoUnitario { get; private set; }

    public ItemVenda(
        Guid vendaId,
        Guid produtoId,
        int quantidade,
        decimal precoUnitario)
    {
        if (quantidade <= 0)
            throw new Exception("Quantidade deve ser maior que zero.");

        if (precoUnitario <= 0)
            throw new Exception("Preço inválido.");

        VendaId = vendaId;
        ProdutoId = produtoId;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }
}