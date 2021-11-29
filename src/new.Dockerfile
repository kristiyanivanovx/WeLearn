FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app
COPY ./ ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "WeLearn.Web.dll"]
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeLearn.Web.dll