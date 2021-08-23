FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MethodChallenge/MethodChallenge.csproj", "MethodChallenge/"]
RUN dotnet restore "MethodChallenge/MethodChallenge.csproj"
COPY . .
WORKDIR "/src/MethodChallenge"
RUN dotnet build "MethodChallenge.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MethodChallenge.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MethodChallenge.dll"]
