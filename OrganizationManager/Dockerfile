FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OrganizationManager/OrganizationManager.csproj", "OrganizationManager/"]
RUN dotnet restore "OrganizationManager/OrganizationManager.csproj"
COPY . .
WORKDIR "/src/OrganizationManager"
RUN dotnet build "OrganizationManager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrganizationManager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrganizationManager.dll"]
