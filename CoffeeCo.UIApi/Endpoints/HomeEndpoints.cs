

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

        homeItems.MapGet("/GetHomeItems", GetHomeItems);

        static async Task<Results<Ok<List<HomeListDto>>, BadRequest<string>>> GetHomeItems([FromServices] ILogger<Program> logger, UIConfigContext context)
        {
            var results = context.HomeLists
                .Include(x => x.HomeRows)
                .ThenInclude(x => x.HomeItems)
                .ProjectToDto().ToList();
            return TypedResults.Ok(results); 
        }

    }

}


