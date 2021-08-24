FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IfStatements/IfStatements.csproj", "IfStatements/"]
RUN dotnet restore "IfStatements/IfStatements.csproj"
COPY . .
WORKDIR "/src/IfStatements"
RUN dotnet build "IfStatements.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IfStatements.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IfStatements.dll"]
