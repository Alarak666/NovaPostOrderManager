dotnet ef database drop --force --context ApplicationDbContext --project ERP.Data\ERP.Data.csproj --startup-project ERP.API\ERP.API.csproj
dotnet ef migrations remove --context ApplicationDbContext --project ERP.Data\ERP.Data.csproj --startup-project ERP.API\ERP.API.csproj
dotnet ef migrations add initial --context ApplicationDbContext --project ERP.Data\ERP.Data.csproj --startup-project ERP.API\ERP.API.csproj
dotnet ef database update --context ApplicationDbContext --project ERP.Data\ERP.Data.csproj --startup-project ERP.API\ERP.API.csproj