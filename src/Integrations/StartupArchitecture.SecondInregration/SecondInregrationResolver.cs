using Microsoft.Extensions.DependencyInjection;
using StartupArchitecture.SecondInregration.Abstracts;
using StartupArchitecture.SecondIntegration.Concretes;

namespace StartupArchitecture.FirstInregration
{
    public static class SecondInregrationResolver
    {
        public static void SecondInregrationResolve(this IServiceCollection services)
        {
            services.AddScoped<ISecondIntegrationBusiness, SecondIntegrationBusiness>();
        }
    }
}
