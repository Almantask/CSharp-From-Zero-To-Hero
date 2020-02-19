using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Kaisinel", new DateTime(1994, 5, 25));
            person1.SetSurename("C# Inn");

            var person2 = new Person();

            Console.WriteLine($"{person1.GetFullName()} is {person1.GetAge()}");
            Console.WriteLine(person2.GetFullName());
            person1.Talk("Hello world!");

            Console.WriteLine(Person.GetClassName());
        }
    }
}
