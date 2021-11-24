using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig
{
    public class SubCategoryConfig:IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> configuration)
        {
            configuration.ToTable("tbl_sub_category");
            configuration.HasAlternateKey(p => p.Title);            
        }
    }
}
