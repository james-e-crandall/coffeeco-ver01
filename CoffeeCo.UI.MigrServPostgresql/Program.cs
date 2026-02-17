

using CoffeeCo.UI.MigrServPostgresql;
using CoffeeCo.UILib.Data;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.AddNpgsqlDbContext<UIConfigContext>(connectionName: "postgresdb");

var host = builder.Build();
host.Run();
