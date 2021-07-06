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
            optionsBuilder.UseSqlServer(@"Insert ConnectionString Here");
        }
    }
}
