using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.EntityFramework.Configurations
{
    public class ChildCategoryConfigs : IEntityTypeConfiguration<ChildCategory>
    {
        public void Configure(EntityTypeBuilder<ChildCategory> builder)
        {
            builder.HasOne(c => c.ParentCategory).WithMany(p => p.ChildCategories);
        }
    }
}
