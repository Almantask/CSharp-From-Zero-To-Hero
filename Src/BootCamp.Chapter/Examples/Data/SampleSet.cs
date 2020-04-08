using System;
using System.Collections.Generic;
using System.Drawing;
using BootCamp.Chapter.Examples.Models;

namespace BootCamp.Chapter.Examples.Data
{
    public class SampleSet
    {
        public static List<Car> Cars1;
        public static List<Car> Cars2;
        public static List<Person> People1;
        public static List<Person> People2;
        public static List<CarOwner> Carowners;

        static SampleSet()
        {
            Cars1 = new List<Car>
            {
                new Car("Berlingo", "Citroen", Color.Beige)
                {
                    OwnerId = 1
                },
                new Car("TTS", "Audi", Color.DarkSlateBlue),
                new Car("SX4", "Suzuki", Color.DarkSlateBlue),
                new Car("X6", "BMW", Color.Black)
            };

            Cars2 = new List<Car>
            {
                new Car("CR-V", "Honda", Color.DarkRed)
                {
                    OwnerId = 2
                },
                new Car("Transporter", "Volkswagen", Color.DarkViolet),
                new Car("Golf", "Volkswagen", Color.Black)
                {
                    OwnerId = 3
                },
                new Car("100", "Audi", Color.DarkSlateBlue)
                {
                    OwnerId = 3
                },
                new Car("X1", "BMW", Color.DarkRed)
                {
                    OwnerId = 1
                },
                new Car("Passat", "Volkswagen", Color.Black)
            };

            People1 = new List<Person>
            {
                new Person(1, "Tom", new DateTime(1994, 2, 3)),
                new Person(2, "Agnes", new DateTime(1989, 8, 3)),
                new Person(3, "Gary", new DateTime(1999, 9, 9)),
                new Person(4, "Sarah", new DateTime(1996, 11, 2))
            };

            People2 = new List<Person>
            {
                new Person(5, "Gareth", new DateTime(2001, 5, 3)),
                new Person(6, "Nicola", new DateTime(2003, 5, 9)),
                new Person(8, "Julia", new DateTime(1958, 12, 25))
            };

            Carowners = new List<CarOwner>
            {
                new CarOwner(People1[0], new [] { Cars1[0], Cars2[2] }),
                new CarOwner(People1[1], new [] { Cars2[0] }),
            };
        }
    }
}
