FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY Dat251TaxiAPI Dat251TaxiAPI
RUN dotnet build Dat251TaxiAPI/Web/Web.csproj
CMD "dotnet" "run" "--project" "Dat251TaxiAPI\Web\Web.csproj"