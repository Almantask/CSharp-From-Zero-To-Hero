using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string personOneFirstName;
            string personOneLastName;
            int personOneAge;
            double personOneHeight;
            double personOneWeight;
            double personOneBMI;

            string personTwoFirstName;
            string personTwoLastName;
            int personTwoAge;
            double personTwoHeight;
            double personTwoWeight;
            double personTwoBMI;


            Console.WriteLine("This is your friendly BMI Checker!");
            Console.Write("Please Input person ones first name. ");
            personOneFirstName = Console.ReadLine();
            //Console.WriteLine(personOneFirstName);
            Console.Write("Thank you, please input " + personOneFirstName + "'s last name. ");
            personOneLastName = Console.ReadLine();
            Console.Write(personOneFirstName + " Age in years now please ");
            personOneAge = int.Parse(Console.ReadLine());
            //Console.WriteLine(personOneAge);
            Console.Write("And now their Height in CM ");
            personOneHeight = double.Parse(Console.ReadLine());
            Console.Write("And finally " + personOneFirstName + "'s Weight in kg please. ");
            personOneWeight = double.Parse(Console.ReadLine());
            personOneBMI = ((personOneWeight / personOneHeight / personOneHeight) * 10000);
            personOneBMI = Math.Round(personOneBMI, 1);
            Console.WriteLine(personOneFirstName + " " + personOneLastName + " is " + personOneAge + " years old, their weight is " + personOneWeight + "kg and their height is " + personOneHeight + "cm.");
            Console.WriteLine(personOneFirstName + " " + personOneLastName + "'s BMI is " + personOneBMI);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Ok, thats person one, now, lets check person two's BMI.");
            Console.Write("Please Input person two's first name. ");
            personTwoFirstName = Console.ReadLine();
            Console.Write("Thank you, please input " + personTwoFirstName + "'s last name. ");
            personTwoLastName = Console.ReadLine();
            Console.Write(personTwoFirstName + " Age in years now please ");
            personTwoAge = int.Parse(Console.ReadLine());
            Console.Write("And now their Height in CM ");
            personTwoHeight = double.Parse(Console.ReadLine());
            Console.Write("And finally " + personTwoFirstName + "'s Weight in kg please. ");
            personTwoWeight = double.Parse(Console.ReadLine());
            personTwoBMI = ((personTwoWeight / personTwoHeight / personTwoHeight) * 10000);
            personTwoBMI = Math.Round(personTwoBMI, 1);
            Console.WriteLine(personTwoFirstName + " " + personTwoLastName + " is " + personTwoAge + " years old, their weight is " + personTwoWeight + "kg and their height is " + personTwoHeight + "cm.");
            Console.WriteLine(personTwoFirstName + " " + personTwoLastName + "'s BMI is " + personTwoBMI);


            Console.WriteLine(" ");

            Console.WriteLine("Thanks for using my BMI Checker!");
        }
    }
}
