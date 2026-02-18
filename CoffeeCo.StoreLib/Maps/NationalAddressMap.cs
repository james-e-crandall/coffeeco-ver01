using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.StoreLib.Maps;

public class NationalAddressMap : IEntityTypeConfiguration<NationalAddress>
{
    public void Configure(EntityTypeBuilder<NationalAddress> builder)
    {
        builder.HasKey(na => na.Id);
        builder.Property(na => na.State).IsRequired().HasMaxLength(2);
        builder.Property(na => na.County).IsRequired().HasMaxLength(40);



    }
}