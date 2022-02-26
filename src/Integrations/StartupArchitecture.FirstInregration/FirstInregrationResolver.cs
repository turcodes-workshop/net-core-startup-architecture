using Microsoft.Extensions.DependencyInjection;
using StartupArchitecture.FirstInregration.Abstracts;
using StartupArchitecture.FirstInregration.Concretes;

namespace StartupArchitecture.FirstInregration
{
    public static class FirstInregrationResolver
    {
        public static void FirstIntegrationResolve(this IServiceCollection services)
        {
            services.AddScoped<IFirstIntegrationBusiness, FirstIntegrationBusiness>();
        }
    }
}
