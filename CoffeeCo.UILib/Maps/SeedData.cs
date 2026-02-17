using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace CoffeeCo.UILib.Maps
{
    public class SeedData 
    {

        public static HomeList HomeList = new HomeList { Id = 1, Cols = 2 , StartDate = DateTime.UtcNow, Active = true, Created = DateTime.UtcNow, Updated = DateTime.UtcNow };
        public static HomeRow HomeRow =  new HomeRow { Id = 1, HomeListId = HomeList.Id };
        public static HomeRow[] HomeRows = new HomeRow[] { HomeRow };
        public static HomeItem HomeItem = new HomeItem { Id = 1, Text="Hello World", HomeRowId = HomeRow.Id };
        public static HomeItem[] HomeItems = new HomeItem[] { HomeItem };
    }
}