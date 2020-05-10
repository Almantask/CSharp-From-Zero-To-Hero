using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // List holding all objects
            var allPeople = new List<Person>();

            while (true)
            {
                // Takes in the user's choice to either enter a new set of details to calculate the BMI of or to view all current entries.
                Console.WriteLine("Please enter 'newbmi' to calculate a new person's BMI or enter 'view' to see all current entries: ");
                string currentChoice = Console.ReadLine();

                // Checks if the user's choice is empty, if so skips the rest of the loop and tries again.
                if (string.IsNullOrWhiteSpace(currentChoice))
                {
                    continue;
                }

                // Checks if the user chose to calculate a new BMI or view all existing entries.
                if (currentChoice.Equals("newbmi", StringComparison.OrdinalIgnoreCase))
                {
                    // Takes in all the values necessary for a new entry
                    Console.WriteLine("Please enter the person's full name: ");
                    var fullName = Console.ReadLine();

                    Console.WriteLine("Please enter the person's age: ");
                    var age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the person's weight in kilograms: ");
                    var weight = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter the person's height in centimetres: ");
                    var height = Convert.ToDouble(Console.ReadLine());
                    height = height / 100;

                    var time = DateTime.Now;

                    // Adds all the properties to an object
                    var currentEntry = new Person(fullName, age, weight, height, time);

                    // Adds the current object to a list
                    allPeople.Add(currentEntry);

                    Console.WriteLine($"New entry for {fullName} created.");
                }
                else if (currentChoice.Equals("view", StringComparison.OrdinalIgnoreCase))
                {
                    // Creates a report to show all the current people
                    var report = new StringBuilder();
                    report.AppendLine($"{"Name",-20} {"Age",-10} {"Weight",-10} {"Height",-10}{"BMI",-10}{"Time",-10}");
                    
                    foreach (var currentIndex in allPeople)
                    {
                        // Report Rows
                        // put these in the same formatting columns we are using above so it looks pretty
                        report.AppendLine($"{currentIndex.FullName,-20} {currentIndex.Age,-10} {currentIndex.Weight,-10} {currentIndex.Height,-9} {currentIndex.BMI,-9} {currentIndex.Time.ToString("HH:mm"),-10}");
                    }

                    Console.WriteLine(report);
                }
            }
        }
    }
}