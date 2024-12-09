using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    public class MyDBContext : DbContext
    {
        public DbSet<Personnage> Personnage { get; set; }
        public DbSet<Job> Job { get; set; }

        public MyDBContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public MyDBContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"server=(localdb)\MSSQLLocalDB;database=DemoEF;integrated security=true;trustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
