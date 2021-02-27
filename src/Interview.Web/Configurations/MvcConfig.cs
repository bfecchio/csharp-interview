using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;

namespace Interview.Web.Configurations
{
    public static class MvcConfig
    {
        #region Extension Methods

        public static IServiceCollection AddMvcConfiguration(this IServiceCollection services)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            services.AddControllersWithViews();
            services.AddRazorPages();

            return services;
        }

        #endregion
    }
}
