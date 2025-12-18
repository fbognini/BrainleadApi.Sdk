using fbognini.Sdk.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrainleadApi.Sdk
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBrainleadApiService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<BrainleadApiSettings>(configuration.GetSection(nameof(BrainleadApiSettings)));

            services.AddHttpClient<IBrainleadApiService, BrainLeadApiService>(client =>
            {
                client.BaseAddress = new Uri("https://api.brainlead.it/3/");
            })
                .ThrowApiExceptionIfNotSuccess()
                .AddLogging();

            return services;
        }
    }
}
