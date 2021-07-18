using BroadageSportsWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadageSportWeb
{
    public static class StartupConfiguration
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BroadageSportsContext>(option => option.UseSqlServer(configuration["ConnectionStrings:LocalDatabase"].ToString(), o => { o.MigrationsAssembly("BroadageSportWeb"); }));
            services.AddDbContext<BroadageSportsContext>(c => c.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }
    }
}
