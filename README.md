# 🎓 StudyTracker

Sistema de gerenciamento de atividades de estudo, desenvolvido em .NET com arquitetura em camadas (Domain, Application, Infrastructure, API) e banco de dados Oracle. A API permite o gerenciamento de sessões de estudo (como tarefas de leitura, revisão e prática), com documentação via Swagger.

---

## 📌 Descrição do Projeto
> **Problema escolhido:**  
> Muitas pessoas têm dificuldades em organizar suas rotinas de estudo, esquecendo prazos, acumulando tarefas e perdendo eficiência no aprendizado.

### 🎯 Solução proposta

A aplicação **StudyTracker** ajuda os usuários a organizarem suas sessões de estudo de forma simples e eficiente. Permite registrar, consultar, atualizar e remover atividades de estudo, promovendo disciplina, foco e controle sobre o progresso acadêmico ou autodidata.

---

O **StudyTracker** utiliza as seguintes tecnologias:

- .NET 9
- Entity Framework Core
- Oracle DB
- Swagger para documentação
- Arquitetura limpa (Domain, Application, Infrastructure, API)

---

## 📚 Rotas da API (endpoints)

### 🔹 `GET /api/sessoes`
Lista todas as sessões de estudo cadastradas.

### 🔹 `GET /api/sessoes/{id}`
Busca uma sessão de estudo específica por ID.

### 🔹 `POST /api/sessoes`
Cria uma nova sessão de estudo.
```json
{
  "titulo": "Revisão de Matemática",
  "descricao": "Resolver exercícios sobre derivadas",
  "data": "2025-05-12T14:00:00"
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
