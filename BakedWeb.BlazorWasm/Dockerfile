FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BakedWeb.BlazorWasm/BakedWeb.BlazorWasm.csproj", "BakedWeb.BlazorWasm/"]
RUN dotnet restore "BakedWeb.BlazorWasm/BakedWeb.BlazorWasm.csproj"
COPY . .
WORKDIR "/src/BakedWeb.BlazorWasm"
RUN dotnet build "BakedWeb.BlazorWasm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BakedWeb.BlazorWasm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BakedWeb.BlazorWasm.dll"]
