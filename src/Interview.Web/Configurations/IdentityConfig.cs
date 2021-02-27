using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;
using Interview.Recruiter.Data.Context;

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
