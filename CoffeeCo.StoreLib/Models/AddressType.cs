using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreLib.Models;

public class AddressType
{
    public int Id { get; set; }
    [StringLength(40)]
    public string Value { get; set; } = string.Empty;
}