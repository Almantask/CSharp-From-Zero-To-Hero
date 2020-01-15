using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tom";
            string lastName = "Jefferson";
            Decimal prisonerAge = 19;
            Decimal weight = 50;
            Decimal height = 156.5m;
            Decimal bodyMassIndex = (weight / height / height) * 10000;

            Console.WriteLine(firstName + " " + lastName + ", is " + prisonerAge + " years old, " + weight + " kg, and " + height + " cm.");
            Console.WriteLine("Prisoner BMI: " + bodyMassIndex);
            Console.ReadLine();

            string firstNameTu = "Kai";
            string lastNameTu = "the Nigerian C# prince";
            Decimal prisonerAgeTu = 25;
            Decimal weightTu = 69;
            Decimal heightTu = 420;
            Decimal bodyMassIndexTu = (weightTu / heightTu / heightTu) * 10000;

            Console.WriteLine(firstNameTu + " " + lastNameTu + ", is " + prisonerAgeTu + " years old, " + weightTu + " kg, and " + heightTu + " cm.");
            Console.WriteLine("Prisoner BMI: " + bodyMassIndexTu);
            Console.ReadLine();

        }
    }
}
