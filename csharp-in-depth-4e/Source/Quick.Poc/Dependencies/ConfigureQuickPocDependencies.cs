using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;

namespace Quick.Poc.Dependencies
{
    public static class ConfigureQuickPocDependencies
    {

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IGenerateName, GenerateName>();

            return services;
        }

    }
}
