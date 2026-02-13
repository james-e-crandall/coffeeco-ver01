using CoffeeCo.UI.MigrationService2;
using CoffeeCo.UILib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = Host.CreateApplicationBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

//builder.AddSqlServerDbContext<UIConfigContext>("sqldbUIConfig");

builder.Services.AddDbContextPool<UIConfigContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqldbUIConfig"), sqlOptions => 
        sqlOptions.MigrationsAssembly("CoffeeCo.UI.MigrationService2"))
        .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

var host = builder.Build();
host.Run();
