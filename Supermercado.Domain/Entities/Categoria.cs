using Supermercado.Domain.Commom;

namespace Supermercado.Domain.Entities;

public class Categoria : BaseEntity
{
    public string Nome { get; private set; }

    public string Descricao { get; private set; } 
    
    public Categoria(string nome, string descricao)
    {
        UpdateNome(nome);
        UpdateDescricao(descricao);
    }

    public void UpdateNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome da categoria não pode ser vazio.");

        Nome = nome.Trim();
    }

    public void UpdateDescricao(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
            throw new Exception("Descrição inválida.");

        Descricao = descricao.Trim();
    }
}