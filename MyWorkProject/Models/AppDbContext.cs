﻿using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace MyWorkProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
