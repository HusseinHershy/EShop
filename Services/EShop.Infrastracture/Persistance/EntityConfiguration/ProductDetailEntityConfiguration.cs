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
    public class ProductDetailEntityConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(e => e.productDetailId)
                   .HasName("PRIMARYDetail");

            builder.ToTable("ProductDetail");

            builder.Property(e => e.productDetailId)
               .HasColumnType("bigint")
               .HasColumnName("productDetailId");

            builder.Property(e => e.productId)
                .HasColumnType("bigint")
                .HasColumnName("ProductId");



            builder.Property(e => e.Price)
                .HasColumnType("decimal(5,2)")
                .HasColumnName("Price");


            builder.Property(e => e.ActualCost)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ActualCost");


           
           

         

        }
    }
}
