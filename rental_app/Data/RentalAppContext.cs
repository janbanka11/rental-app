using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rental_app.Models;
namespace rental_app.Data;

public class RentalAppContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Genres> Genres { get; set; } = null!;
    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<ItemType> ItemTypes { get; set; } = null!;
    public DbSet<Rental> Rentals { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\banka\Source\Repos\rental-app\rental_app\RentalDatabase.mdf;Integrated Security=True");
    }

}

