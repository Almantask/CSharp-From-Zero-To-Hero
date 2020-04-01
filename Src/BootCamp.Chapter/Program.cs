using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using BootCamp.Chapter.Examples.Extensions;
using BootCamp.Chapter.Examples.MethodGuideLines;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringExtensionsDemo();
            IListExtensionsDemo();

            //Console.WriteLine(Gender.Other.GetName());
        }

        private static void IListExtensionsDemo()
        {
            List<string> words1 = new List<string>
            {
                "Passion",
                "Charity",
                "Help",
                "Friend",
                "Love"
            };

            string[] words2 =
            {
                "Passion",
                "Charity",
                "Help",
                "Friend",
                "Love"
            };

            words1.Print();
            words2.Print();
        }

        private static void StringExtensionsDemo()
        {
            var name = "kaisi";
            Console.WriteLine(name.ToPascalCase());
            Console.WriteLine(StringExtensions.ToPascalCase(name));
        }

        private static void PeopleFilterDemo()
        {
            List<Person> peopleList = new List<Person>{new Person("Tom")};
            Person[] peopleArray = new Person[] {new Person("Tom")};

            IEnumerable<Person> toms1 = PeopleFilter.Filter(peopleList, person => person.Name == "Tom");
            IEnumerable<Person> toms2 = PeopleFilter.Filter(peopleArray, person => person.Name == "Tom");
        }
    }
}
