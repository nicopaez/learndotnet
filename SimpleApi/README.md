dotnet new webapi -o SimpleApi --no-https

dotnet add package AspNetCore.HealthChecks.System
dotnet add package AspNetCore.HealthChecks.Network

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet add package AspNetCore.HealthChecks.SqlServer

https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks


docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw@rd1' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
docker exec -it 4e79b8bbb959 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P Passw@rd1

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw@rd1' -p 1433:1433 simplesqlserver
docker exec -it 4e79b8bbb959 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P Passw@rd1