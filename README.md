# Projeto Web-LH Pets

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet" alt=".NET 10" />
  <img src="https://img.shields.io/badge/C%23-9A5AFB?style=for-the-badge&logo=csharp" alt="C#" />
  <img src="https://img.shields.io/badge/ASP.NET-Core-512BD4?style=for-the-badge&logo=dotnet" alt="ASP.NET Core" />
  <img src="https://img.shields.io/badge/SQL-Server-CC2927?style=for-the-badge&logo=microsoftsqlserver" alt="SQL Server" />
</p>

Este projeto é uma aplicação web desenvolvida em C# com ASP.NET Core para demonstrar a criação de um sistema de cadastro de clientes, com rotas web, apresentação inicial em HTML e integração com banco de dados SQL Server.

O objetivo da aplicação é praticar os conceitos de desenvolvimento back-end web com acesso a dados, modelagem de classes e criação de páginas dinâmicas e estáticas.

---

## 📌 Visão geral

A solução foi criada em .NET 10 e usa o modelo de aplicação web do ASP.NET Core para responder requisições HTTP. O projeto também inclui arquivos estáticos na pasta `wwwroot`, além de uma camada de acesso ao banco por meio do `System.Data.SqlClient`.

Entre as principais funcionalidades, estão:

- rota principal `/` com mensagem do protótipo;
- rota `/index` para acessar a página inicial em HTML;
- rota `/listaClientes` para listar clientes vindo do banco;
- conexão com SQL Server para consulta de registros;
- modelo de dados em classes para representar clientes.

---

## 🧩 Tecnologias utilizadas

### 1. 💻 C#

A linguagem principal da aplicação é o C#, usada para:

- configurar o servidor web;
- definir rotas e endpoints;
- modelar as entidades do sistema;
- consultar e processar dados do banco;
- implementar a lógica de negócio.

C# é uma linguagem moderna, orientada a objetos e muito utilizada no ecossistema .NET.

### 2. ⚙️ .NET 10

O projeto foi configurado com o SDK do .NET 10 por meio do arquivo `.csproj`:

- `TargetFramework: net10.0`
- `Microsoft.NET.Sdk.Web`

Esse framework fornece a infraestrutura necessária para a execução da aplicação, incluindo runtime, bibliotecas e suporte ao desenvolvimento web.

### 3. 🌐 ASP.NET Core

O ASP.NET Core é o framework web utilizado para montar o backend da aplicação. Ele permite:

- criar um servidor HTTP local;
- responder requisições do navegador;
- servir arquivos estáticos;
- definir rotas com `MapGet`.

Esse modelo é leve, rápido e muito usado em aplicações modernas.

### 4. 🚀 Minimal APIs

O projeto usa Minimal APIs do ASP.NET Core para criar endpoints simples e diretos, como:

- `/`
- `/index`
- `/listaClientes`

Essa abordagem reduz a quantidade de código necessário para prover serviços web básicos.

### 5. 🖥️ HTML

A página inicial do projeto está em `wwwroot/index.html` e é usada como interface visual inicial da aplicação. Ela contém a estrutura básica do site e representa a tela inicial do protótipo LH Pets.

### 6. 🗃️ SQL Server

O sistema se conecta a um banco de dados SQL Server para consultar registros de clientes. A conexão é feita através do arquivo `Banco.cs`, utilizando classes do ADO.NET.

O banco contém a tabela `tblclientes`, com informações como:

- CPF/CNPJ
- nome
- endereço
- RG/IE
- tipo
- valor
- imposto
- total

### 7. 🔌 ADO.NET

A tecnologia de acesso a dados usada no projeto é o ADO.NET, com classes como:

- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`
- `SqlConnectionStringBuilder`

Essas classes permitem realizar consultas ao banco e transformar os dados em objetos do sistema.

### 8. 🧱 Modelagem em classes

A aplicação organiza os dados em classes, como a classe `Clientes`, que reúne as propriedades do cliente em um objeto. Isso facilita a manipulação e a apresentação dos dados na aplicação.

### 9. 🛠️ Visual Studio / VS Code

O projeto pode ser executado em ambientes modernos de desenvolvimento, como:

- Visual Studio
- Visual Studio Code
- terminal do .NET CLI

Essas ferramentas permitem compilar, depurar e executar a aplicação localmente.

---

## 📁 Estrutura do projeto

- `Program.cs` — ponto de entrada e configuração das rotas;
- `Banco.cs` — lógica de acesso ao banco e listagem de clientes;
- `Clientes.cs` — modelagem da entidade cliente;
- `wwwroot/index.html` — página inicial do front-end;
- `vendas.sql` — script SQL de criação e carga de dados;
- `Projeto_Web-Lh_Pets_Alunos.csproj` — arquivo de configuração do projeto;
- `appsettings.json` — configurações da aplicação;
- `.gitignore` — arquivos ignorados pelo Git.

---

## ▶️ Como executar localmente

### Pré-requisitos

Antes de rodar a aplicação, verifique se você tem instalado:

- .NET 10 SDK
- SQL Server ou SQL Server Express
- SSMS (opcional, mas recomendado para gerenciar o banco)

### Passos

1. Abra o terminal na pasta do projeto.
2. Restaure os pacotes:

   ```bash
   dotnet restore
   ```

3. Execute a aplicação:

   ```bash
   dotnet run
   ```

4. Acesse as rotas no navegador:

   - `http://localhost:5000/`
   - `http://localhost:5000/index`
   - `http://localhost:5000/listaClientes`

> A porta pode variar conforme a configuração local do ambiente.

---

## 🧮 Banco de dados

O projeto considera um banco chamado `vendas` e uma tabela chamada `tblclientes`. Os dados são carregados com uma consulta SQL e exibidos em HTML na rota `/listaClientes`.

Essa parte é essencial para demonstrar como aplicações web back-end acessam dados armazenados em bancos relacionais.

---

## ✅ Benefícios da stack utilizada

A combinação de C#, ASP.NET Core e SQL Server oferece:

- desenvolvimento web ágil;
- fácil integração com banco de dados;
- arquitetura simples e funcional;
- boa base para evoluir para um sistema maior;
- aplicação fácil de manter e expandir.

---

## 🧾 Conclusão

Este projeto demonstra na prática como criar uma aplicação web com backend em C#, frontend em HTML e persistência em banco de dados SQL Server. A estrutura utilizada é simples, didática e funcional, ideal para aprender os princípios básicos de desenvolvimento web com .NET.

---

## 👤 Autor

Projeto desenvolvido como exemplo de aplicação web em C# com foco em tecnologias .NET, integração com SQL Server e criação de rotas HTTP.
