using Energy.Domain.Aggregates.Organization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Energy.Infrastructure
{
    public static class StartupExtensions
    {
        public static IServiceCollection InitInfrastructure(this IServiceCollection services) => 
            services
            .AddDbContext<DatabaseContext>(opt =>
            {
                //opt.UseLazyLoadingProxies();
                opt.UseSqlite("Filename=EnergyDB.db");
            });

    }
}
