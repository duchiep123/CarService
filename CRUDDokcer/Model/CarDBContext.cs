using CRUDDocker.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDocker.Model
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions options)
       : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().Property(c => c.Id).ValueGeneratedOnAdd();
        }
    }
}
