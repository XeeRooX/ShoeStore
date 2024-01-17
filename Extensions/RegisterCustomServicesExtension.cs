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
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString),contextLifetime: ServiceLifetime.Scoped);
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
