using Integrationflow_Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrationflow_DAL
{
    public class Context: DbContext
    {
        public DbSet<ConversionRate> ConvertionsRate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=51.138.35.230;Database=testuser4;User Id=test4;Password=casper;");
        }
    }
}
