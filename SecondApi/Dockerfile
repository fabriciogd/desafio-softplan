#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SecondApi/SecondApi.csproj", "SecondApi/"]
RUN dotnet restore "SecondApi/SecondApi.csproj"
COPY . .
WORKDIR "/src/SecondApi"
RUN dotnet build "SecondApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SecondApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SecondApi.dll"]