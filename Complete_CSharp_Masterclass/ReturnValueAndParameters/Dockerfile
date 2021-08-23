FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ReturnValueAndParameters/ReturnValueAndParameters.csproj", "ReturnValueAndParameters/"]
RUN dotnet restore "ReturnValueAndParameters/ReturnValueAndParameters.csproj"
COPY . .
WORKDIR "/src/ReturnValueAndParameters"
RUN dotnet build "ReturnValueAndParameters.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReturnValueAndParameters.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReturnValueAndParameters.dll"]
