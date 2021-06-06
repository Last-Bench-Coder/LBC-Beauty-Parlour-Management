using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig
{
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> configuration)
        {
            configuration.ToTable("tbl_admin");
            configuration.HasAlternateKey(p => new { p.EmailId, p.Phone });
        }
    }
}
