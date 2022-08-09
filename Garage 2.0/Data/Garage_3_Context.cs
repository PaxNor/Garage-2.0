using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage_2._0.Models;

namespace Garage_2._0.Data
{
    public class Garage_3_Context : DbContext
    {
        public Garage_3_Context (DbContextOptions<Garage_3_Context> options)
            : base(options)
        {
        }

        public DbSet<Garage_2._0.Models.Vehicle> Vehicle { get; set; } = default!;

        public DbSet<Garage_2._0.Models.Member>? Member { get; set; }
    }
}
