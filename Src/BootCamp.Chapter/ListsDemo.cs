using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class ListsDemo
    {
        public static IEnumerable<string> Names => new List<string>()
        {
            "Milda",
            "Andy",
            "Garry",
            "Fred",
            "Chiquita",
            "Christiana",
            "Hugh",
            "Bethel",
            "Keven",
            "Marilyn",
            "Derek",
            "Shizue",
            "Aurelio",
            "Noella",
            "Alan",
            "Bart",
            "Annemarie",
            "Shantay",
            "Gertha",
            "Lakesha",
            "Elsie",
            "Florence",
            "Teodora",
            "Tressie",
            "Jenae",
            "Dewey",
            "Sally",
            "Eboni",
            "May",
            "Ezra",
            "Claudio",
            "Santa",
            "Clement",
            "Garrett",
            "Patsy",
            "Salome",
            "Adena",
            "Jacki",
            "Jamaal",
            "Hilary",
            "Darci",
            "Shalanda",
            "Denver",
            "Sheryl",
            "Cristin",
            "Alverta",
            "Elayne",
            "Cathy",
            "Beaulah",
            "Bryant"
        };

        public static IEnumerable<int> Numbers => GenerateRandomNumbers();

        private static IEnumerable<int> GenerateRandomNumbers()
        {
            var numbersList = new List<int>();
            var random = new Random();
            for (var i = 0; i < 200; i++)
            {
                numbersList.Add(random.Next(1, 500));
            }

            return numbersList;
        }
    }
}