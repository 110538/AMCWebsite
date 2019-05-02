using AMC_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AMC_Demo
{
    public class AMCDbContext : DbContext
    {
        public DbSet<DevOpsStatusTable> devOpsStatusTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AMC_DB"].ConnectionString);
        }
    }
}
