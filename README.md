# Projeto Web-LH Pets

Este projeto é uma aplicação web desenvolvida em C# com ASP.NET Core, voltada para a exibição e consulta de dados de clientes em um ambiente simples, apresentando uma interface inicial em HTML e integração com banco de dados SQL Server.

O objetivo principal da aplicação é demonstrar o uso de tecnologias modernas do ecossistema .NET para criar uma solução web com acesso a dados, estrutura organizada em classes e páginas estáticas.

---

## Visão geral

A solução foi criada em .NET 10 e utiliza o modelo de aplicação web do ASP.NET Core para gerar um servidor local que responde a requisições HTTP. O projeto também inclui arquivos estáticos em `wwwroot`, além de uma estrutura de acesso a banco de dados por meio do driver `System.Data.SqlClient`.

Essa combinação permite:

- servir páginas HTML no navegador;
- criar endpoints HTTP com C#;
- conectar com um banco de dados SQL Server;
- processar e exibir informações como clientes, valores, impostos e totais;
- manter uma base simples para evoluir para um sistema mais completo.

---

## Tecnologias utilizadas

### 1. C#

O código principal da aplicação foi escrito em C#, que é a linguagem oficial da plataforma .NET. Ela é usada para:

- configurar a aplicação web;
- criar rotas HTTP;
- gerenciar regras de negócio;
- acessar o banco de dados;
- modelar os dados em classes.

C# é uma linguagem orientada a objetos, fortemente tipada e muito utilizada em aplicações empresariais, APIs e sistemas web.

### 2. .NET 10

O projeto foi configurado com o SDK do .NET 10 por meio do arquivo de projeto `.csproj`:

- `TargetFramework: net10.0`
- `Microsoft.NET.Sdk.Web`

Esse framework fornece toda a infraestrutura necessária para desenvolver aplicações web, incluindo:

- runtime da aplicação;
- suporte a servidores HTTP;
- suporte a injeção de dependências;
- criação de endpoints web;
- integração com bibliotecas do ecossistema .NET.

### 3. ASP.NET Core

O ASP.NET Core é o framework web utilizado para montar a aplicação. Ele permite que o projeto seja executado como um servidor local, recebendo requisições HTTP e respondendo com conteúdo HTML ou texto.

No arquivo `Program.cs`, a aplicação cria uma instância de `WebApplication`, que é a base do ambiente ASP.NET Core moderno. Isso permite:

- registrar serviços;
- mapear endpoints;
- executar a aplicação localmente;
- servir arquivos estáticos com `wwwroot`.

O uso de ASP.NET Core é importante porque esse framework é otimizado para performance, escalabilidade e desenvolvimento moderno em aplicações web.

### 4. Minimal APIs

O projeto utiliza o conceito de Minimal APIs do ASP.NET Core, que permite criar endpoints web de forma direta, com menos código boilerplate em comparação com modelos mais tradicionais como Controllers.

Exemplo conceitual do uso:

- `app.MapGet("/", ...)` para criar uma rota raiz;
- resposta textual para acesso inicial;
- integração com arquivos estáticos em `/index.html`.

Esse modelo é muito útil para projetos pequenos e medianos, especialmente em APIs simples e protótipos.

### 5. HTML e CSS

A interface principal da aplicação foi desenvolvida com HTML e CSS embutidos no arquivo `wwwroot/index.html`.

Esse arquivo contém:

- estrutura básica da página;
- texto de boas-vindas;
- estilo visual simples com fundo e elementos visuais básicos;
- apresentação inicial do projeto ao usuário.

A pasta `wwwroot` é a pasta padrão do ASP.NET Core para armazenar recursos estáticos como:

- páginas HTML;
- arquivos CSS;
- imagens;
- JavaScript;
- fontes.

### 6. SQL Server

O projeto faz uso do SQL Server para consultar dados de clientes. Isso é visível no arquivo `Banco.cs`, onde é utilizado `System.Data.SqlClient` para realizar comunicação com o banco.

Os elementos principais são:

- `SqlConnection`: responsável pela conexão com o banco;
- `SqlCommand`: executa as consultas SQL;
- `SqlDataReader`: lê os resultados retornados pela consulta.

