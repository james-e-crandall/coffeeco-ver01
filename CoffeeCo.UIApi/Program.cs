using CoffeeCo.UIApi.Endpoints;
using CoffeeCo.UILib.Data;
using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// builder.Services.AddDbContextPool<UIConfigContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("sqldbUIConfig"));

builder.AddSqlServerDbContext<UIConfigContext>(connectionName: "sqldbUIConfig");

var app = builder.Build();

HealthEndpoints.RegisterEndpoints(app);

HomeEndpoints.RegisterEndpoints(app);

app.Run();
