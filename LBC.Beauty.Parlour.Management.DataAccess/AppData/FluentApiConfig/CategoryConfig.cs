using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig
{
    public class CategoryConfig:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> configuration)
        {
            configuration.ToTable("tbl_category");
            configuration.HasAlternateKey(p => p.Title);
        }
    }
}
