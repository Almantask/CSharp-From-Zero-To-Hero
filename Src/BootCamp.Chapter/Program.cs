using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This is for homework 3");

            string personName = Lesson3.GetNameofPerson();
            string personSurname = Lesson3.GetSurnameofPerson();
            int personAge = Lesson3.GetAgeofPerson();
            float personWeight = Lesson3.GetWeightofPerson();
            float personHeight = Lesson3.GetHeightofPerson();
            float personBMI = Lesson3.GetBMIofPerson(personWeight, personHeight);
            Lesson3.PrintInfoPerson(personName, personSurname, personAge, personWeight, personHeight, personBMI);



             personName = Lesson3.GetNameofPerson();
             personSurname = Lesson3.GetSurnameofPerson();
             personAge = Lesson3.GetAgeofPerson();
             personWeight = Lesson3.GetWeightofPerson();
             personHeight = Lesson3.GetHeightofPerson();
             personBMI = Lesson3.GetBMIofPerson(personWeight, personHeight);
            Lesson3.PrintInfoPerson(personName, personSurname, personAge, personWeight, personHeight, personBMI);
        }

    }
}
