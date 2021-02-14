using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static event EventHandler ApplicationCloses;

        static void Main(string[] args)
        {
            ApplicationCloses += PrintQuitMessage;

            Demo demo = new Demo();

            ApplicationCloses?.Invoke(demo, null);
        }

        private static void PrintQuitMessage(object sender, EventArgs eventArgs)
        {
            var demoInstance = sender as Demo;

            Console.WriteLine($"Application closes. Last key pressed was '{demoInstance.currentChar}'.");

            ApplicationCloses -= PrintQuitMessage;
        }
    }
}
