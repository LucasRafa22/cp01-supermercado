# CP1 — Modelo Entidade Relacionamento e WebAPI (.NET)

## Integrantes

| Nome | RM |
|------|------|
| Samyr | RM565562 |
| Lucas | RM565194 |

---

# Domínio do Projeto

Sistema de **Supermercado / Controle de Vendas**, com foco em:

- cadastro de clientes
- cadastro de produtos
- organização por categorias
- registro de vendas

---

# Entidades

O modelo foi construído com **5 entidades principais**:

| Entidade | Descrição |
|--------|--------|
| Cliente | Pessoa que realiza compras no sistema |
| Venda | Registro de uma compra realizada |
| Categoria | Classificação de produtos |
| Produto | Produto disponível para venda |
| ItemVenda | Produtos que fazem parte de uma venda |

Essas entidades representam a base de um sistema de mercado, permitindo cadastrar produtos por categoria, registrar clientes e armazenar vendas com seus respectivos itens.

---

# Relacionamentos

## Cliente → Venda

Um cliente pode realizar várias vendas, mas cada venda pertence a apenas um cliente.

Cardinalidade: **1:N**

Opcionalidade:

- Cliente → pode ter **0 ou N vendas**
- Venda → deve possuir **1 cliente**

---

## Categoria → Produto

Uma categoria pode possuir vários produtos, mas cada produto pertence a apenas uma categoria.

Cardinalidade: **1:N**

Opcionalidade:

- Categoria → pode ter **0 ou N produtos**
- Produto → deve possuir **1 categoria**

---

## Venda → ItemVenda

Uma venda pode conter vários itens, mas cada item pertence a apenas uma venda.

Cardinalidade: **1:N**

Opcionalidade:

- Venda → deve possuir **1 ou N itens**
- ItemVenda → pertence a **1 venda**

---

## Produto → ItemVenda

Um produto pode aparecer em vários itens de venda, mas cada item faz referência a apenas um produto.

Cardinalidade: **1:N**

Opcionalidade:

- Produto → pode aparecer em **0 ou N itens**
- ItemVenda → deve referenciar **1 produto**
