using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
// ReSharper disable All
#pragma warning disable 169
#pragma warning disable 219

namespace BootCamp.Chapter
{
    [SuppressMessage("ReSharper", "UseObjectOrCollectionInitializer")]
    class Program
    {
        enum GenderMore: byte
        {
            Smth = 255
        }

        static void Main(string[] args)
        {
            CallIndexer();
            //CallPropertyDemo();
            //EnumDemo();
            //EmptyListExampleForRemoveElementX();
            //LessonMaterialForSlides();
        }

        private static void CallIndexer()
        {
            var intentory = new Inventory();
            var weaponsCount = intentory[ItemTypes.Weapon];
        }

        private static void CallPropertyDemo()
        {
            var person = new Person("Tom", "Tompson");
            Console.WriteLine(person.Name);
        }

        private static void EnumDemo()
        {
            Gender gender = (Gender) 1;
            // Prints 1
            Console.WriteLine(gender);
            gender += 5;
            // Prints Female
            Console.WriteLine(gender);
        }

        private static void EmptyListExampleForRemoveElementX()
        {
            var items = new List<int>();
            items.Remove(0);
            // Works
            Console.WriteLine("Done");
            Console.Read();
        }

        private static void LessonMaterialForSlides()
        {
            var inventory = new Inventory();
            var potionsCount = inventory[ItemTypes.Potion];

            // Empty list
            var numbers = new List<int>();
            // Add new element to the end of list
            numbers.Add(4);
            // Remove element at index 0
            numbers.RemoveAt(0);
            // {}
            numbers.Clear();
            // false
            var isAny = numbers.Any();

            var words = new List<string> {"Yes", "No"};
            var numbers2 = new List<int> {1, 2};
            var bools = new List<bool> {true, false};

            // Doesn't mean that it cannot have more than 5 elements.
            var list = new List<string>(5);

            //var currentLight = TrafficLights.Red;
            //while (true)
            //{
            //    var lightIndex = ((int) currentLight + 1) % 3;
            //    currentLight = (TrafficLights)lightIndex;
            //    Console.WriteLine(currentLight);
            //    Console.ReadLine();
            //}

            var myGender = Gender.Male;

            var currentLight = TrafficLights.Red;
            while (true)
            {
                currentLight = (currentLight + 1) % 3;

                switch (currentLight)
                {
                    case TrafficLights.Red:
                        Console.WriteLine("Red");
                        break;
                    case TrafficLights.Green:
                        Console.WriteLine("Green");
                        break;
                    case TrafficLights.Yellow:
                        Console.WriteLine("Yellow");
                        break;
                    default:
                        Console.WriteLine("Unrecognized");
                        break;
                }

                Console.ReadLine();
            }
        }
    }

    enum Gender
    {
        Male,
        Female = 6,
        Other
    }

    //enum TrafficLights
    //{
    //    Red,
    //    Yellow,
    //    Green
    //}

    static class TrafficLights
    {
        public const int Red = 0;
        public const int Yellow = 1;
        public const int Green = 2;
    }

    class Person
    {
        // is the same as
        // public string Name {get;set;}
        private string _name;
        public string Name
        {
            set => _name = value;
            get => _name;
        }

        

        public string Surename { get; set; }

        public string Fullname
        {
            get { return $"{Name} {Surename}"; }
        }

        public Person(string surename, string name)
        {
            Surename = surename;
            Name = name;
        }
    }

    class Inventory
    {
        private List<string> _items;

        /// <summary>
        /// Get items count by type
        /// </summary>
        public int this[string type]
        {
            get
            {
                return CountItems(type);
            }
        }

        public Inventory()
        {
            _items = new List<string>();
        }

        private int CountItems(string type)
        {
            var count = 0;
            foreach (var item in _items)
            {
                if (item.Contains(type.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
    }

    static class ItemTypes
    {
        public const string Potion = "Potion";
        public const string Weapon = "Weapon";
        public const string Armour = "Armour";
    }
}
