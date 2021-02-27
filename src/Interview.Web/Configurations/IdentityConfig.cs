using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Interview.Data;
using Interview.Core.Domain;

namespace Interview.Web.Configurations
{
    public static class IdentityConfig
    {
        #region Extension Methods

        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            services
                .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        #endregion
    }
}
