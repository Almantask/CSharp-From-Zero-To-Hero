using System;
using Microsoft.Extensions.DependencyInjection;

namespace BootCamp.Chapter.Examples.Singletons.Config
{
    public static class ToDoServiceBuilder
    {
        public static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ToDoService>();
            services.AddConfig();
        }
    }
}
