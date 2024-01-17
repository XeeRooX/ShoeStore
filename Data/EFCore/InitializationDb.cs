using Microsoft.EntityFrameworkCore;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public static class InitializationDb
    {
        public static void Initialize(ModelBuilder builder, IConfiguration conf)
        {
            builder.Entity<CollectionType>().HasData(
                new CollectionType() { Id = 1, Name = "мужская", ShortName = "муж" },
                new CollectionType() { Id = 2, Name = "женская", ShortName = "жен" },
                new CollectionType() { Id = 3, Name = "детская", ShortName = "дет" }
                );

            builder.Entity<Season>().HasData(
                new Season() { Id = 1, Name = "осень/зима" },
                new Season() { Id = 2, Name = "весна/лето" }
                );

            var sizes = new List<Size>();
            for (int i = 16; i <= 55; i++)
            {
                sizes.Add(new Size() { Id = i - 15, Number = i });
            }

            builder.Entity<Size>().HasData(sizes);


            // Ниже не обязательные для добавления
            if (conf.GetValue<bool>("GenerateDemoData"))
            {
                InitDemoData(builder);
            }
        }

        private static void InitDemoData(ModelBuilder builder)
        {
            builder.Entity<Color>().HasData(
            new Color() { Id = 1, Name = "черный" },
            new Color() { Id = 2, Name = "белый" }
            );

            builder.Entity<Brand>().HasData(
                new Brand() { Id = 1, Name = "Adidas" },
                new Brand() { Id = 2, Name = "Reebok" }
                );

            builder.Entity<Model>().HasData(
                new Model() { Id = 1, Name = "TREZIOD", BrandId = 1 },
                new Model() { Id = 2, Name = "HANDBALL", BrandId = 1 },
                new Model() { Id = 3, Name = "CL", BrandId = 2 },
                new Model() { Id = 4, Name = "BB 4000", BrandId = 2 }
                );

            builder.Entity<ShoeType>().HasData(
                new ShoeType() { Id = 1, Name = "кроссовки" },
                new ShoeType() { Id = 2, Name = "ботинки" }
                );

            builder.Entity<Shoe>().HasData(
                new Shoe() { Id = 1, Price = 1200, CollectionTypeId = 1, ColorId = 1, ModelId = 1, SeasonId = 2, ShoeTypeId = 1, SizeId = 27 },
                new Shoe() { Id = 2, Price = 1250, CollectionTypeId = 1, ColorId = 1, ModelId = 1, SeasonId = 2, ShoeTypeId = 1, SizeId = 28 },
                new Shoe() { Id = 3, Price = 1300, CollectionTypeId = 1, ColorId = 2, ModelId = 1, SeasonId = 2, ShoeTypeId = 1, SizeId = 29 },
                new Shoe() { Id = 4, Price = 1100, CollectionTypeId = 1, ColorId = 2, ModelId = 2, SeasonId = 2, ShoeTypeId = 1, SizeId = 28 },
                new Shoe() { Id = 5, Price = 1100, CollectionTypeId = 1, ColorId = 2, ModelId = 2, SeasonId = 2, ShoeTypeId = 1, SizeId = 26 },
                new Shoe() { Id = 6, Price = 1100, CollectionTypeId = 1, ColorId = 1, ModelId = 2, SeasonId = 2, ShoeTypeId = 1, SizeId = 27 },
                new Shoe() { Id = 7, Price = 1400, CollectionTypeId = 1, ColorId = 1, ModelId = 3, SeasonId = 2, ShoeTypeId = 1, SizeId = 26 },
                new Shoe() { Id = 8, Price = 1400, CollectionTypeId = 1, ColorId = 2, ModelId = 3, SeasonId = 2, ShoeTypeId = 1, SizeId = 27 }
                );
        }

        public static void Migrate(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var dbContext = services.GetRequiredService<ApplicationDbContext>();
                if (dbContext != null && dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
