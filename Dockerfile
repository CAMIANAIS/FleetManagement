# ==========================================
# ETAPA 1: Construcción
# ==========================================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Usamos la carpeta "MiProyecto" que es la de tu API principal
COPY ["MiProyecto/FleetManagement.csproj", "MiProyecto/"]
COPY ["FleetManagement.Application/FleetManagement.Application.csproj", "FleetManagement.Application/"]
COPY ["FleetManagement.Infrastructure/FleetManagement.Infrastructure.csproj", "FleetManagement.Infrastructure/"]
COPY ["FleetManagement.Core/FleetManagement.Core.csproj", "FleetManagement.Core/"]

# Restauramos dependencias
RUN dotnet restore "MiProyecto/FleetManagement.csproj"

# Copiamos el resto del código
COPY . .

# Nos movemos a la carpeta de la API y publicamos
WORKDIR "/src/MiProyecto"
RUN dotnet publish "FleetManagement.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ==========================================
# ETAPA 2: Producción
# ==========================================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FleetManagement.dll"]