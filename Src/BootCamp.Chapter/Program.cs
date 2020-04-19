using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Demo demo = new Demo();

            Logger log = new Logger(demo);

            demo.StartDemo();
            
            //string max = "Gavra,Padkin,3/13/1997,Female,Moldova,gpadkin1@marketwatch.com,3550 Hansons Lane";

            //if (Person.TryParse(max,out Person person))
            //{
            //    Console.WriteLine(person.GetAge());
            //}
        }
    }
}
