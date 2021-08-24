FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NestedIfStatement/NestedIfStatement.csproj", "NestedIfStatement/"]
RUN dotnet restore "NestedIfStatement/NestedIfStatement.csproj"
COPY . .
WORKDIR "/src/NestedIfStatement"
RUN dotnet build "NestedIfStatement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NestedIfStatement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NestedIfStatement.dll"]
