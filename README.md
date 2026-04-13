# 🛒 Supermercado API — CP2

## 👥 Integrantes

* Nome: Lucas Rafael Solimene RM: 565194
* Nome: Samyr Couto Oliveira RM: 565562

---

## 🎯 Domínio do Projeto

O projeto representa um sistema de **Supermercado**, permitindo o gerenciamento de clientes, produtos, categorias e vendas.

---

## 🧱 Entidades Modeladas

* **Cliente**

  * Nome
  * Email
  * Telefone
  * DataCadastro

* **Categoria**

  * Nome
  * Descrição

* **Produto**

  * Nome
  * Preço
  * Estoque
  * CategoriaId

* **Venda**

  * ClienteId
  * DataVenda
  * ValorTotal

* **ItemVenda**

  * VendaId
  * ProdutoId
  * Quantidade
  * PrecoUnitario

---

## 🔗 Relacionamentos

* Cliente **1:N** Venda
  → Um cliente pode ter várias vendas

* Categoria **1:N** Produto
  → Uma categoria pode ter vários produtos

* Venda **1:N** ItemVenda
  → Uma venda pode ter vários itens

* Produto **1:N** ItemVenda
  → Um produto pode aparecer em vários itens de venda

---

## 🗄️ Banco de Dados

* **SGBD utilizado:** SQLite
* Banco gerado automaticamente via Entity Framework Core
* Arquivo: `supermercado.db`

---

## ⚙️ Tecnologias Utilizadas

* .NET 9
* Entity Framework Core
* SQLite
* Clean Architecture

---

## 🧩 Arquitetura

O projeto segue o padrão **Clean Architecture**, dividido em:

* **Domain**

  * Entidades e regras de negócio

* **Application**

  * Interfaces de repositório

* **Infrastructure**

  * DbContext
  * Mapeamentos (Fluent API)
  * Repositórios

* **API**

  * Configuração da aplicação
  * Injeção de dependência

---

## 🔄 Migrations

Migration inicial criada para gerar todo o banco de dados:

```bash
dotnet ef migrations add InitialCreate --project Supermercado.Infrastructure --startup-project Supermercado.API
```

Aplicar no banco:

```bash
dotnet ef database update --project Supermercado.Infrastructure --startup-project Supermercado.API
```

---

## ▶️ Como Executar o Projeto

1. Clonar o repositório
2. Restaurar dependências:

```bash
dotnet restore
```

3. Aplicar o banco:

```bash
dotnet ef database update --project Supermercado.Infrastructure --startup-project Supermercado.API
```

4. Rodar a API:

```bash
dotnet run --project Supermercado.API
```

---

## 📸 Evidência do Banco

As imagens do banco de dados gerado estão disponíveis na pasta:

```
/docs/
```

---

## ✅ Status do Projeto

✔ Modelo MER implementado
✔ Persistência com EF Core
✔ Migrations funcionando
✔ Banco criado com sucesso
✔ Arquitetura limpa aplicada
