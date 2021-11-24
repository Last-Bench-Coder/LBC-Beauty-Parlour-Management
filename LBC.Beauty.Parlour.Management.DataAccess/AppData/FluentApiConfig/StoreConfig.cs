using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig
{
    public class StoreConfig:IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> configuration)
        {
            configuration.ToTable("tbl_store");
            configuration.HasAlternateKey(p => p.Name);
        }
    }
}
