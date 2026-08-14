# 📚 Papelaria CRUD

Sistema de gerenciamento para uma **papelaria**, desenvolvido como parte da Situação de Aprendizagem (SA) de Desenvolvimento de Sistemas com Banco de Dados Relacional.

O projeto consiste em uma aplicação web CRUD desenvolvida com **C# e ASP.NET Core MVC**, utilizando **Entity Framework Core** para comunicação com o banco de dados **SQL Server** e **Bootstrap** para construção da interface.

---

## 🎯 Objetivo

Desenvolver um sistema funcional para gerenciamento dos principais dados de uma papelaria, permitindo realizar operações de:

* ➕ Cadastro
* 🔎 Consulta
* ✏️ Edição
* 🗑️ Exclusão

O projeto também utiliza **Entity Framework Core Migrations** para criação e atualização da estrutura do banco de dados.

---

## 📋 Funcionalidades

### 👥 Clientes

* Cadastrar clientes
* Visualizar clientes
* Editar informações
* Excluir clientes

### 📦 Produtos

* Cadastrar produtos
* Informar categoria
* Controlar preço
* Controlar quantidade em estoque
* Editar e excluir produtos

### 👨‍💼 Funcionários

* Cadastrar funcionários
* Informar CPF
* Definir cargo
* Informar telefone
* Editar e excluir funcionários

### 🏢 Fornecedores

* Cadastrar fornecedores
* Informar CNPJ
* Informar telefone e e-mail
* Editar e excluir fornecedores

### 🔐 Sistema de Login

O projeto também possui autenticação utilizando **ASP.NET Core Identity**, permitindo:

* Cadastro de usuários
* Login com e-mail e senha
* Logout
* Gerenciamento da conta
* Autenticação de usuários

---

## 🛠️ Tecnologias utilizadas

| Tecnologia                | Utilização                               |
| ------------------------- | ---------------------------------------- |
| **C#**                    | Linguagem principal                      |
| **ASP.NET Core MVC**      | Desenvolvimento da aplicação web         |
| **Entity Framework Core** | ORM e acesso ao banco de dados           |
| **SQL Server**            | Banco de dados relacional                |
| **ASP.NET Core Identity** | Autenticação e gerenciamento de usuários |
| **Bootstrap**             | Interface e responsividade               |
| **Razor**                 | Construção das páginas                   |
| **HTML5**                 | Estrutura das páginas                    |
| **CSS3**                  | Estilização                              |
| **Visual Studio**         | Ambiente de desenvolvimento              |

---

## 🗂️ Estrutura do projeto

```text
PapelariaCrud/
│
├── Areas/
│   └── Identity/
│       ├── Data/
│       └── Pages/
│
├── Controllers/
│   ├── ClientesController.cs
│   ├── ProdutosController.cs
│   ├── FuncionariosController.cs
│   └── FornecedoresController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   ├── Cliente.cs
│   ├── Produto.cs
│   ├── Funcionario.cs
│   └── Fornecedor.cs
│
├── Views/
│   ├── Clientes/
│   ├── Produtos/
│   ├── Funcionarios/
│   ├── Fornecedores/
│   └── Shared/
│
├── Migrations/
│
├── appsettings.json
├── Program.cs
└── README.md
```

---

## 🗄️ Banco de Dados

O sistema utiliza **SQL Server** e **Entity Framework Core**.

As tabelas principais do sistema são:

```text
Clientes
Produtos
Funcionarios
Fornecedores
```

Além das tabelas utilizadas pelo **ASP.NET Core Identity** para gerenciamento dos usuários e autenticação.

### Migrations

A estrutura do banco é controlada através de migrations do Entity Framework Core.

Exemplo:

```powershell
Add-Migration CriandoTabela
```

Para atualizar o banco:

```powershell
Update-Database
```

---

## 🚀 Como executar o projeto

### 1. Clone o repositório

```bash
git clone https://github.com/davidosilva9-hub/PapelariaCrud.git
```

### 2. Abra o projeto

Abra o arquivo:

```text
PapelariaCrud.sln
```

utilizando o **Visual Studio**.

### 3. Configure o banco de dados

No arquivo:

```text
appsettings.json
```

configure a sua conexão com o SQL Server.

Exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=PapelariaDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> A string de conexão deve ser adaptada de acordo com a configuração do SQL Server instalado na máquina.

### 4. Execute as migrations

No **Console do Gerenciador de Pacotes**, execute:

```powershell
Update-Database
```

### 5. Execute a aplicação

No Visual Studio, clique em:

```text
▶ Iniciar
```

A aplicação será aberta no navegador.

---

## 🔐 Autenticação

O sistema utiliza **ASP.NET Core Identity** para gerenciamento dos usuários.

O usuário pode:

1. Criar uma conta;
2. Realizar login;
3. Acessar o sistema autenticado;
4. Utilizar as funcionalidades disponíveis;
5. Realizar logout.

A autenticação utiliza e-mail e senha.

---

## 🎓 Situação de Aprendizagem

Este projeto foi desenvolvido como atividade prática da **Situação de Aprendizagem (SA): Desenvolvimento de Solução CRUD com C# e SQL Server**.

### Objetivos trabalhados

* Desenvolvimento de aplicações web;
* Arquitetura MVC;
* Programação em C#;
* Entity Framework Core;
* Banco de dados SQL Server;
* Migrations;
* Scaffold;
* Operações CRUD;
* Autenticação de usuários;
* Desenvolvimento de interfaces responsivas.

---

## 👨‍💻 Autor

**David Oliveira da Silva**

Projeto desenvolvido para fins **educacionais e acadêmicos**.

---

## 📄 Licença

Este projeto foi desenvolvido para fins educacionais. Seu uso, modificação e distribuição podem ser realizados para fins de estudo e aprendizado.
