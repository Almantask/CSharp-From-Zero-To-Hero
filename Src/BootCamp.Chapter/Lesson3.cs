using System;

namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static void Demo()
        {
            Checks.PromptString("Enter String Data");
            Checks.PromptInt("Enter Int Data");
            Checks.PromptFloat("Enter Float Data");
            Checks.CalculateBmi(Checks.Height, Checks.Weight);

            Console.WriteLine($"{Checks.Name} {Checks.Surname} is {Checks.Age} old, his weight is " +
                $"{Checks.Weight}KG and his height is {Checks.Height}cm");
        }

        //    public string Name { get; set; }
        //    public string Surname { get; set; }
        //    public int Age { get; set; }
        //    public int Weight { get; set; }
        //    public double Height { get; set; }

        //    public void getStringData()
        //    {
        //        Console.WriteLine("Enter Name: ");
        //        Name = Console.ReadLine();
        //        Console.WriteLine("Enter Surname: ");
        //        Surname = Console.ReadLine();

        //    }


        //    public void getIntData()
        //    {
        //        Console.WriteLine("Enter Age: ");
        //        if (!int.TryParse(Console.ReadLine(), out int age))
        //        {
        //            Console.WriteLine("Age Should be a Number");
        //        }
        //        else
        //        {
        //            Age = age;
        //        }

        //        Console.WriteLine("Enter Weight: ");
        //        if (!int.TryParse(Console.ReadLine(), out int weight))
        //        {
        //            Console.WriteLine("Weight must be a Number");
        //        }
        //        else
        //        {
        //            Weight = weight;
        //        }


        //    }

        //    public void getDoubleData()
        //    {
        //        Console.WriteLine("Enter Height: ");
        //        if (!double.TryParse(Console.ReadLine(), out double height))
        //        {
        //            Console.WriteLine("Height Must be a Number");
        //        }

        //    }


        //    public double calcBMI()
        //    {
        //        return Height / Weight;
        //    }

        //    public void printInfo()
        //    {
        //        Console.WriteLine($"{Name} {Surname} is {Age} old, his weight is " +
        //            $"{Weight}KG and his height is {Height}cm");

        //        Console.WriteLine($"BMI is {calcBMI()}");
        //    }


    }
}