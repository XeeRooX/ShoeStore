﻿using Microsoft.EntityFrameworkCore;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<CollectionType> CollectionTypes { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
        public DbSet<Model> Models { get; set; } = null!;
        public DbSet<Season> Seasons { get; set; } = null!;
        public DbSet<Shoe> Shoes { get; set; } = null!;
        public DbSet<ShoeType> ShoeTypes { get; set; } = null!;
        public DbSet<Size> Sizes { get; set; } = null!;

        private readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            InitializationDb.Initialize(modelBuilder, _configuration);
        }

    }
}
