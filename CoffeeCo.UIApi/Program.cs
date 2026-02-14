using CoffeeCo.UIApi.Endpoints;
using CoffeeCo.UILib.Data;
using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddSqlServerDbContext<UIConfigContext>(connectionName: "sqldbUIConfig",
    configureDbContextOptions: options =>
{
    // if (builder.Environment.IsDevelopment())
    // {
    //     options.UseSeeding((context, _) =>
    //     {
    //         var homeList = context.Set<HomeList>()
    //             .FirstOrDefault(t => t.Id == 1);
    //         if (homeList is null)
    //         {
    //             context.Set<HomeList>().Add(new HomeList
    //             {
    //                 Id = 1
    //             });
    //             context.SaveChanges();
    //         }

    //     });

    //     options.UseAsyncSeeding(async (context, _, cancellationToken) =>
    //     {
    //         var homeList = await context.Set<HomeList>()
    //             .FirstOrDefaultAsync(t => t.Id == 1, cancellationToken);
    //         if (homeList is null)
    //         {
    //             context.Set<HomeList>().Add(new HomeList
    //             {
    //                 Id = 1
    //             });
    //             await context.SaveChangesAsync(cancellationToken);
    //         }
    //     });
    // }
});


var app = builder.Build();

HealthEndpoints.RegisterEndpoints(app);

HomeEndpoints.RegisterEndpoints(app);

app.Run();
