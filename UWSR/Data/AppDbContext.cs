﻿using Microsoft.EntityFrameworkCore;
using UWSR.Models;

namespace UWSR.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Link> Links { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}