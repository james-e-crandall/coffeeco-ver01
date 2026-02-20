using CoffeeCo.StoreLib.Data;
using CoffeeCo.UI.MigrServPostgresql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDbContextPool<StoreContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgresdb"), sqlOptions => 
        sqlOptions.MigrationsAssembly("CoffeeCo.UI.MigrServPostgresql"))
        .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

var host = builder.Build();
host.Run();
