using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Models
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Wallet>().ToTable("Wallet");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
            modelBuilder.Entity<Order>().ToTable("Orders");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

