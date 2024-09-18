clear
cd  C:\projects\PrometheusRemoteWriteOpenShiftClusters\Code\PrometheusRemoteWriteOpenShiftClusters
dotnet restore
dotnet build
dotnet publish


dotnet restore
dotnet publish -c Release -o /app