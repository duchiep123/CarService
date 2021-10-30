using CRUDDocker.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDocker.Maps
{
    public class CarMap
    {
        public CarMap(EntityTypeBuilder<Car> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("Car");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Name).HasColumnName("name");
            entityBuilder.Property(x => x.Color).HasColumnName("color");
        }
    }

}
