#FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY . ./
RUN dotnet publish Web/WeLearn.Web -c Release -o out

#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app
COPY --from=build-env /app/out .

# ENTRYPOINT ["dotnet", "PROJECT_NAME.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeLearn.Web.dll
