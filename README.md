# ClienteAPP
# 💼 Client Management System (.NET 8 | WinForms | SQL Server)

Aplicação desktop desenvolvida em .NET 8 utilizando Windows Forms, estruturada em arquitetura em camadas e aplicando princípios SOLID.

O projeto foi criado com foco em organização arquitetural, separação de responsabilidades e boas práticas de desenvolvimento orientado a domínio.

---

## 🎯 Objetivo

Construir um sistema simples de cadastro de clientes demonstrando:

- Aplicação prática de princípios SOLID
- Separação clara de camadas
- Uso de Repository Pattern
- Persistência com SQL Server via ADO.NET
- Organização de solução em múltiplos projetos

---

## 🏗 Arquitetura

A solução foi estruturada em quatro projetos independentes:

```
ClienteApp
 ├── ClienteApp.UI
 ├── ClienteApp.Application
 ├── ClienteApp.Domain
 └── ClienteApp.Infrastructure
```

### 🔹 Domain
- Entidade `Cliente`
- Interface `IClienteRepository`
- Não possui dependências externas

### 🔹 Application
- `ClienteService`
- Contém regras de negócio
- Depende apenas do Domain

### 🔹 Infrastructure
- Implementação de `IClienteRepository`
- Comunicação com SQL Server
- Uso de `Microsoft.Data.SqlClient`

### 🔹 UI
- Windows Forms
- Responsável apenas por interação com usuário
- Não contém regras de negócio

---

## 🧠 Princípios Aplicados

- Single Responsibility Principle
- Dependency Inversion Principle
- Separation of Concerns
- Repository Pattern
- Arquitetura em Camadas

---

## 🛠 Tecnologias Utilizadas

- .NET 8
- Windows Forms
- SQL Server
- ADO.NET
- Microsoft.Data.SqlClient

---

## 🗄 Banco de Dados

### Script de Criação

```sql
CREATE DATABASE ClienteDB;
GO

USE ClienteDB;
GO

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    Email NVARCHAR(150) NOT NULL,
    Cpf NVARCHAR(14) NOT NULL,
    DataNascimento DATETIME NOT NULL
);
```

---

## ⚙ Configuração

Arquivo responsável pela conexão:

```
ClienteApp.Infrastructure/Configurations/DatabaseSettings.cs
```

Exemplo de string de conexão:

```csharp
Server=localhost;
Database=ClienteDB;
Trusted_Connection=True;
TrustServerCertificate=True;
```

Se estiver usando autenticação SQL:

```csharp
Server=localhost;
Database=ClienteDB;
User Id=sa;
Password=SUA_SENHA;
```

---

## ▶ Como Executar

1. Restaurar dependências:
   ```
   dotnet restore
   ```

2. Definir `ClienteApp.UI` como projeto de inicialização.

3. Executar:
   ```
   dotnet run --project ClienteApp.UI
   ```

---

## 📦 Pacotes Necessários

Instalar no projeto Infrastructure:

```
dotnet add ClienteApp.Infrastructure package Microsoft.Data.SqlClient
```

---

## 📈 Melhorias possíveis em caso de implementação real

- Implementar DataGridView para listagem dinâmica
- Aplicar validação real de CPF
- Introduzir Injeção de Dependência
- Adicionar testes unitários
- Migrar acesso a dados para Dapper ou EF Core
- Implementar logs estruturados

---

## 👨‍💻 Autor

Nicolás Melo Chabot  
Software Engineer  
Belo Horizonte - MG

---

## 📌 Observação

Este projeto foi desenvolvido como exercício prático de arquitetura e boas práticas em .NET, com foco em organização de código e escalabilidade.
