﻿using ArrayDemo.Lib;
using ArrayDemo.Lib.Interfaces;
using ArrayDemo.Lib.Sample;
using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Lib.Interfaces;

namespace Demos.Run.Dependencies
{
    public static class ArrayDemoDependencies
    {

        public static IServiceCollection ConfigureArrayDemoServices(this IServiceCollection services)
        {
            services.AddTransient<INameGenerator, NameGenerator.Lib.NameGenerator>();
            services.AddTransient<INamesArray, NamesArray>();
            services.AddTransient<IPrintHelper, PrintHelper>();

            // IMPORTANT! Register the application entry point
            services.AddTransient<ArrayDemoApp>();

            return services;
        }

    }

}
