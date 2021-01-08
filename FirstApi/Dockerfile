#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FirstApi/FirstApi.csproj", "FirstApi/"]
RUN dotnet restore "FirstApi/FirstApi.csproj"
COPY . .
WORKDIR "/src/FirstApi"
RUN dotnet build "FirstApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FirstApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FirstApi.dll"]