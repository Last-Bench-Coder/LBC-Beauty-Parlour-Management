using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig
{
    public class SecQuestConfig : IEntityTypeConfiguration<SecurityQuestion>
    {
        public void Configure(EntityTypeBuilder<SecurityQuestion> configuration)
        {
            configuration.ToTable("tbl_security_question");
            configuration.HasAlternateKey(p => p.SecQuestion);
        }
    }
}
