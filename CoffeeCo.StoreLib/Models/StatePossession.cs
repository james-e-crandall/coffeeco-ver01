using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreLib.Models;

public class StatePossession
{
    public int Id { get; set; }
    [StringLength(2, MinimumLength = 2)]
    [Required]
    public required string Abbreviation { get; set; }
    [Required]
    public required string Value { get; set; }
    public ICollection<Address> Addresses { get; set; } = new List<Address>(); 
}