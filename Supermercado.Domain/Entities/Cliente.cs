using Supermercado.Domain.Commom;

namespace Supermercado.Domain.Entities;

public class Cliente : BaseEntity
{
    public string Nome { get; private set; }

    public string Email { get; private set; }

    public string Telefone { get; private set; }

    public DateTime DataCadastro { get; private set; }

    public Cliente(
        string nome,
        string email,
        string telefone)
    {
        UpdateNome(nome);
        UpdateEmail(email);
        UpdateTelefone(telefone);

        DataCadastro = DateTime.Now;
    }

    public void UpdateNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome não pode ser vazio.");

        Nome = nome.Trim();
    }

    public void UpdateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new Exception("Email inválido.");

        Email = email.Trim();
    }

    public void UpdateTelefone(string telefone)
    {
        if (string.IsNullOrWhiteSpace(telefone))
            throw new Exception("Telefone inválido.");

        Telefone = telefone.Trim();
    }
}