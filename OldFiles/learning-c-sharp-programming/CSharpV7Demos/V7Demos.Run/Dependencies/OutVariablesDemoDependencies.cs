using Microsoft.Extensions.DependencyInjection;
using OutVariablesDemo.Lib;
using V7Demos.Run.Apps;

namespace V7Demos.Run.Dependencies
{
    public static class OutVariablesDemoDependencies
    {
        public static IServiceCollection ConfigureOutVariablesServices(this IServiceCollection services)
        {
            // Register the Services
            services.AddTransient<IIntegerParser, IntegerParser>();

            // IMPORTANT! Register the application entry point
            services.AddTransient<OutVariablesDemoApp>();

            return services;
        }
    }

}
