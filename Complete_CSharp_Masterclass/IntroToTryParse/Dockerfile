FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IntroToTryParse/IntroToTryParse.csproj", "IntroToTryParse/"]
RUN dotnet restore "IntroToTryParse/IntroToTryParse.csproj"
COPY . .
WORKDIR "/src/IntroToTryParse"
RUN dotnet build "IntroToTryParse.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IntroToTryParse.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IntroToTryParse.dll"]
