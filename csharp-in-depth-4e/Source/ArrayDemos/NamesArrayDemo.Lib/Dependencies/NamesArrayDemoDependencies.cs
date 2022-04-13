using Microsoft.Extensions.DependencyInjection;
using NamesArrayDemo.Lib.Interfaces;

namespace NamesArrayDemo.Lib.Dependencies
{

    public static class NamesArrayDemoDependencies
    {

        public static IServiceCollection ConfigureNamesArrayDemoServices(this IServiceCollection services)
        {
            _ = services.AddTransient<INamesArray, NamesArray>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            return services;
        }

    }

}
