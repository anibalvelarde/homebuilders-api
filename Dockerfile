FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /app
COPY *.sln .
COPY api/*.csproj ./api/
COPY api.tests/*.csproj ./api.tests/
# COPY api.component.test/*.csproj ./test/api.ComponentTest/
RUN dotnet restore

# copy full solution over
COPY . .
RUN dotnet build
FROM build AS testrunner
WORKDIR /app/api.tests
CMD ["dotnet", "test", "--logger:trx"]

# run the unit tests
FROM build AS test
WORKDIR /app/api.tests
RUN dotnet test --logger:trx

# run the component tests
# FROM build AS componenttestrunner
# WORKDIR /app/test/api.ComponentTest
# CMD ["dotnet", "test", "--logger:trx"]

# publish the API
FROM build AS publish
WORKDIR /app/api
RUN dotnet publish -c Release -o out
# run the api
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS runtime
WORKDIR /app
COPY --from=publish /app/api/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "api.homebulders.dll"]