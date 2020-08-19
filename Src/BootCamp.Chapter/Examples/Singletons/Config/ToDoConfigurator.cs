using Microsoft.Extensions.DependencyInjection;

namespace BootCamp.Chapter.Examples.Singletons.Config
{
    public static class ToDoServiceBuilder
    {
        public static ToDoService.ToDoService BuildToDoService()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider.GetService<ToDoService.ToDoService>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ToDoService.ToDoService>();
        }
    }
}
