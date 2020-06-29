using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Events
{
    public static class ApplicationStateEvents
    {
        public static void OnApplicationStateChange(object sender, ApplicationStateEventArgs e)
        {
            var message = sender as string;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[STATUS - {e.TimeFired}] {e.State}, {message}");
            Console.ResetColor();
        }
    }
}
