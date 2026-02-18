using System.ComponentModel.DataAnnotations;

namespace CoffeeCo.StoreApi.Dtos;

public class NationalAddressDto
{
    public int Id { get; set; }

    /// <summary>
    /// State
    /// always used 
    /// </summary>
    [StringLength(2, MinimumLength = 2)]
    [Required]
    public required string State { get; set; }

    /// <summary>
    /// County
    /// always used
    /// </summary>
    [StringLength(40, MinimumLength = 1)]
    [Required]
    public required string County { get; set; }

    /// <summary>
    /// Incorporated Municipality 
    /// commonly used
    /// </summary>
    [StringLength(100)]
    public string? Inc_Muni { get; set; }
    /// <summary>
    /// Unincorporated Community 
    /// commonly used
    /// </summary>
    [StringLength(100)]
    public string? Uninc_Comm { get; set; }
    /// <summary>
    /// Neighborhood Community 
    /// commonly used
    /// </summary>
    [StringLength(100)]
    public string? Nbrhd_Comm { get; set; }
    /// <summary>
    /// Postal Community Name 
    /// commonly used
    /// </summary>
    [StringLength(40)]
    public string? Post_Comm { get; set; }
    /// <summary>
    /// ZIP Code
    /// commonly used 
    /// </summary>
    [StringLength(7)]
    public string? Zip_Code { get; set; }
    /// <summary>
    /// Zip Plus 4 Addition
    /// occasionally used 
    /// </summary>
    [StringLength(7)]
    public string? Plus_4 { get; set; }
    /// <summary>
    /// Bulk Delivery ZIP Code 
    /// rarely used 
    /// </summary>
    [StringLength(7)]
    public string? Bulk_Zip { get; set; }
    /// <summary>
    /// Bulk Delivery ZIP Plus 4 Addition 
    /// rarely used 
    /// </summary>
    [StringLength(7)]
    public string? Bulk_Plus4 { get; set; }

    /// <summary>
    /// Street Name Pre-Modifier ( PRM ) 
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? StN_PreMod { get; set; }

    /// <summary>
    /// Street Name Pre-Directional ( PRD ) 
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? StN_PreDir { get; set; }

    /// <summary>
    /// Street Name Pre-Type ( STP )
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? StN_PreTyp { get; set; }

    /// <summary>
    ///  Street Name Pre-Type Separator ( STPS ) 
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? StN_PreSep { get; set; }

    /// <summary>
    ///  Street Name ( RD )
    /// always used *
    /// </summary>
    [StringLength(60, MinimumLength = 1)]  
    [Required]
    public required string StreetName { get; set; }

    /// <summary>
    ///  Street Name Post-Type ( STS ) 
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? StN_PosTyp { get; set; }

    /// <summary>
    ///  Street Name Post-Directional ( POD ) 
    /// commonly used
    /// </summary>
    [StringLength(50)]
    public string? StN_PosDir { get; set; }

    /// <summary>
    ///  Street Name Post-Modifier ( POM ) 
    /// commonly used
    /// </summary>
    [StringLength(25)]
    public string? StN_PosMod { get; set; }

    /// <summary>
    ///  Address number prefix ( HNP )
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? AddNum_Pre { get; set; }

    /// <summary>
    ///  Address number ( HNO ) 
    /// commonly used
    /// </summary>
    public long? Add_Number { get; set; }

    /// <summary>
    ///  Address number suffix ( HNS ) 
    /// commonly used
    /// </summary>
    [StringLength(15)]
    public string? AddNum_Suf { get; set; }

    /// <summary>
    ///  Landmark Name Part ( LMKP ) 
    /// occasionally used 
    /// </summary>
    [StringLength(150)]
    public string? LandmkPart { get; set; }

    /// <summary>
    ///  Landmark ( LMK ) 
    /// occasionally used 
    /// </summary>
    [StringLength(150)]
    public string? LandmkName { get; set; }

    /// <summary>
    ///  Building ( BLD ) 
    /// commonly used
    /// </summary>
    [StringLength(75)]
    public string? Building { get; set; }

    /// <summary>
    ///  Floor ( FLR ) 
    /// commonly used
    /// </summary>
    [StringLength(75)]
    public string? Floor { get; set; }

    /// <summary>
    ///  Unit ( UNIT ) 
    /// commonly used
    /// </summary>
    [StringLength(75)]
    public string? Unit { get; set; }

    /// <summary>
    ///  Room ( ROOM ) 
    /// commonly used
    /// </summary>
    [StringLength(75)]
    public string? Room { get; set; }


}