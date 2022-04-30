using ArrayListDemos.Run.Apps;
using HeaderFooter.Lib.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib.Dependencies;
using NamesArrayListDemo.Lib.Dependencies;

namespace ArrayListDemos.Run.Dependencies
{
    public static class ConfigureNamesArrayListDemoApp
    {

        public static ServiceProvider ConfigureServices()
        {
            // create service collection
            IServiceCollection services = new ServiceCollection();

            _ = services.ConfigureHeaderFooterServices();
            _ = services.ConfigureNameGeneratorServices();
            _ = services.ConfigureNamesArrayListDemoServices();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<NamesArrayListDemoApp>();

            return services.BuildServiceProvider();
        }

    }

}
