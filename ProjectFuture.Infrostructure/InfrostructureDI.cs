using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectFuture.Application.IBaseRepositories;
using ProjectFuture.Infrostructure.BaseRepositories;
using ProjectFuture.Infrostructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFuture.Infrostructure
{
    public static class InfrostructureDI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration conf)
        {
            services.AddDbContext<ProjectFutureDbContext>(options =>
            {
                options.UseNpgsql(conf.GetConnectionString("ProjectFutureConnectionString"));
            });

            return services;
        }
    }
}
