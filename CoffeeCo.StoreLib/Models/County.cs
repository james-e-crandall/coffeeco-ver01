using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreLib.Models;

public class County
{
    public int Id { get; set; }
    [StringLength(2, MinimumLength = 2)]
    public string Abbreviation { get; set; } = string.Empty;
    [StringLength(40)]
    public string Name { get; set; } = string.Empty;
}