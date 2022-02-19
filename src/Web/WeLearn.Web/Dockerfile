FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /app
COPY . ./

RUN pwd
RUN dotnet restore
RUN dotnet publish Web/WeLearn.Web -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/publish /app
# ENTRYPOINT ["dotnet", "PROJECT_NAME.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet /app/WeLearn.Web.dll
