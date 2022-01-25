using ArrayDemo.Lib;
using ArrayDemo.Lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib;
using NameGenerator.Lib.Interfaces;
using V2Demos.Run.Apps;

namespace V2Demos.Run.Dependencies
{
    public static class ArrayDemoDependencies
    {

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IGenerateName, GenerateName>();
            services.AddTransient<INamesArray, NamesArray>();
            services.AddTransient<IPrintHelper, PrintHelper>();

            // IMPORTANT! Register the application entry point
            services.AddTransient<ArrayDemoApp>();

            return services;
        }

    }

}
