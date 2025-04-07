# Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar archivos del proyecto
COPY ["ProyectoFinal/ProyectoFinal.csproj", "ProyectoFinal/"]
RUN dotnet restore "ProyectoFinal/ProyectoFinal.csproj"

# Copiar el resto del código
COPY . .
WORKDIR "/src/ProyectoFinal"
RUN dotnet publish "ProyectoFinal.csproj" -c Release -o /app/publish

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render asigna el puerto a través de una variable de entorno llamada PORT
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}
EXPOSE 10000

ENTRYPOINT ["dotnet", "ProyectoFinal.dll"]