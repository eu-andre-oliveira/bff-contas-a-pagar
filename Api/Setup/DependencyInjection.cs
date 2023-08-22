using Application.Services;
using Application.Services.Interfaces;

namespace Api.Setup
{
    public static class DependencyInjection
    {
        public static ServiceProvider Provider { get; private set; }

        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IContaService, ContaService>();

            Provider = services.BuildServiceProvider();
        }
    }
}
