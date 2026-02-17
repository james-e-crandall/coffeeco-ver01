
using CoffeeCo.MigrationsLib;
using CoffeeCo.UILib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

    builder.Services.AddDbContextPool<UIConfigContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("sqldbUIConfig"), sqlOptions => 
            sqlOptions.MigrationsAssembly("CoffeeCo.UI.MigrServSqlServer"))
            .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

var host = builder.Build();
host.Run();
