using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreLib.Models;

public class NationalAddress
{
    public int Id { get; set; }
    [StringLength(2, MinimumLength = 2)]
    [Required]
    public required string State { get; set; }
    [StringLength(40, MinimumLength = 1)]
    [Required]
    public required string County { get; set; }

}