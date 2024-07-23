using Domain.Entities;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SaleLine> SaleLines { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasDiscriminator<UserType>("UserType").HasValue<Admin>(UserType.Admin).HasValue<Client>(UserType.Client);

            modelBuilder.Entity<User>().HasDiscriminator<UserType>("UserType")
                .HasValue<Admin>(UserType.Admin)
                .HasValue<Client>(UserType.Client);

            modelBuilder.Entity<Client>()
                .HasMany(s => Carts)
                .WithMany(s => Clients);

            modelBuilder.Entity<Product>()
                .HasMany(s => SaleLines)
                .WithMany(s => Products);

            modelBuilder.Entity<Cart>()
                .HasOne(r => SaleLines)
                .WithMany(r => Carts);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
