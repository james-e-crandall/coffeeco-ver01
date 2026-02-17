namespace CoffeeCo.UILib.Models;

public class HomeItem
{
    public int Id { get; set; }
    public string Text { get; set; }= string.Empty;
    // public string Description { get; set; }= string.Empty;
    // public string ImageUrl { get; set; }= string.Empty;

    public HomeRow HomeRow { get; set; } = null!;
    public int HomeRowId { get; set; }
}
