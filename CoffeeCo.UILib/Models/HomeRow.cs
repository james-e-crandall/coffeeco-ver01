namespace CoffeeCo.UILib.Models;

public class HomeRow
{
    public int Id { get; set; }

    public ICollection<HomeItem> HomeItems { get; set; } = new List<HomeItem>();

    public HomeList HomeList { get; set; } = null!;
    public int HomeListId { get; set; }
}
