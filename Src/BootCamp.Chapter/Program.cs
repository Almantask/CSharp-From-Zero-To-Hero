using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Tom Jefferson";
            int age;
            int looper = 1;
            float weight, mheight;

            do
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();

                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Weight");
                weight = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height");
                mheight = float.Parse(Console.ReadLine());

                float BMI1 = weight / (mheight * mheight);

                Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + "kg and his height is " + mheight + " cm.");
                Console.WriteLine(name + "'s BMI is " + BMI1);
                Console.WriteLine("");
                Console.WriteLine("");
                looper++;
            } while (looper < 3);
        }
    }
}
