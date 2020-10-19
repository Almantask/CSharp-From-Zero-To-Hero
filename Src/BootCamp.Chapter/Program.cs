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

            string personName = Lesson3.NameofPerson();
            string personSurname = Lesson3.SurnameofPerson();
            int personAge = Lesson3.AgeofPerson();
            float personWeight = Lesson3.WeightofPerson();
            float personHeight = Lesson3.HeightofPerson();
            float personBMI = Lesson3.BMIofPerson(personWeight, personHeight);
            Lesson3.InfoPerson(personName, personSurname, personAge, personWeight, personHeight, personBMI);



             personName = Lesson3.NameofPerson();
             personSurname = Lesson3.SurnameofPerson();
             personAge = Lesson3.AgeofPerson();
             personWeight = Lesson3.WeightofPerson();
             personHeight = Lesson3.HeightofPerson();
             personBMI = Lesson3.BMIofPerson(personWeight, personHeight);
            Lesson3.InfoPerson(personName, personSurname, personAge, personWeight, personHeight, personBMI);
        }

    }
}
