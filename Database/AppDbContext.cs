﻿using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<TodoTask> Tasks { get; set; }

    }
}
