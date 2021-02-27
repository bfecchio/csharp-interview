using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;

namespace Interview.Web.Configurations
{
    public static class AutoMapperConfig
    {
        #region Extension Methods

        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }

        #endregion
    }
}
