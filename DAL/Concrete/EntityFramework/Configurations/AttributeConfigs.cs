using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Concrete.EntityFramework.Configurations
{
    public class AttributeConfigs : IEntityTypeConfiguration<Entities.Concrete.Attribute>
    {
        public void Configure(EntityTypeBuilder<Entities.Concrete.Attribute> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(50);
        }
    }
}
