using Microsoft.Identity.Client;

namespace CoffeeCo.UIApi.Dtos;

public class HomeListDto
{
    public int Cols { get; set; }
    public ICollection<HomeRowDto> HomeRows { get; set; } = new List<HomeRowDto>();
    public int HomeRowCount { get; set; }
}