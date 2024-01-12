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
            for ( int i = 16; i <= 55; i++ )
            {
                sizes.Add(new Size() { Id = i - 15, Number = i});
            }

            builder.Entity<Size>().HasData(sizes);
        }
    }
}
