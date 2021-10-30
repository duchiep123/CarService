#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CRUDDocker/CRUDDocker.csproj", "CRUDDocker/"]
RUN dotnet tool install --global dotnet-ef
RUN dotnet restore "CRUDDocker/CRUDDocker.csproj"
COPY . .
WORKDIR "/src/CRUDDocker"
RUN dotnet build "CRUDDocker.csproj" -c Release -o /app/build
RUN chmod +x ../entrypoint.sh
CMD /bin/bash ../entrypoint.sh

