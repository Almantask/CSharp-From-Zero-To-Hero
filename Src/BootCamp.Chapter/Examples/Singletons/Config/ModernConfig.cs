using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BootCamp.Chapter.Examples.Singletons.Config
{
    public static class ModernConfig
    {
        public static void AddConfig(this IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            services.Configure<ToDoConfig>(configuration.GetSection("ToDo"));
        }
    }
}
