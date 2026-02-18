using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace CoffeeCo.UILib.Maps
{
    public class SeedData 
    {

        public static NationalAddress HomeList = new NationalAddress { Id = 1, State = "CA", County = "Los Angeles"};

    }
}