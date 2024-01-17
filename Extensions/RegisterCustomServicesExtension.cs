using Microsoft.EntityFrameworkCore;
using ShoeStore.Data.EFCore;
using ShoeStore.Data.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using static FluentValidation.DependencyInjectionExtensions;
using ShoeStore.Validators.ShoesValidators;

namespace ShoeStore.Extensions
{
    public static class RegisterCustomServicesExtension
    {
        public static void RegisterCustomServices(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var config = builder.Configuration;

            var connectionString = config.GetConnectionString("DefaultConnection");
            if (builder.Environment.IsDevelopment())
            {
                services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString), contextLifetime: ServiceLifetime.Scoped);
            }
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(connectionString), contextLifetime: ServiceLifetime.Scoped);
            if (builder.Environment.IsProduction())
            {
                services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(connectionString), contextLifetime: ServiceLifetime.Scoped);
            }
            services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(Program).Assembly));
            services.AddAutoMapper(typeof(Program));
            services.AddValidatorsFromAssemblyContaining<GetShoesValidator>();
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

       
            services.AddScoped<IShoeRepository, ShoeRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICollectionTypeRepository, CollectionTypeRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<ISeasonRepository, SeasonRepository>();
            services.AddScoped<IShoeTypeRepository, ShoeTypeRepository>();
            services.AddScoped<ISizeRepository, SizeRepository>();
        }
    }
}
