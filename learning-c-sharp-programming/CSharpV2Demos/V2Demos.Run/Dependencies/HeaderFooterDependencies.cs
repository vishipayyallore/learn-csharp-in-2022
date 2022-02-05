using HeaderFooter.Lib;
using HeaderFooter.Lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace V2Demos.Run.Dependencies
{
    public static class HeaderFooterDependencies
    {

        public static IServiceCollection ConfigureHeaderFooterServices(this IServiceCollection services)
        {
            services.AddTransient<IHeader, Header>();
            services.AddTransient<IFooter, Footer>();

            return services;
        }

    }

}
