using System.Diagnostics;
using CoffeeCo.UILib.Data;
using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoffeeCo.UI.MigrServPostgresql;

public class Worker(
    IServiceProvider serviceProvider,
    IHostApplicationLifetime hostApplicationLifetime) : BackgroundService
{
    public const string ActivitySourceName = "Migrations";
    private static readonly ActivitySource s_activitySource = new(ActivitySourceName);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var activity = s_activitySource.StartActivity(
            "Migrating database", ActivityKind.Client);

        try
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<UIConfigContext>();

            await RunMigrationAsync(dbContext, stoppingToken);
            //await SeedDataAsync(dbContext, stoppingToken);
        }
        catch (Exception ex)
        {
            activity?.AddException(ex);
            throw;
        }

        hostApplicationLifetime.StopApplication();
    }

    private static async Task RunMigrationAsync(
        UIConfigContext dbContext, CancellationToken cancellationToken)
    {
        var strategy = dbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            // Run migration in a transaction to avoid partial migration if it fails.
            await dbContext.Database.MigrateAsync(cancellationToken);
        });
    }

    // private static async Task SeedDataAsync(
    //     UIConfigContext dbContext, CancellationToken cancellationToken)
    // {


    //     var strategy = dbContext.Database.CreateExecutionStrategy();
    //     await strategy.ExecuteAsync(async () =>
    //     {
    //         // Seed the database
    //         Console.WriteLine("Seeding database...");
    //         await using var transaction = await dbContext.Database
    //             .BeginTransactionAsync(cancellationToken);
            
    //         await CreateHomeListAsync(dbContext, cancellationToken);

    //         await dbContext.SaveChangesAsync(cancellationToken);
    //         await transaction.CommitAsync(cancellationToken);
    //     });
    // }

    // private static async Task CreateHomeListAsync(UIConfigContext dbContext, CancellationToken cancellationToken)
    // {
    //     var homeList = new HomeList
    //     {
    //         Cols = 2,
    //         StartDate = DateTime.UtcNow,
    //         Active = true,
    //         Created = DateTime.UtcNow,
    //         Updated = DateTime.UtcNow
    //     };

    //     await dbContext.HomeLists.AddAsync(homeList, cancellationToken);

    //     foreach(var homeItem in SeedData.HomePageStart)
    //     {
    //         var homeRow = new HomeRow
    //         {
    //             HomeList = homeList,
    //             HomeItems = { homeItem }
    //         };

    //         homeRow.HomeItems.Add(homeItem);
    //         homeList.HomeRows.Add(homeRow);

    //         await dbContext.HomeItems.AddAsync(homeItem, cancellationToken);
    //         await dbContext.HomeRows.AddAsync(homeRow, cancellationToken);
    //     }
    // }   


}
