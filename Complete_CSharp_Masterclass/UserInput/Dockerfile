FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UserInput/UserInput.csproj", "UserInput/"]
RUN dotnet restore "UserInput/UserInput.csproj"
COPY . .
WORKDIR "/src/UserInput"
RUN dotnet build "UserInput.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserInput.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserInput.dll"]
