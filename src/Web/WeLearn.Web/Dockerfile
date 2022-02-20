FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /app
COPY . ./

RUN dotnet restore
RUN dotnet publish Web/WeLearn.Web -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/publish /app
# ENTRYPOINT ["dotnet", "PROJECT_NAME.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet /app/WeLearn.Web.dll
