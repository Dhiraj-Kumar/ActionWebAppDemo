FROM mcr.microsoft.com/dotnet/sdk:7.0 AS buildStage
WORKDIR /app
COPY CyberShop/*.csproj ./
RUN dotnet restore
COPY CyberShop/. ./
RUN ls
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /deploy
COPY --from=buildStage /app/out .
ENTRYPOINT ["dotnet", "CyberShop.dll"]
