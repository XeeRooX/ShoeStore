using Microsoft.EntityFrameworkCore;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public static class InitializationDb
    {
        public static void Initialize(ModelBuilder builder)
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
            builder.Entity<Color>().HasData(
                new Color() { Id = 1, Name = "черный" },
                new Color() { Id = 2, Name = "белый" }
                );

            builder.Entity<Brand>().HasData(
                new Brand() { Id = 1, Name = "Adidas" },
                new Brand() { Id = 2, Name = "Reebok" }
                );

            builder.Entity<Model>().HasData(
                new Model() { Id = 1, Name = "AdidasModel1", BrandId = 1 },
                new Model() { Id = 2, Name = "AdidasModel2", BrandId = 1 },
                new Model() { Id = 3, Name = "ReebokModel1", BrandId = 2 },
                new Model() { Id = 4, Name = "ReebokModel2", BrandId = 2 }
                );

            builder.Entity<ShoeType>().HasData(
                new ShoeType() { Id = 1, Name = "кроссовки" },
                new ShoeType() { Id = 2, Name = "ботинки" }
                );
        }
    }
}
