using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challange.Services.Product.Infrastructure
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.ProductAggregate.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.ProductAggregate.Product>().ToTable("Products");
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.ProdDesc).HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.Sku).HasColumnType("nvarchar").HasMaxLength(15);
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.CategoryId).HasColumnType("nvarchar").HasMaxLength(15);
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.PictureUrl).HasColumnType("nvarchar").HasMaxLength(100);
            modelBuilder.Entity<Domain.ProductAggregate.Product>().Property(x => x.CreatedByUserId).HasColumnType("nvarchar").HasMaxLength(100);
            base.OnModelCreating(modelBuilder);
        }
    }
}
