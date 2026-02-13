using CoffeeCo.UILib.Data;
using CoffeeCo.UIMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<ApiDbInitializer>();

builder.AddServiceDefaults();

builder.Services.AddDbContextPool<UIConfigContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqldbUIConfig"), sqlOptions => 
        sqlOptions.MigrationsAssembly("CoffeeCo.UI.MigrationService")
    ));

builder.EnrichSqlServerDbContext<UIConfigContext>();

var app = builder.Build();

app.Run();
