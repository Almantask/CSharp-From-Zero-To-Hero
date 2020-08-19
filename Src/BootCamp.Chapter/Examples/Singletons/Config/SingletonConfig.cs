using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Singletons.Config
{
    public class SingletonConfig
    {
        public string Email { get; set; }
        public string LogFile { get; set; }
        public bool ReminderOn { get; set; }

        private static readonly Lazy<SingletonConfig> _singletonConfig = new Lazy<SingletonConfig>();

        public static SingletonConfig Instance => _singletonConfig.Value;

        private SingletonConfig() { }
    }
}
