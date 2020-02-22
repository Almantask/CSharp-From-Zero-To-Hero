using System;

namespace BootCamp.Chapter.V2
{
    // Dog robots can bit
    // They should support being turned of using serial code
    class DogRobot : Chapter.V2.Robot
    {
        // I don't want to expose this to the outside.
        // However I still want to be able to potentially do something with it in other robots.
        protected string _serialCode;

        public void Bite()
        {
            Console.WriteLine("Bite");
        }

        public void EmergencyShutdown()
        {
            Console.WriteLine($"Scanning serial code {_serialCode}...");
            Console.WriteLine("Sending data to factory...");
            Console.WriteLine("Shutting down...");
        }
    }
}