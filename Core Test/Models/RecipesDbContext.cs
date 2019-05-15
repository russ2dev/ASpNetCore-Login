﻿using Microsoft.EntityFrameworkCore;

namespace CoreTest.Models
{
    public class RecipesDbContext : DbContext
    {
        public DbSet<Recipe> 
            Recipes { get; set; }

        public RecipesDbContext(DbContextOptions<RecipesDbContext> options)
            : base(options)
        {
            this.EnsureSeedData();
        }
    }
}
