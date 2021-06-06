using LBC.Beauty.Parlour.Management.DataAccess.AppData.FluentApiConfig;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.AppData
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Admin> Administrators { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new SecQuestConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }
    }
}
