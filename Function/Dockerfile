FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Function/Function.csproj", "Function/"]
RUN dotnet restore "Function/Function.csproj"
COPY . .
WORKDIR "/src/Function"
RUN dotnet build "Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Function.dll"]
