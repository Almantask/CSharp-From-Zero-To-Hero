using System;
// ReSharper disable All
#pragma warning disable 649

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main()
        {
            
        }

        private DataMutationPreventionDemoUsingProperties()
        {
            var personGood = new Person()
            {
                Name = "Tom",
                Age = 50
            };

            var personBad = new BadPerson()
            {
                Name = "Tom",
                Age = 50
            };

            RefTest(ref personGood.Age);
            RefTest(ref personBad.Age);
        }

        private static void RefVsOut()
        {

        }

        private static void OutNotUsed(out int number)
        {
            number = 5;
        }

        private static void RefNotUsed(ref int number)
        {

        }

        private static void RefDemo2()
        {
            var person = new Person()
            {
                Name = "Tonny"
            };

            TestPerson(person);
            Console.WriteLine(person.Name);
            RefTestPerson(ref person);
            Console.WriteLine(person.Name);
        }

        private static void TestPerson(Person person)
        {
            person = new Person()
            {
                Name = "John"
            };
        }

        private static void RefTestPerson(ref Person person)
        {
            person = new Person()
            {
                Name = "John"
            };
        }

        private static void RefDemo1()
        {
            int number = 1;
            Test(number);
            Console.WriteLine(number); // prints 1.
            RefTest(ref number);
            Console.WriteLine(number); // prints 5.
        }

        // a copy of reference to number is passed.
        private static void RefTest(ref int number)
        {
            number = 5;
        }

        private static void OutDemo()
        {
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out var number);
            // prints parsed number or 0 (default)
            Console.WriteLine(number); 
        }

        private static void InDemo()
        {
            const int number = 5;
            InTest(number);
        }

        private static void InTest(in int number)
        {
            Console.WriteLine(number);
        }

        private static void DiscardDemo()
        {
            var input = Console.ReadLine();
            // the out is ignored (dicarded)
            var isNumber = int.TryParse(input, out _);
            // true or false depending on input
            Console.WriteLine(isNumber); 
        }

        // a copy of number is passed.
        private static void Test(int number) 
        {
            number = 5;
        }
    }

    readonly struct Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double CalculateDistance(Point p2)
        {
            return Math.Sqrt((X - p2.X)*(X - p2.X) +
                             (Y - p2.Y)*(Y - p2.Y));
        }

        public static bool TryParse(string input, out Point point)
        {
            point = default;
            if (string.IsNullOrEmpty(input)) return false;

            var parts = input.Split(",");
            if (parts.Length != 2) return false;

            var areBothNumbers = int.TryParse(parts[0], out var x) &
                                int.TryParse(parts[1], out var y);
            if (!areBothNumbers) return false;

            point = new Point(x, y);

            return true;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private ContactInfo ContactInfo { get; set; }
    }

    class BadPerson
    {
        public string Name { get; set; }
        public int Age;
        private ContactInfo ContactInfo { get; set; }
    }

    class ContactInfo
    {
        public PhoneNumber Number1 { get; set; }
        public PhoneNumber Number2 { get; set; }
    }

    readonly struct PhoneNumber
    {
        public readonly string Number;
        public readonly string AreaCode;
        public readonly string Country;

        public PhoneNumber(string number, string areaCode, string country)
        {
            Number = number;
            AreaCode = areaCode;
            Country = country;
        }
    }
}
