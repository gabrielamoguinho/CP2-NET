# 💰 FinanceControl

Sistema de controle financeiro pessoal, desenvolvido em .NET com arquitetura em camadas (Domain, Application, Infrastructure, API) e banco de dados Oracle. A API permite o gerenciamento de lançamentos financeiros (como receitas e despesas), com documentação via Swagger.


## 📌 Descrição do Projeto
> **Problema escolhido:**  
> Muitas pessoas têm dificuldade em organizar suas finanças pessoais, perdendo o controle de despesas e receitas, o que pode comprometer o equilíbrio financeiro mensal.

### 🎯 Solução proposta

A aplicação **FinanceControl** resolve esse problema permitindo que o usuário registre seus lançamentos financeiros (despesas e receitas), consulte seu histórico e mantenha controle sobre suas movimentações. Com isso, promove maior organização e planejamento financeiro.

---

O **FinanceControl** utiliza as seguintes tecnologias:

- .NET 9
- Entity Framework Core
- Oracle DB
- Swagger para documentação
- Arquitetura limpa (Domain, Application, Infrastructure, API)

---

## 📚 Rotas da API (endpoints)

### 🔹 `GET /api/lancamentos`
Lista todos os lançamentos registrados.

### 🔹 `GET /api/lancamentos/{id}`
Busca um lançamento específico por ID.

### 🔹 `POST /api/lancamentos`
Cria um novo lançamento.
```json
{
  "descricao": "Salário",
  "valor": 2500.00,
  "data": "2025-05-01T00:00:00"
}
```
### 🔹 `PUT /api/lancamentos/{id}`
Atualiza os dados de um lançamento existente.

### 🔹 `DELETE /api/lancamentos/{id}`
Remove um lançamento pelo ID.

## 📚 Instalação e Execução

Pré-requisitos:
- .NET 9 SDK
- Oracle Database ou Oracle XE

1. Clone o repositório
   ```
   git clone https://github.com/seu-usuario/FinanceControl.git
    cd FinanceControl
   ```
2.  Configure o banco de dados
   Edite o arquivo appsettings.json em FinanceControl.API:

```
"ConnectionStrings": {
"DefaultConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=SEU_SERVIDOR"
}
```
3. Execute as migrations
```
  dotnet ef database update --project FinanceControl.Infrastructure --startup-project FinanceControl.API
```
4. Rode a aplicação

##📖 Swagger

A documentação da API estará disponível em:

```
https://localhost:PORT/swagger
```
>Substitua PORT pela porta exibida no terminal.

## 🧱 Estrutura do Projeto

```
FinanceControl/
│
├── FinanceControl.Domain          # Entidades e interfaces
├── FinanceControl.Application     # Serviços e lógica de negócio
├── FinanceControl.Infrastructure  # Acesso a dados, EF Core, contexto
├── FinanceControl.API             # Web API (controllers, startup)
└── FinanceControl.sln             # Solução
```
