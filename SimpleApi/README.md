dotnet new webapi -o SimpleApi --no-https

dotnet add package AspNetCore.HealthChecks.System
dotnet add package AspNetCore.HealthChecks.Network

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet add package AspNetCore.HealthChecks.SqlServer

https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks


docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw@rd1' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
docker exec -it 6567999825b00a8c7342dd1505d2bf5c74c3cfb34b71d2df0d9b2f786d07abbf /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P Passw@rd1 -Q 'CREATE DATABASE simpledb;GO'


dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update # this execute the migrations

# Add nunit test project
dotnet new nunit -o SimpleApi.Tests
dotnet sln add SimpleApi.Tests/SimpleApi.Tests.csproj

# Scaffold a controller
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-aspnet-codegenerator
export PATH="$PATH:/Users/nicopaez/.dotnet/tools"
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers 


curl localhost:5000/api/TodoItems
curl -X POST -H Content-Type:application/json -d '{"name":"walk dog", "isComplete":true}' localhost:5000/api/TodoItems

https://www.thereformedprogrammer.net/is-the-repository-pattern-useful-with-entity-framework-core/


# Add specflow project
dotnet new nunit -o SimpleApi.Specs
dotnet sln add SimpleApi.Specs/SimpleApi.Specs.csproj
dotnet add package Specflow.NUnit
dotnet add package SpecFlow.Tools.MsBuild.Generation