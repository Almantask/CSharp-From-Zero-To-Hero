using System;

namespace BootCamp.Chapter.Examples.Employee_NullObject
{
    public static class PersonEmploymentDemo
    {
        public static void Run()
        {
            var donut = new Person("Donut");
            Console.WriteLine($"{donut.Name}: {donut.Employment.Name} - {donut.Employment.Salary}");

            var kaisinel = new Person("Kaisinel", new Employed("Teacher", 1));
            Console.WriteLine($"{kaisinel.Name}: {kaisinel.Employment.Name} - {kaisinel.Employment.Salary}");
        }
    }
}
