using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;
using RecruiterServices = Interview.Recruiter.Infrastructure.IoC;

namespace Interview.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        #region Extension Methods

        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            RecruiterServices.DependencyInjector.RegisterAll(services);
        }

        #endregion
    }
}
