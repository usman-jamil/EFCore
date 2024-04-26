## Run postgress for this sample
```shell
docker compose -f docker-compose-postgres.yml up -d
```

## Run this command in terminal to create the initial migration
```shell
dotnet ef migrations add --project EFCore.Playground.Infrastructure/EFCore.Playground.Infrastructure.csproj --startup-project EFCore.Playground/EFCore.Playground.csproj --context EFCore.Playground.Infrastructure.ApplicationDbContext Initial --output-dir Migrations
```

## Generate the database

You can either use the following command to generat ethe database
```shell
dotnet ef database update --project EFCore.Playground.Infrastructure/EFCore.Playground.Infrastructure.csproj --startup-project EFCore.Playground/EFCore.Playground.csproj --context EFCore.Playground.Infrastructure.ApplicationDbContext
```

Or you can run the sample API to generate the database which will apply the migrations
