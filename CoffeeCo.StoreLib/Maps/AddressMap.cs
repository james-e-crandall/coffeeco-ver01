using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCo.StoreLib.Maps;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(na => na.Id);
        builder.HasOne(p => p.State)
               .WithMany(b => b.Addresses)
               .HasForeignKey(p => p.StateId);
        builder.HasOne(p => p.NationalAddress)
               .WithOne(b => b.Address)
               .HasForeignKey<NationalAddress>(p => p.AddressId);



    }
}