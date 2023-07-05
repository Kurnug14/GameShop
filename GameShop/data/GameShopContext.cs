using GameShop.Models;
using Microsoft.EntityFrameworkCore;
namespace Gameshop.Data;

public class GameShopContext : DbContext
{
    public DbSet<GameType> GameTypes { get; set; } = null!;
    public DbSet<Manufacturer> Manufacturer { get; set; } = null!;
    public DbSet<ManufacturerProducts> ManufacturerProducts { get; set; } = null!;
    public DbSet<Products> Products { get; set; } = null!;
    public DbSet<State> State { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GameShop");
    }
}