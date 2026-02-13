using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.UILib.Maps
{
    public class HomeListMap : IEntityTypeConfiguration<HomeList>
    {
        public void Configure(EntityTypeBuilder<HomeList> builder)
        {

            builder.HasMany(h => h.HomeRows)
                .WithOne(hr => hr.HomeList)
                .HasForeignKey(hr => hr.HomeListId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedData.HomeList);

        }
    }
}
