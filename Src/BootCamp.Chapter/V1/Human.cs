using System;

namespace BootCamp.Chapter.V1
{
    class Human
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
            // when human talks he says bla bla bla 10 times
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
            Console.WriteLine("Bla bla bla");
        }
        public void Walk()
        {
            // when human walks, he says step step step 10 times
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
            Console.WriteLine("Step step step");
        }
    }
}