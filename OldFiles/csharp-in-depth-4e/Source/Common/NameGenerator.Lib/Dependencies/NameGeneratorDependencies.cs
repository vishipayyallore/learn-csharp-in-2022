using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib.Interfaces;

namespace NameGenerator.Lib.Dependencies
{
    public static class NameGeneratorDependencies
    {

        public static IServiceCollection ConfigureNameGeneratorServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IGenerateName, GenerateName>();

            return services;
        }

    }

}
