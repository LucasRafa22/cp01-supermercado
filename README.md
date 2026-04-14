# 🛒 Supermercado API — CP2

## 👥 Integrantes
* **Lucas Rafael Solimene** — RM: 565194
* **Samyr Couto Oliveira** — RM: 565562

---

## 🎯 Domínio do Projeto
O projeto representa um sistema de **Supermercado**, responsável por gerenciar:
* Clientes, Categorias, Produtos, Vendas e Itens de venda.

O sistema evoluiu do modelo conceitual (CP1) para a persistência física completa no CP2.

---

## 🧱 Entidades Modeladas
* **Cliente:** Nome, Email, Telefone, DataCadastro.
* **Categoria:** Nome, Descrição.
* **Produto:** Nome, Preço, Estoque, CategoriaId.
* **Venda:** ClienteId, DataVenda, ValorTotal.
* **ItemVenda:** VendaId, ProdutoId, Quantidade, PrecoUnitario.

---

## 🔗 Relacionamentos (Fluent API)
Os relacionamentos foram implementados respeitando a cardinalidade e as chaves estrangeiras (FKs):
* Cliente **1:N** Venda
* Categoria **1:N** Produto
* Venda **1:N** ItemVenda
* Produto **1:N** ItemVenda

---

## 🗄️ Banco de Dados
* **SGBD utilizado:** Oracle Database (Servidor FIAP).
* **Provider:** `Oracle.EntityFrameworkCore` (v9.0.0).
* **Ajustes Técnicos:** 
    * Mapeamento de `bool` para `NUMBER(1)` (O Oracle não possui tipo booleano nativo).
    * Configuração de precisão decimal via `HasColumnType("NUMBER(18,2)")` para evitar o erro `ORA-00902`.

---

## 🧩 Arquitetura (Clean Architecture)
* **Domain:** Entidades e POCOs.
* **Application:** Interfaces de repositório (Contratos).
* **Infrastructure:** DbContext, Mapeamentos (Fluent API), Migrations e Implementações de Repositório.
* **API:** Configuração de Injeção de Dependência e Controllers.

---

## 🧪 Padrão Repository e Injeção de Dependência
Foi adotado o **Repository Pattern** para desacoplamento da persistência. Os serviços foram registrados no `Program.cs`:

```csharp
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("RecommendaContextOracle")));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
```

---

## 🔄 Migrations

Migration inicial responsável por criar o banco:

```bash
dotnet ef migrations add Banco --project Supermercado.Infrastructure --startup-project Supermercado.API
```

Aplicar no banco:

```bash
dotnet ef database update --project Supermercado.Infrastructure --startup-project Supermercado.API
```

✔ Executado com sucesso
✔ Estrutura criada corretamente

---

## ▶️ Como Executar o Projeto

1. Clonar o repositório

2. Configurar Credenciais: No arquivo appsettings.Development.json, insira seu usuario e senha na Connection String do Oracle: User ID=<USUARIO>;Password=<SENHA>;

3. Restaurar dependências:

```bash
dotnet restore
```

4. Preparar o Banco de Dados:

```bash
# Limpa o esquema atual
dotnet ef database drop --project Supermercado.Infrastructure --startup-project Supermercado.API --force
```

5. Criar banco:

```bash
# Cria a estrutura completa do zero
dotnet ef database update --project Supermercado.Infrastructure --startup-project Supermercado.API
```

6. Rodar a API:

```bash
dotnet run --project Supermercado.API
```

7. Acessar: http://localhost:5084/clientes

---

## 📸 Evidência do Banco

As evidências do banco gerado estão disponíveis em:

```plaintext
/docs/
```

---

## 📊 Relação com o CP1

| CP1                     | CP2                      |
| ----------------------- | ------------------------ |
| MER (modelo conceitual) | Banco físico             |
| Entidades em C#         | Persistência com EF Core |
| Sem banco               | Banco SQLite funcional   |
| Sem persistência        | Repositórios + DI        |


