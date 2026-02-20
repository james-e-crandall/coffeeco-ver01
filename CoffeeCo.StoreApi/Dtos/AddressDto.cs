using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreApi.Dtos;

public class AddressDto
{
    [Required]
    public required string State { get; set; }
    [StringLength(40, MinimumLength = 1)]
    [Required]
    public required string County { get; set; }
    [StringLength(60, MinimumLength = 1)]  
    [Required]
    public required string StreetName { get; set; }
    [Required]
    public required long Add_Number { get; set; }
    [StringLength(7)]
    public string? Zip_Code { get; set; }
    [StringLength(7)]
    public string? Plus_4 { get; set; }

}