FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY WeLearn.sln ./
COPY WeLearn.Web/WeLearn.Web.csproj ./WeLearn.Web/
COPY WeLearn.Common/WeLearn.Common.csproj ./WeLearn.Common/
COPY WeLearn.Services/WeLearn.Services.csproj ./WeLearn.Services/
COPY WeLearn.ViewModels/WeLearn.ViewModels.csproj ./WeLearn.ViewModels/
COPY WeLearn.Data/WeLearn.Data.csproj ./WeLearn.Data/
COPY WeLearn.Tests/WeLearn.Tests.csproj ./WeLearn.Tests/

RUN dotnet restore
COPY . .

WORKDIR /src/WeLearn.Web
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app . 

# ENTRYPOINT ["dotnet", "WeLearn.Web.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeLearn.Web.dll