FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY charts/receipts/src/Com.Refund.Services.Receipts/Com.Refund.Services.Receipts.csproj Com.Refund.Services.Receipts/
RUN dotnet restore Com.Refund.Services.Receipts/Com.Refund.Services.Receipts.csproj

COPY charts/receipts/src/Com.Refund.Services.Receipts/ Com.Refund.Services.Receipts/
RUN dotnet build Com.Refund.Services.Receipts/Com.Refund.Services.Receipts.csproj --no-restore -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Com.Refund.Services.Receipts/Com.Refund.Services.Receipts.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Com.Refund.Services.Receipts.dll"]
