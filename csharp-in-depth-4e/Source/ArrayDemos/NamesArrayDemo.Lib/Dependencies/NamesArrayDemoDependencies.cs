using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using NamesArrayDemo.Lib.Interfaces;

namespace NamesArrayDemo.Lib.Dependencies
{

    public static class NamesArrayDemoDependencies
    {

        public static IServiceCollection ConfigureArrayDemoServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IGenerateName, GenerateName>();
            _ = services.AddTransient<INamesArray, NamesArray>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            return services;
        }

    }

}
