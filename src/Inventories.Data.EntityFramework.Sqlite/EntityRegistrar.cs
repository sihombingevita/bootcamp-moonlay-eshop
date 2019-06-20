using ExtCore.Data.EntityFramework;
using Inventories.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventories.Data.EntityFramework.Sqlite
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(etb =>
                {
                    etb.ToTable("Products");
                    etb.HasKey(e => e.Id);

                    etb.Property(e => e.Id).ValueGeneratedOnAdd();
                    etb.Property(e => e.SKU).HasMaxLength(10).IsRequired();
                    etb.Property(e => e.Name).HasMaxLength(128).IsRequired();

                    etb.HasMany(e => e.ProductCategories).WithOne(e => e.Product);
                }
            );

            modelBuilder.Entity<ProductCategory>(etb =>
            {
                etb.ToTable("ProductCategories");
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id).ValueGeneratedOnAdd();

                etb.HasOne(e => e.Category).WithMany(p => p.ProductCategories);
                etb.HasOne(e => e.Product).WithMany(p => p.ProductCategories);
            });

            modelBuilder.Entity<Category>(etb =>
            {
                etb.ToTable("Categories");
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id).ValueGeneratedOnAdd();
                etb.Property(e => e.Name).HasMaxLength(128).IsRequired();

                etb.HasMany(e => e.ProductCategories).WithOne(e => e.Category);
            });
        }
    }
}