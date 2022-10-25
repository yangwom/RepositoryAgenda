# Agenda - C# Web - MVC

Desenvolvimento de código de uma agenda usando C# Web com Asp.NET

## Rotas

GET /agenda - rota com retorno do array JSON vindo o banco de dados Agenda e da tabela Agenda

GET /agenda/view - rota com a view que renderiza uma tabela com os mesmos dados.


## Comandos utilizados


1. Inicializa uma nova api web no dotnet

````
dotnet new api
````
2. Iniciar um container do SQL Server ou Azure data para máquinas com processadores M1

````
docker run -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=SuaSenha' -p 1433:1433 -v /seu-diretorio:/var/opt/mssql/data -d mcr.microsoft.com/azure-sql-edge:latest
````

3. Instala os certificados para aceitar a api a funcionar com HTTPS

````
dotnet dev-certs https --trust
````

4. Instala e adiciona ao projeto as dependência do EntityFramework para o mesmo conectar com um banco SQL Server

````
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
````

5. Comandos para criação do banco de dados e da tabela

`````
CREATE DATABASE Agenda;

USE Agenda;

CREATE TABLE Agenda
(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(200) NOT NULL,
    telefone VARCHAR(20) NOT NULL
)
`````
