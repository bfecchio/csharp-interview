using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;
using Interview.Recruiter.Data.Context;

namespace Interview.Web.Configurations
{
    public static class DatabaseConfig
    {
        #region Extension Methods

        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            services.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        #endregion
    }
}
