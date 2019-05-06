FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /sln
COPY . .
RUN dotnet restore
RUN dotnet publish ./AspNetCoreAppHealthCheck.csproj -o /app/ 
WORKDIR /app
ENTRYPOINT ["dotnet", "AspNetCoreAppHealthCheck.dll"]
HEALTHCHECK --interval=30s --timeout=3s CMD curl -f http://localhost:80/healthcheck || exit 1