using System;
using Microsoft.Extensions.Options;

namespace BootCamp.Chapter.Examples.Singletons.Config
{
    public class ToDoService
    {
        private readonly ToDoConfig _config;

        public ToDoService(IOptions<ToDoConfig> config)
        {
            _config = config?.Value ?? throw new ArgumentNullException(nameof(config));
        }

        public void Test()
        {
            Console.WriteLine("Email: " + _config.Email);
            // It does not work with a copy- it's still the same instance!
            // Even if we create a new ToDoService!
            _config.Email = "SomethingElse@gmail.com";
        }
    }
}
