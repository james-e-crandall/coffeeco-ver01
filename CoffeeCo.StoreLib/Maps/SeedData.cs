using System.Runtime.CompilerServices;
using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic;


namespace CoffeeCo.StoreLib.Maps;

public class SeedData 
{

    public static StatePossession[] StatePossessions = new StatePossession[]
    {
        new StatePossession { Id = 1, Abbreviation = "AL", Value = "Alabama" },
        new StatePossession { Id = 2, Abbreviation = "AK", Value = "Alaska" },
    };

}
