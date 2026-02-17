

using CoffeeCo.UIApi.Dtos;
using CoffeeCo.UIApi.Mappers;
using CoffeeCo.UILib.Data;
using CoffeeCo.UILib.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace   CoffeeCo.UIApi.Endpoints;

public static class HomeEndpoints
{
    public static void RegisterEndpoints(this WebApplication app)
    {

        var homeItems = app.MapGroup("/home");

        homeItems.MapGet("/HomeLists/all", GetAll);
        homeItems.MapGet("/HomeLists/current", GetCurrent);

        static async Task<Results<Ok<List<HomeListDto>>, BadRequest<string>>> GetAll([FromServices] ILogger<Program> logger, UIConfigContext context)
        {
            var results = context.HomeLists
                .Include(x => x.HomeRows)
                .ProjectToDto().ToList();
            return TypedResults.Ok(results); 
        }

        static async Task<Results<Ok<HomeListDto>, BadRequest<string>>> GetCurrent([FromServices] ILogger<Program> logger, UIConfigContext context)
        {
            var total = context.HomeLists
                .Include(x => x.HomeRows)
                .ProjectToDto().ToList();
            Console.WriteLine($"Total HomeLists: {total.Count}");

            var results = context.HomeLists
                .Include(x => x.HomeRows)
                .ThenInclude(x => x.HomeItems)
                .Where(x => x.Active)
                .OrderByDescending(x => x.StartDate)
                .ProjectToDto().FirstOrDefault();
            return TypedResults.Ok(results); 
        }


    }

}


