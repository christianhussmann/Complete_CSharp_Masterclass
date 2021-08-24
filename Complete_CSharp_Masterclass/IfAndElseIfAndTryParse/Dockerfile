FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IfAndElseIfAndTryParse/IfAndElseIfAndTryParse.csproj", "IfAndElseIfAndTryParse/"]
RUN dotnet restore "IfAndElseIfAndTryParse/IfAndElseIfAndTryParse.csproj"
COPY . .
WORKDIR "/src/IfAndElseIfAndTryParse"
RUN dotnet build "IfAndElseIfAndTryParse.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IfAndElseIfAndTryParse.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IfAndElseIfAndTryParse.dll"]