A aplicação busca dados da tabela `tblclientes` do banco `vendas`, e monta objetos da classe `Clientes` com as informações lidas.

Esse uso é típico em aplicações .NET que precisam acessar dados estruturados em um sistema relacional.

### 7. ADO.NET

A conexão com o banco de dados foi implementada com ADO.NET, que é um conjunto de classes do .NET para acessar dados relacionais de forma direta.

Entre as principais classes usadas estão:

- `SqlConnectionStringBuilder`: constrói a string de conexão;
- `SqlConnection`: conecta ao banco;
- `SqlCommand`: executa instruções SQL;
- `SqlDataReader`: lê os registros retornados.

O ADO.NET é uma tecnologia fundamental para aplicações que precisam interagir com bancos de dados sem depender de abstrações extras.

### 8. Padrão de modelagem em classes

A estrutura do projeto também utiliza classes para representar os dados do domínio. Isso aparece em `Clientes.cs`.

A classe `Clientes` contém propriedades como:

- `cpf_cnpj`
- `nome`
- `endereco`
- `rg_ie`
- `tipo`
- `valor`
- `valor_imposto`
- `total`

Essa abordagem organiza os dados em objetos e facilita a manipulação deles dentro do código.

### 9. Visual Studio / ambiente de desenvolvimento

O projeto foi montado para ser executado em ambiente Windows, especialmente com Visual Studio e o .NET SDK. O ambiente de desenvolvimento da Microsoft facilita a criação, execução e depuração de aplicações .NET.

As ferramentas geralmente usadas incluem:

- Visual Studio Code ou Visual Studio;
- .NET CLI (`dotnet restore`, `dotnet build`, `dotnet run`);
- terminal do sistema para execução da aplicação.

---

## Estrutura do projeto

A organização do projeto inclui os elementos principais abaixo:

- `Program.cs` – ponto de entrada da aplicação web;
- `Banco.cs` – lógica de conexão e consulta ao banco;
- `Clientes.cs` – modelo dos dados dos clientes;
- `Projeto_Web-Lh_Pets_Alunos.csproj` – arquivo do projeto .NET;
- `appsettings.json` – configuração da aplicação;
- `wwwroot/index.html` – página inicial estática do site;
- `vendas.sql` – script SQL do banco de dados;
- `.gitignore` – arquivos ignorados pelo Git.

---

## Como executar localmente

### Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

- .NET 10 SDK
- SQL Server local (ou SQL Server Express)
- uma ferramenta de execução como Visual Studio, VS Code ou terminal do sistema

### Passos

1. Clone o repositório para sua máquina.
2. Abra a pasta do projeto no terminal.
3. Restaure os pacotes do projeto:

   dotnet restore

4. Execute a aplicação:

   dotnet run

5. Acesse a URL exibida no terminal, normalmente algo como:

   http://localhost:5000

   ou

   https://localhost:5001

---

## Banco de dados

O projeto faz referência a um banco chamado `vendas` e a uma tabela chamada `tblclientes`. Os dados são consultados diretamente via SQL e transformados em objetos C# da classe `Clientes`.

Essa estrutura é muito útil para aplicações internas ou sistemas de gestão simples, onde a integração com banco de dados relacional é essencial.

---

## Benefícios da stack utilizada

A combinação de C#, ASP.NET Core, SQL Server e HTML oferece vários benefícios:

- desenvolvimento rápido para web;
- alta produtividade com .NET;
- fácil integração com banco de dados;
- aplicação simples e eficiente;
- base sólida para evoluir para um sistema mais complexo.

---

## Conclusão

Este projeto demonstra de forma prática como criar uma aplicação web moderna com a plataforma .NET, usando ASP.NET Core para servir conteúdo, C# para lógica, SQL Server para persistência e HTML para interface inicial.

Ele é uma excelente base para estudantes e desenvolvedores que desejam aprender o fluxo completo de desenvolvimento de uma aplicação web com acesso a dados.

---

## Autor

Projeto desenvolvido como exemplo de aplicação web em C# com foco em tecnologias .NET e integração com banco de dados SQL Server.
