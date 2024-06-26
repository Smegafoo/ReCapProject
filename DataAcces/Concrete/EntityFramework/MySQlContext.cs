using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class MySQlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=ReCapProject;User=root;Password=Smegafoo;",
               new MySqlServerVersion(new Version(8, 0, 37)),
               options => options.EnableRetryOnFailure(
                   maxRetryCount: 5,
                   maxRetryDelay: System.TimeSpan.FromSeconds(30),
                   errorNumbersToAdd: null)
               );
        
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
    }

  
}
