using Futbolchi.Services;
using Futbolchi.Services.IRepositories;
using Futbolchi.Services.Repositories;
using Futbolchi2.DATA.DbContext2;
using Microsoft.EntityFrameworkCore;
namespace Futbolchi.Extencions
{
    public static class MiddleWare
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(p => p.UseSqlServer(configuration.GetConnectionString("MainDB")));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPlayerRepository, PlayerRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPlayerServices, PlayerServices>();
        }
    }
}
