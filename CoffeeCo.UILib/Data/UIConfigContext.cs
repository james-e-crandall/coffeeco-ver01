namespace CoffeeCo.UILib.Data;

using CoffeeCo.UILib.Models;
using Microsoft.EntityFrameworkCore;
using CoffeeCo.UILib.Maps;

public partial class UIConfigContext : DbContext
{
    public UIConfigContext(DbContextOptions<UIConfigContext> options)
        : base(options) { }

    public DbSet<HomeItem> HomeItems => Set<HomeItem>();
    public DbSet<HomeRow> HomeRows => Set<HomeRow>();
    public DbSet<HomeList> HomeLists => Set<HomeList>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        // modelBuilder.ApplyConfiguration(new HomeListMap());
        // modelBuilder.ApplyConfiguration(new HomeRowMap());
        // modelBuilder.ApplyConfiguration(new HomeItemMap());
    }

}