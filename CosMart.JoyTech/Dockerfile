#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CosMart.JoyTech.Repository/CosMart.JoyTech.Repository.csproj", "CosMart.JoyTech.Repository/"]
RUN dotnet restore "CosMart.JoyTech.Repository/CosMart.JoyTech.Repository.csproj"
COPY . .
COPY ["CosMart.JoyTech.Service/CosMart.JoyTech.Service.csproj", "CosMart.JoyTech.Service/"]
RUN dotnet restore "CosMart.JoyTech.Service/CosMart.JoyTech.Service.csproj"
COPY . .
COPY ["CosMart.JoyTech.WebApi/CosMart.JoyTech.WebApi.csproj", "CosMart.JoyTech.WebApi/"]
RUN dotnet restore "CosMart.JoyTech.WebApi/CosMart.JoyTech.WebApi.csproj"
COPY . .
WORKDIR "/src/CosMart.JoyTech.WebApi"
RUN dotnet build "CosMart.JoyTech.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CosMart.JoyTech.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CosMart.JoyTech.WebApi.dll"]