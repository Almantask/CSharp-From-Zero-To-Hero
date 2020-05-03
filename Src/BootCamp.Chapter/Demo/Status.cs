using System;

namespace BootCamp.Chapter.Demo
{
    public class Status
    {
        public static void ShowStatus(object sender, EventArgs e)
        {
            var message = sender as string;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[STATUS] {message}");
            Console.ResetColor();
        }
    }
}