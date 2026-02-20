using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreLib.Models;

public class Address
{
    public int Id { get; set; }
    /// <summary>
    /// Name of the state or state equivalent 
    /// </summary>

    [Required]
    public required StatePossession State { get; set; }
    [Required]
    public required int StateId { get; set; }
    /// <summary>
    /// Name of county or county-equivalent where the address is
    ///located. Proper-case format with no suffix
    //(i.e. Do not include “… County”) 
    /// </summary>
    [StringLength(40, MinimumLength = 1)]
    [Required]
    public required string County { get; set; }
    /// <summary>
    /// The element of the complete street name that identifies the
    /// particular street (as opposed to any street types, directionals,
    /// and modifiers). At this time, if the point represents a milepost
    /// or landmark, this field will not be required 
    /// </summary>
    [StringLength(60, MinimumLength = 1)]  
    [Required]
    public required string StreetName { get; set; }
    /// <summary>
    /// The whole number identifier of a location along a
    ///thoroughfare or within a defined community. At this time, if
    ///the point represents a milepost or landmark, this field will not
    ///be required 
    /// </summary>
    [Required]
    public required long Add_Number { get; set; }
    /// <summary>
    /// For standard street mail delivery (with a corresponding
    /// geographic delivery area), the system of 5-digit codes that
    /// identifies the individual USPS Post Office associated with an
    /// address. 
    /// </summary>
    [StringLength(7)]
    public string? Zip_Code { get; set; }
    /// <summary>
    /// Zip Plus 4 Addition
    /// occasionally used 
    /// </summary>
    [StringLength(7)]
    public string? Plus_4 { get; set; }

    public NationalAddress? NationalAddress { get; set; }
    public int? NationalAddressId { get; set; }

}