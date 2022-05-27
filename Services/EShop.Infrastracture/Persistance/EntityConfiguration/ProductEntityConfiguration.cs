using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastracture.Persistance.EntityConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductId)
                   .HasName("PRIMARY");

            builder.ToTable("Product");


            builder.Property(e => e.ProductId)
                .HasColumnType("bigint")
                .HasColumnName("Id");


            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("Name");

            builder.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("CategoryName");

            builder.Property(e => e.Color)
               .HasMaxLength(255)
               .HasColumnName("Color");

            builder.Property(e => e.Description)
             .HasMaxLength(255)
             .HasColumnName("Description");

            builder.Property(e => e.ImageUrl)
            .HasMaxLength(255)
            .HasColumnName("ImageUrl");


            builder.HasOne<ProductDetail>(s => s.ProdutPriceDetails)
           .WithOne(ad => ad.Product)
           .HasForeignKey<ProductDetail>(ad => ad.productId);
        }
    }
}
