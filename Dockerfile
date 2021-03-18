FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY src/HelloWorldMicroService/*.csproj ./app/HelloWorldMicroService/
WORKDIR /app/HelloWorldMicroService
RUN dotnet restore

COPY src/HelloWorldMicroService/. ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000
WORKDIR /app
COPY --from=build /app/HelloWorldMicroService/out ./
ENTRYPOINT ["dotnet", "HelloWorldMicroService.dll"]