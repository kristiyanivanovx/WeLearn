# NuGet restore
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY *.sln .
COPY WeLearn.Web/WeLearn.Web.csproj WeLearn.Web/
COPY WeLearn.Services/WeLearn.Services.csproj WeLearn.Services/
COPY WeLearn.Infrastructure/WeLearn.Infrastructure.csproj WeLearn.Infrastructure/
COPY WeLearn.Data/WeLearn.Data.csproj WeLearn.Data/
RUN dotnet restore
COPY . .

# testing
# FROM build AS testing
# WORKDIR /src/WeLearn.Web
# RUN dotnet build
# WORKDIR /src/WeLearn.Web.UnitTests
# RUN dotnet test

# publish
FROM build AS publish
WORKDIR /src/WeLearn.Web
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "WeLearn.Web.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeLearn.Web.dll

# RUN dotnet restore 

# COPY "WeLearn.Web/." "./WeLearn.Web/"
# COPY "WeLearn.Services/." "./WeLearn.Services/"
# COPY "WeLearn.Infrastructure/." "./WeLearn.Infrastructure/"
# COPY "WeLearn.Data/." "./WeLearn.Data/"

# WORKDIR /app
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/sdk:5.0 AS runtime
# COPY --from=build /app/out ./
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeLearn.Web.dll

# COPY *.sln .
# COPY ["WeLearn.Web/WeLearn.Web.csproj", "WeLearn.Web/"]
# COPY ["WeLearn.Services/WeLearn.Services.csproj", "WeLearn.Services/"]
# COPY ["WeLearn.Infrastructure/WeLearn.Infrastructure.csproj", "WeLearn.Infrastructure/"]
# COPY ["WeLearn.Data/WeLearn.Data.csproj", "WeLearn.Data/"]
