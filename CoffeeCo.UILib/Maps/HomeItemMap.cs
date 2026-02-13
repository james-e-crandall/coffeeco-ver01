using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.UILib.Maps
{
    public class HomeItemMap : IEntityTypeConfiguration<HomeItem>
    {
        public void Configure(EntityTypeBuilder<HomeItem> builder)
        {

            builder.HasOne(hi => hi.HomeRow)
                .WithMany(hr => hr.HomeItems)
                .HasForeignKey(hi => hi.HomeRowId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedData.HomeItems);

        }
    }
}
