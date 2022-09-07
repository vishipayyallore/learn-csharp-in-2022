using HeaderFooter.Lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HeaderFooter.Lib.Dependencies
{
    public static class HeaderFooterDependencies
    {

        public static IServiceCollection ConfigureHeaderFooterServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IHeader, Header>();
            _ = services.AddTransient<IFooter, Footer>();

            return services;
        }

    }

}
