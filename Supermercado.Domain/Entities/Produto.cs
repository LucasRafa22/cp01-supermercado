using Supermercado.Domain.Commom;

namespace Supermercado.Domain.Entities;

public class Produto : BaseEntity
{
    public string Nome { get; private set; }

    public decimal Preco { get; private set; }

    public int Estoque { get; private set; }

    public Guid CategoriaId { get; private set; }

    public Produto(
        string nome,
        decimal preco,
        int estoque,
        Guid categoriaId)
    {
        UpdateNome(nome);
        UpdatePreco(preco);
        UpdateEstoque(estoque);

        CategoriaId = categoriaId;
    }

    public void UpdateNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome do produto inválido.");

        Nome = nome.Trim();
    }

    public void UpdatePreco(decimal preco)
    {
        if (preco <= 0)
            throw new Exception("Preço deve ser maior que zero.");

        Preco = preco;
    }

    public void UpdateEstoque(int estoque)
    {
        if (estoque < 0)
            throw new Exception("Estoque inválido.");

        Estoque = estoque;
    }
}