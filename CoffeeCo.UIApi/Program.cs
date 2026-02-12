using CoffeeCo.UIApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

HealthEndpoints.RegisterEndpoints(app);

app.Run();
