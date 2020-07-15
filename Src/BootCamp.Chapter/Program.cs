using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter weight (lbs): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Enter height (in): ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine($"\n{name} is {age} years old. Their weight is {weight}lbs and height is {height}in.");
            float calcBMI = (703 * weight) / (height * height);
            Console.WriteLine($"{name}'s BMI is {calcBMI}.\n");

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter weight (lbs): ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Enter height (in): ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine($"\n{name} is {age} years old. Their weight is {weight}lbs and height is {height}in.");
            calcBMI = (703 * weight) / (height * height);
            Console.WriteLine($"{name}'s BMI is {calcBMI}.\n");

            Console.ReadKey();
        }
    }
}
