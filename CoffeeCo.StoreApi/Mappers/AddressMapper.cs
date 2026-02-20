using CoffeeCo.StoreApi.Dtos;
using CoffeeCo.StoreLib.Models;
using Riok.Mapperly.Abstractions;

namespace CoffeeCo.UIApi.Mappers;

[Mapper(UseDeepCloning = true)]
public static partial class AddressMapper
{
    [MapperIgnoreSource(nameof(Address.Id))]
    [MapperIgnoreSource(nameof(Address.StateId))]
    [MapProperty(nameof(Address.State.Abbreviation), nameof(AddressDto.State))]
    [MapperIgnoreSource(nameof(Address.NationalAddress))]
    [MapperIgnoreSource(nameof(Address.NationalAddressId))]
    public static partial AddressDto HomeItemToHomeItemDto(Address address);

    public static partial IQueryable<AddressDto> ProjectToDto(this IQueryable<Address> q);
    

}
