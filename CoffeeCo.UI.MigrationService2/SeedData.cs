
using CoffeeCo.UILib.Models;

namespace CoffeeCo.UI.MigrationService2
{
    public class SeedData 
    {
        public static HomeList HomeList = new HomeList { Cols = 2 , StartDate = DateTime.UtcNow, Active = true, Created = DateTime.UtcNow, Updated = DateTime.UtcNow };
        public static HomeRow HomeRow =  new HomeRow {  HomeList = HomeList };
        public static HomeRow[] HomeRows = new HomeRow[] { HomeRow };
        public static HomeItem HomeItem = new HomeItem {  Text="Hello World", HomeRow = HomeRow };
        public static HomeItem[] HomeItems = new HomeItem[] { HomeItem };

        // HomeList firstHomeList = new()
        // {
        //     Cols = 2,
        //     StartDate = DateTime.UtcNow,
        //     //HomeRows = new[] { firstHomeRow }
        // };

        // HomeRow firstHomeRow = new()
        // {
        //     //HomeItems = new[] { firstHomeItem, secondHomeItem }
        //     HomeList = firstHomeList
        // };

        // HomeItem firstHomeItem = new()
        // {
        //     Text = "It's a greate day for coffee",
        //     HomeRow = firstHomeRow
        // };

        // HomeItem secondHomeItem = new()
        // {
        //     Text = "Start am prder",
        //     HomeRow = firstHomeRow
        // };
    }
}