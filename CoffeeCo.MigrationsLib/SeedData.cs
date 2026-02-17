using CoffeeCo.UILib.Models;

namespace CoffeeCo.MigrationsLib;

public class SeedData 
{
    public static HomeItem[] HomePageStart = new HomeItem[] { 
        new HomeItem { Id = 1, Text = "Espresso", },
        new HomeItem { Id = 2, Text = "Latte", },
        new HomeItem { Id = 3, Text = "Cappuccino",  },
        new HomeItem { Id = 4, Text = "Americano", },
        new HomeItem { Id = 5, Text = "Mocha", }
    };

    // public static HomeItem[] HomePageStart = new HomeItem[] { 
    //     new HomeItem { Id = 1, Text = "Espresso", Description = "A strong and concentrated coffee made by forcing hot water through finely-ground coffee beans.", ImageUrl = "https://example.com/images/espresso.jpg" },
    //     new HomeItem { Id = 2, Text = "Latte", Description = "A creamy coffee drink made with espresso and steamed milk, often topped with foam.", ImageUrl = "https://example.com/images/latte.jpg" },
    //     new HomeItem { Id = 3, Text = "Cappuccino", Description = "A coffee drink that is similar to a latte but has a thicker layer of foam on top.", ImageUrl = "https://example.com/images/cappuccino.jpg" },
    //     new HomeItem { Id = 4, Text = "Americano", Description = "A simple coffee drink made by diluting espresso with hot water.", ImageUrl = "https://example.com/images/americano.jpg" },
    //     new HomeItem { Id = 5, Text = "Mocha", Description = "A chocolate-flavored coffee drink made with espresso, steamed milk, and chocolate syrup.", ImageUrl = "https://example.com/images/mocha.jpg" }
    // };

}