

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace   CoffeeCo.StoreApi.Endpoints;

public static class HealthEndpoints
{
    public static void RegisterEndpoints(this WebApplication app)
    {

        var homeItems = app.MapGroup("/health");

        homeItems.MapGet("/", GetHealth);

        static async Task<Results<Ok<string>, BadRequest<string>>> GetHealth([FromServices] ILogger<Program> logger)
        {
            logger.LogInformation("Health check endpoint called.");
            return TypedResults.Ok("Service is healthy.");
        }

    }

}


