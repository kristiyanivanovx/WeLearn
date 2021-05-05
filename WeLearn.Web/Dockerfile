#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WeLearn.Web/WeLearn.Web.csproj", "WeLearn.Web/"]
COPY ["WeLearn.Services/WeLearn.Services.csproj", "WeLearn.Services/"]
COPY ["WeLearn.Infrastructure/WeLearn.Infrastructure.csproj", "WeLearn.Infrastructure/"]
COPY ["WeLearn.Data/WeLearn.Data.csproj", "WeLearn.Data/"]
RUN dotnet restore "WeLearn.Web/WeLearn.Web.csproj"
COPY . .
WORKDIR "/src/WeLearn.Web"
RUN dotnet build "WeLearn.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeLearn.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeLearn.Web.dll"]