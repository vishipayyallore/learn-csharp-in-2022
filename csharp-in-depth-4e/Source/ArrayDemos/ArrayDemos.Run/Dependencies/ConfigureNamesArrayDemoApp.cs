using ArrayDemos.Run.Apps;
using HeaderFooter.Lib.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib.Dependencies;
using NamesArrayDemo.Lib.Dependencies;

namespace ArrayDemos.Run.Dependencies
{
    public static class ConfigureNamesArrayDemoApp
    {

        public static ServiceProvider ConfigureServices()
        {
            // create service collection
            IServiceCollection services = new ServiceCollection();

            _ = services.ConfigureHeaderFooterServices();
            _ = services.ConfigureNameGeneratorServices();
            _ = services.ConfigureNamesArrayDemoServices();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<NamesArrayDemoApp>();

            return services.BuildServiceProvider();
        }

    }

}
