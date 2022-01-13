FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["nl.Api/nl.Api.csproj", "nl.Api/"]
RUN dotnet restore "nl.Api/nl.Api.csproj"
COPY . .
WORKDIR "/src/nl.Api"
RUN dotnet build "nl.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "nl.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "nl.Api.dll"]