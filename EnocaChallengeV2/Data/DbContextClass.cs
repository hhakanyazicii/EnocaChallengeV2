using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnocaChallengeV2.Models;
using Microsoft.EntityFrameworkCore;


namespace EnocaChallengeV2
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options)
            : base(options)
        {
        }

        public DbSet<Firm> Firms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
