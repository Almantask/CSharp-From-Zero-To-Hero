using System;

namespace BootCamp.Chapter.V1
{
    class Robot
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public void Talk()
        {
            // when robot talks he says Beep bop 10 times
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
            Console.WriteLine("Beep bop");
        }

        public void Walk()
        {
            // When robot walks he says Autobots rolling out! 10 times
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
            Console.WriteLine("Autobots rolling out!");
        }
    }
}