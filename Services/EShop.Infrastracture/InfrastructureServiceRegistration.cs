
using EShop.Application.Contract.Persistance;
using EShop.Infrastracture.Persistance;
using EShop.Infrastracture.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace EShop.Infrastracture
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ProductContext>(options =>
            options.UseSqlServer(connectionString));


            services.AddTransient<IUnitOfWork, UnitOfWork>();
            


            return services;
        }
    }
}
