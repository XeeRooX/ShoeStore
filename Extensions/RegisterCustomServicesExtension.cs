using Microsoft.EntityFrameworkCore;
using ShoeStore.Data.EFCore;
using ShoeStore.Data.Repositories;

namespace ShoeStore.Extensions
{
    public static class RegisterCustomServicesExtension
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString));
            services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(Program).Assembly));
            services.AddAutoMapper(typeof(Program));

            services.AddScoped<IShoeRepository, ShoeRepository>();
        }
    }
}
