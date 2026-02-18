using CoffeeCo.StoreLib.Maps;
using CoffeeCo.StoreLib.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCo.StoreLib.Data;

public partial class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options) { }

    public DbSet<NationalAddress> NationalAddresses => Set<NationalAddress>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        modelBuilder.ApplyConfiguration(new NationalAddressMap());
    }

}