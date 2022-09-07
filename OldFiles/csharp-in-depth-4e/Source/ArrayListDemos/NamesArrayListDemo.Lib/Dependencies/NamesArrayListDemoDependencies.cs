using Microsoft.Extensions.DependencyInjection;
using NamesArrayListDemo.Lib.Interfaces;

namespace NamesArrayListDemo.Lib.Dependencies
{
    public static class NamesArrayListDemoDependencies
    {

        public static IServiceCollection ConfigureNamesArrayListDemoServices(this IServiceCollection services)
        {
            _ = services.AddTransient<INamesArrayList, NamesArrayList>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            return services;
        }

    }
}
