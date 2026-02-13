namespace CoffeeCo.UILib.Models;

public class HomeItem
{
    public int Id { get; set; }
    public string Text { get; set; }= string.Empty;
    //public int HomeRowId { get; set; }
    public HomeRow HomeRow { get; set; } = null!;
    public int HomeRowId { get; set; }
}
