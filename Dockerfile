FROM mcr.microsoft.com/dotnet/aspnet:7.0
ENV ASPNETCORE_URLS=http://*:5000
WORKDIR /app
COPY publish/ .
EXPOSE 5000
ENTRYPOINT ["dotnet", "rbl-tracker.dll"]