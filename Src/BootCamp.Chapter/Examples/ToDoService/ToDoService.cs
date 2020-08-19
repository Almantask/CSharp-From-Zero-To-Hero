using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.Singletons.Config;
using Microsoft.Extensions.Options;

namespace BootCamp.Chapter.Examples.ToDoService
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
            _config.Email = "SomethingElse@gmail.com";
        }
    }
}
