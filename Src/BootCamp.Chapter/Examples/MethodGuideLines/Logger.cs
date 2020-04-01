using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.MethodGuideLines
{
    public static class Logger
    {
        public static void LogBad<T>(T message)
        {
            // We can consume the message as is anyways.
            // If an object can be converted to a string, it should be.
            Console.WriteLine(message.ToString());
        }

        // Using generics was just an uneeded complexity. 
        // This is more simple and intuitive.
        public static void LogBetter(object message)
        {
            Console.WriteLine(message.ToString());
        }
    }


}
