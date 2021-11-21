using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person("Pete", "R", new DateTime(1990, 12, 18), "male", "Poland", "mail@mail.com", "some address");

            if(p.Gender == Gender.male)
            {
                Console.WriteLine($"{p.Name} is male");
            }

            Console.ReadKey();
        }
    }
}
