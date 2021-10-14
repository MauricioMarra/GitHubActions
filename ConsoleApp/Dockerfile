#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Copia runtime do dotnet e cria imagem
FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app


#Copia SDK do dotnet, cria imagem, copia meu projeto e faz o build
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ConsoleApp/ConsoleApp.csproj", "ConsoleApp/"]
RUN dotnet restore "ConsoleApp/ConsoleApp.csproj"
COPY . .
WORKDIR "/src/ConsoleApp"
RUN dotnet build "ConsoleApp.csproj" -c Debug -o /app/build
#RUN dotnet build "ConsoleApp.csproj" -c Release -o /app/build


#Com a imagem de cima, faz o publish para a pasta /app/publish
FROM build AS publish
RUN dotnet publish "ConsoleApp.csproj" -c Debug -o /app/publish
#RUN dotnet publish "ConsoleApp.csproj" -c Release -o /app/publish


#Usando a imagem do runtime, executa meu projeto
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp.dll"]
#ENTRYPOINT ["dotnet", "ConsoleApp.dll"]