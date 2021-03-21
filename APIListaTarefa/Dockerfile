#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["APIListaTarefa/APIListaTarefa.csproj", "APIListaTarefa/"]
COPY ["Models/Models.csproj", "Models/"]
COPY ["DataAcess/DataAcess.csproj", "DataAcess/"]
RUN dotnet restore "APIListaTarefa/APIListaTarefa.csproj"
COPY . .
WORKDIR "/src/APIListaTarefa"
RUN dotnet build "APIListaTarefa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APIListaTarefa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIListaTarefa.dll"]