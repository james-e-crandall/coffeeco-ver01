namespace CoffeeCo.UIApi.Dtos;

public class HomeRowDto
{
    public ICollection<HomeItemDto> HomeItems { get; set; } = new List<HomeItemDto>();
}