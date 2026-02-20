using CoffeeCo.StoreApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddNpgsqlDataSource(connectionName: "postgresdb");

var app = builder.Build();

HealthEndpoints.RegisterEndpoints(app);

app.Run();
