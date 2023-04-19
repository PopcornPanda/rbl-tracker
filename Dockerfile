FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY publish/rbl-tracker.dll /app/rbl-tracker.dll
EXPOSE 5000
ENTRYPOINT ["dotnet", "rbl-tracker.dll"]