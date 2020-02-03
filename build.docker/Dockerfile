ARG baseimage

FROM $baseimage as build

RUN dotnet publish --no-restore -o /publish -c Release Extractaciones.Api

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 as runtime

WORKDIR /app

#copy of binaries from build image to deploy image
COPY --from=build /publish .

#api execution on start of container
ENTRYPOINT ["dotnet", "Extractaciones.Api.dll"]