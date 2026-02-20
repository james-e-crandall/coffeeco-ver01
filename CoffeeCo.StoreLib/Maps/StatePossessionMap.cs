using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.StoreLib.Maps;

public class StatePossessionMap : IEntityTypeConfiguration<StatePossession>
{
    public void Configure(EntityTypeBuilder<StatePossession> builder)
    {
        builder.HasKey(na => na.Id);
        builder.HasMany(p => p.Addresses)
               .WithOne(b => b.State)
               .HasForeignKey(p => p.StateId);

        // Add all other configurations for the Blog entity here
        builder.HasData(
            SeedData.StatePossessions);
    }
}