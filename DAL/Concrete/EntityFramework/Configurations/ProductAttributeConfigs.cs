using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.EntityFramework.Configurations
{
    public class ProductAttributeConfigs : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.HasKey(pa => new { pa.AttributeId,pa.ProductId,pa.Value});
            builder.HasOne(pa => pa.Attribute).WithMany(a => a.ProductAttribute).HasForeignKey(pa => pa.AttributeId);
            builder.HasOne(p => p.Product).WithMany(p => p.ProductAttribute).HasForeignKey(pa => pa.ProductId);
        }
    }
}
