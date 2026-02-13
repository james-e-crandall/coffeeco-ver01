using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.UILib.Maps
{
    public class HomeRowMap : IEntityTypeConfiguration<HomeRow>
    {
        public void Configure(EntityTypeBuilder<HomeRow> builder)
        {

            builder.HasMany(h => h.HomeItems)
                .WithOne(hi => hi.HomeRow)
                .HasForeignKey(hi => hi.HomeRowId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedData.HomeRows);

        }
    }
}
