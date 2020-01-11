FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["api_pdv_change/api_pdv_change.csproj", "api_pdv_change/"]
COPY ["Infra/Infra.csproj", "Infra/"]
COPY ["Model/Entities.csproj", "Model/"]
RUN dotnet restore "api_pdv_change/api_pdv_change.csproj"
COPY . .
WORKDIR "/src/api_pdv_change"
RUN dotnet build "api_pdv_change.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "api_pdv_change.csproj" -c Release -o /app/publish
RUN ["apt-get", "update"]
RUN ["apt-get", "install", "-y", "vim"]

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "api_pdv_change.dll"]

#deploy
FROM base AS final
WORKDIR /app
LABEL Author="Márcio Mendes"
LABEL Maintainer="marciomendes"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api_pdv_change.dll", "--server.urls", "http://*:80"]