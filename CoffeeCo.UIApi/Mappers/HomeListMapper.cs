
using CoffeeCo.UIApi.Dtos;
using CoffeeCo.UILib.Models;
using Riok.Mapperly.Abstractions;

namespace CoffeeCo.UIApi.Mappers;

[Mapper(UseDeepCloning = true)]
public static partial class HomeListMapper
{
    [MapperIgnoreSource(nameof(HomeItem.Id))]
    [MapperIgnoreSource(nameof(HomeItem.HomeRowId))]
    [MapperIgnoreSource(nameof(HomeItem.HomeRow))]
    // [MapperIgnoreSource(nameof(HomeItem.Description))]
    // [MapperIgnoreSource(nameof(HomeItem.ImageUrl))]
    public static partial HomeItemDto HomeItemToHomeItemDto(HomeItem homeItem);

    public static partial IQueryable<HomeItemDto> ProjectToDto(this IQueryable<HomeItem> q);

    [MapperIgnoreSource(nameof(HomeRow.Id))]
    [MapperIgnoreSource(nameof(HomeRow.HomeListId))]
    [MapperIgnoreSource(nameof(HomeRow.HomeList))]
    [MapProperty(nameof(HomeRow.HomeItems.Count), nameof(HomeRowDto.HomeItemCount))]
    public static partial HomeRowDto HomeRowToHomeRowDto(HomeRow homeRow);

    public static partial IQueryable<HomeRowDto> ProjectToDto(this IQueryable<HomeRow> q);

    [MapperIgnoreSource(nameof(HomeList.Id))]
    [MapperIgnoreSource(nameof(HomeList.StartDate))]
    [MapperIgnoreSource(nameof(HomeList.Active))]
    [MapperIgnoreSource(nameof(HomeList.Created))]
    [MapperIgnoreSource(nameof(HomeList.Updated))]
    [MapProperty(nameof(HomeList.HomeRows.Count), nameof(HomeListDto.HomeRowCount))]
    public static partial HomeListDto HomeListToHomeListDto(HomeList homeList);

    public static partial IQueryable<HomeListDto> ProjectToDto(this IQueryable<HomeList> q);
    

}
