using Microsoft.Extensions.DependencyInjection;

using Interview.Core.Domain;
using Interview.Data.Context;
using Interview.Domain.Services;
using Interview.Domain.Interfaces;
using Interview.Domain.Repositories;
using Interview.Data.Repositories;

namespace Interview.Infrastructure.IoC
{
    public static class DependencyInjector
    {
        #region Extension Methods

        public static IServiceCollection RegisterAll(this IServiceCollection services)
        {
            Guard.AssertArgumentNotNull(services, "The services is required.");

            services
                .RegisterData()
                .RegisterDomainServices();

            return services;
        }

        #endregion

        #region Methods

        private static IServiceCollection RegisterData(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();

            return services;
        }

        private static IServiceCollection RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ISmsService, SmsService>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<ICandidateService, CandidateService>();

            return services;
        }

        #endregion
    }
}
