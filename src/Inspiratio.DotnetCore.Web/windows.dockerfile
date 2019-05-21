FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Inspiratio.DotnetCore.Web/Inspiratio.DotnetCore.Web.csproj", "src/Inspiratio.DotnetCore.Web/"]
RUN dotnet restore "src/Inspiratio.DotnetCore.Web/Inspiratio.DotnetCore.Web.csproj"
COPY . .
WORKDIR "/src/src/Inspiratio.DotnetCore.Web"
RUN dotnet build "Inspiratio.DotnetCore.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Inspiratio.DotnetCore.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Inspiratio.DotnetCore.Web.dll"]