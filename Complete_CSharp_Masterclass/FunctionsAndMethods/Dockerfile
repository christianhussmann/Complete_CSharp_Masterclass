FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FunctionsAndMethods/FunctionsAndMethods.csproj", "FunctionsAndMethods/"]
RUN dotnet restore "FunctionsAndMethods/FunctionsAndMethods.csproj"
COPY . .
WORKDIR "/src/FunctionsAndMethods"
RUN dotnet build "FunctionsAndMethods.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FunctionsAndMethods.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FunctionsAndMethods.dll"]
