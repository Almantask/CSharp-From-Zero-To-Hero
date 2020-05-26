using System;
using System.ComponentModel;
using System.Threading;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string tFirst = ("Tom");
            string tSur = ("Jefferson");
            int tWeight = 50;
            float tHeight = 1.565F;
            float tBmi = tWeight / tHeight;
            int tAge = 19;

            Console.Write("Hello world!" + System.Environment.NewLine);

            Console.WriteLine( tFirst + (" ")+ tSur + "'s age is " + tAge + " and his height is " + tHeight + " and his weight is " + tWeight + " BMI is: " + tBmi);
            

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 2; i++)
            {


                Console.WriteLine("Please enter your first name. ");
                string firstName = Console.ReadLine();
                Console.Write("Now please enter your surname. " + System.Environment.NewLine);
                string surname = Console.ReadLine();
                Console.WriteLine("Hello " + firstName + " " + surname);

                Console.WriteLine("Please enter your age now. ");
                int yourAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your height now. ");
                double yourHeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your weight now. ");
                int yourWeight = Convert.ToInt32(Console.ReadLine());
                double yourBMI = yourWeight / yourHeight;
                Console.WriteLine("Alright " + firstName + ", " + "you are " + yourAge + " years old, and your BMI based off your provided measurements is " + yourBMI);

                Console.WriteLine("Press enter continue...");

                Console.ReadLine();
                Console.Clear();
            }



        }
    }
}
