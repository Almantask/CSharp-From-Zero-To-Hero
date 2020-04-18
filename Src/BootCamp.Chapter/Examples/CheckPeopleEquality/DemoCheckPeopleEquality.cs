using System;

namespace BootCamp.Chapter.Examples.CheckPeopleEquality
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1?.Name == person2?.Name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }

    public static class DemoCheckPeopleEquality
    {
        public static void Run()
        {
            var person1 = new Person("Tom");
            var person2 = new Person("Gar");
            var person3 = new Person("Tom");

            // False
            Console.WriteLine($"person1(Tom) == person2(Gar) = {person1 == person2}");
            // True
            Console.WriteLine($"person1(Tom) == person3(Tom) = {person1 == person3}");
        }
    }
}
