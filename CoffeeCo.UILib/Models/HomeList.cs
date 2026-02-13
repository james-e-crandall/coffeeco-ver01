namespace CoffeeCo.UILib.Models;

public class HomeList
{
    public int Id { get; set; }
    public int Cols { get; set; }
    public ICollection<HomeRow> HomeRows { get; set; } = new List<HomeRow>();
    public DateTime StartDate { get; set; }
    public bool Active { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

}
