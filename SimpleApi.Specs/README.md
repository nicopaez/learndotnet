dotnet test --logger:"console;verbosity=detailed"

dotnet new nunit -o SimpleApi.Specs
dotnet sln add SimpleApi.Specs/SimpleApi.Specs.csproj
dotnet add package Specflow.NUnit
dotnet add package SpecFlow.Tools.MsBuild.Generation

https://www.softwaretestinghelp.com/specflow-and-selenium/